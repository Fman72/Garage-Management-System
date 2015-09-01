using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Assignment2
{
    //Purpose: Contains the design and methods for the Owner Maintenance form that allows users to use to the form to update/delete/create owner records in the database.
    //Author: Fraser Kearns
    //Date Created: 02/08/15
    public partial class OwnerMaintenanceForm : Form
    {
        //VARIABLE DECLARATIONS
        private DataModule dataModule;
        private MainForm mainForm;
        private CurrencyManager currencyManager;

        //CONSTRUCTOR
        public OwnerMaintenanceForm(DataModule dataModule, MainForm mainForm)
        {
            this.InitializeComponent();
            this.dataModule = dataModule;
            this.mainForm = mainForm;
            this.BindControls();
        }

        //Function that binds values from the database to controls on the form.
        public void BindControls()
        {
            ownerIDDisplayLabel.DataBindings.Add("Text", dataModule.greenDataSet, "OWNER.OwnerID");
            lastNameDisplayLabel.DataBindings.Add("Text", dataModule.greenDataSet, "OWNER.LastName");
            firstNameDisplayLabel.DataBindings.Add("Text", dataModule.greenDataSet, "OWNER.FirstName");
            streetAddressDisplayLabel.DataBindings.Add("Text", dataModule.greenDataSet, "OWNER.StreetAddress");
            suburbDisplayLabel.DataBindings.Add("Text", dataModule.greenDataSet, "OWNER.Suburb");
            phoneNumberDisplayLabel.DataBindings.Add("Text", dataModule.greenDataSet, "OWNER.PhoneNumber");
            ownerListBox.DataSource = dataModule.greenDataSet;
            ownerListBox.DisplayMember = "OWNER.OwnerID";
            ownerListBox.ValueMember = "OWNER.OwnerID";
            currencyManager = (CurrencyManager)this.BindingContext[dataModule.greenDataSet, "OWNER"];
        }

        /// <summary>
        /// This function runs before the names are displayed in the ownerListBox. It retrieves the owner's first and last names and displays them as the displayMember in the listBox.
        /// </summary>
        /// <param name="sender">The object that called this funcion. In this case the ownerListBox.</param>
        /// <param name="e">The event arguments for this format event.</param>
        private void ownerListBox_Format(object sender, ListControlConvertEventArgs e)
        {
            int index = Convert.ToInt32(e.Value) - 1;
            DataRow ownerRow = dataModule.ownerDataTable.Rows[index];
            e.Value = ownerRow["FirstName"] + " " + ownerRow["LastName"];
        }


        //ON-CLICK FUNCTIONS
        //Decreases the currency manager count by 1 which displays different items in the listBox.
        private void previousButton_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count)
            {
                --currencyManager.Position;
            }

        }
        //Increases the currency manager count by 1 which displays different items in the listBox.
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count)
            {
                ++currencyManager.Position;
            }
        }
        //Closes the form.
        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ADD OWNER
        //Validates the users input and saves a new owner row to the database if all input is valid.
        private void saveAddButton_Click(object sender, EventArgs e)
        {
            //Validating fields
            if (this.validateFields(firstNameAddPrompt, firstNameAddTextBox, lastNameAddPrompt, lastNameAddTextBox, streetAddressAddPrompt, streetAddressAddTextBox, phoneNumberAddPrompt, phoneNumberAddTextBox, suburbAddPrompt, suburbAddTextBox))
            {
                DataRow newOwnerRow = dataModule.ownerDataTable.NewRow();
                newOwnerRow["FirstName"] = firstNameAddTextBox.Text;
                newOwnerRow["LastName"] = lastNameAddTextBox.Text;
                newOwnerRow["StreetAddress"] = streetAddressAddTextBox.Text;
                newOwnerRow["Suburb"] = suburbAddTextBox.Text;
                newOwnerRow["PhoneNumber"] = phoneNumberAddTextBox.Text;
                dataModule.ownerDataTable.Rows.Add(newOwnerRow);
                //Committing the changes to the database.
                dataModule.UpdateOwner();
                MessageBox.Show("New Owner Added Successfully!", "Success");
            }
        }
        //Shows the add owner panel when the add owner button is clicked.
        private void addOwnerButton_Click(object sender, EventArgs e)
        {
            //Disable controls on the owner maintenance form so they do not interefere with process while new owner is being added.
            nextButton.Enabled = false;
            previousButton.Enabled = false;
            deleteOwnerButton.Enabled = false;
            updateOwnerButton.Enabled = false;
            addOwnerButton.Enabled = false;
            addOwnerPanel.Show();
        }
        //Hides the add owner panel when the cancel button is clicked.
        private void cancelAddButton_Click(object sender, EventArgs e)
        {
            //Re-enabling controls on owner maintenance form.
            ownerListBox.Enabled = true;
            nextButton.Enabled = true;
            previousButton.Enabled = true;
            deleteOwnerButton.Enabled = true;
            updateOwnerButton.Enabled = true;
            addOwnerButton.Enabled = true;
            this.addOwnerPanel.Hide();
        }
        //UPDATE OWNER
        //validates the users input and updates an owner row in the database if all input is valid.
        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            //Validating input.
            if (this.validateFields(firstNameUpdatePrompt, firstNameUpdateTextBox, lastNameUpdatePrompt, lastNameUpdateTextBox, streetAddressUpdatePrompt, streetAddressUpdateTextBox, phoneNumberUpdatePrompt, phoneNumberUpdateTextBox, suburbUpdatePrompt, suburbUpdateTextBox))
            {
                DataRow updateOwnerRow = dataModule.ownerDataTable.Rows[currencyManager.Position];
                //Filling out textfields in the ownerUpdatePanel with the existing values.
                updateOwnerRow["FirstName"] = firstNameUpdateTextBox.Text;
                updateOwnerRow["LastName"] = lastNameUpdateTextBox.Text;
                updateOwnerRow["FullName"] = firstNameUpdateTextBox.Text + " " + lastNameUpdateTextBox.Text;
                updateOwnerRow["StreetAddress"] = streetAddressUpdateTextBox.Text;
                updateOwnerRow["Suburb"] = suburbUpdateTextBox.Text;
                updateOwnerRow["PhoneNumber"] = phoneNumberUpdateTextBox.Text;
                dataModule.UpdateOwner();
                MessageBox.Show("Owner updated successfully", "Success");
            }
        }
        //Shows the update owner panel when the update owner button is clicked.
        private void updateOwnerButton_Click(object sender, EventArgs e)
        {
            //Showing existing values for the row in the update panel textboxes.
            DataRow updateOwnerRow = dataModule.ownerDataTable.Rows[currencyManager.Position];
            firstNameUpdateTextBox.Text = (string)updateOwnerRow["FirstName"];
            lastNameUpdateTextBox.Text = (string)updateOwnerRow["LastName"];
            streetAddressUpdateTextBox.Text = (string)updateOwnerRow["StreetAddress"];
            suburbUpdateTextBox.Text = (string)updateOwnerRow["Suburb"];
            //Accounting for possibility that phoneNumber is NULL - (There is no NOT NULL constraint for the phone number in the database).
            if (updateOwnerRow["PhoneNumber"] != null)
            {
                phoneNumberUpdateTextBox.Text = (string)updateOwnerRow["PhoneNumber"];
            }
            //Disabled controls on the owner maintenance form so they do not interefere with the process while an owner record is being updated.
            ownerListBox.Enabled = false;
            nextButton.Enabled = false;
            previousButton.Enabled = false;
            deleteOwnerButton.Enabled = false;
            updateOwnerButton.Enabled = false;
            addOwnerButton.Enabled = false;
            updateOwnerPanel.Show();
        }
        //Hides the update owner panel when the cancel button is clicked.
        private void cancelUpdateButton_Click(object sender, EventArgs e)
        {
            //Re-enabling controls on owner maintenance form.
            ownerListBox.Enabled = true;
            nextButton.Enabled = true;
            previousButton.Enabled = true;
            deleteOwnerButton.Enabled = true;
            updateOwnerButton.Enabled = true;
            addOwnerButton.Enabled = true;
            updateOwnerPanel.Hide();
        }
        //DELETE OWNER
        //Function that runs when delete owner button is clicked - confirms deletion then deletes the owner if it is not attached to any vehicles.
        private void deleteOwnerButton_Click(object sender, EventArgs e)
        {
            DataRow deleteOwnerRow = dataModule.ownerDataTable.Rows[currencyManager.Position];
            DataRow[] VehicleOwnerRow = dataModule.vehicleDataTable.Select("OwnerID = " + ownerIDDisplayLabel.Text);
            if (VehicleOwnerRow.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion",
                                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    deleteOwnerRow.Delete();
                    //Commit changes to the database.
                    dataModule.UpdateOwner();
                    MessageBox.Show("Owner deleted successfully.", "Deletion Successful");
                }
            }
            else
            {
                MessageBox.Show("You may only delete owners that do not have any cars.", "Error");
                return;
            }
            //Commit changes to the database.
        }

        //MISC FUNCTIONS
        //Validates all fields when adding a new owner row.
        private bool validateFields(Label firstNamePrompt, TextBox firstNameTextBox, Label lastNamePrompt, TextBox lastNameTextBox, Label streetAddressPrompt, TextBox streetAddressTextBox, Label phoneNumberPrompt, TextBox phoneNumberTextBox, Label suburbPrompt, TextBox suburbTextBox)
        {
            firstNamePrompt.Visible = false;
            lastNamePrompt.Visible = false;
            streetAddressPrompt.Visible = false;
            suburbPrompt.Visible = false;
            phoneNumberPrompt.Visible = false;

            bool valid = true;
            if (firstNameTextBox.Text == "")
            {
                firstNamePrompt.Text = "You must enter a first name for the owner.";
                firstNamePrompt.Visible = true;
                valid = false;
            }
            else if (!(Regex.IsMatch(firstNameTextBox.Text, @"^[a-zA-Z]+$")))
            {
                firstNamePrompt.Text = "The first name can only contain letters.";
                firstNamePrompt.Visible = true;
                valid = false;
            }
            if (lastNameTextBox.Text == "")
            {
                lastNamePrompt.Text = "You must enter a last name for the owner.";
                lastNamePrompt.Visible = true;
                valid = false;
            }
            else if (!(Regex.IsMatch(lastNameTextBox.Text, @"^[a-zA-Z]+$")))
            {
                lastNamePrompt.Text = "The last name can only contain letters.";
                lastNamePrompt.Visible = true;
                valid = false;
            }
            if (streetAddressTextBox.Text == "")
            {
                streetAddressPrompt.Text = "You must enter a street address for the owner.";
                streetAddressPrompt.Visible = true;
                valid = false;
            }
            else if (!(Regex.IsMatch(streetAddressTextBox.Text, @"^[0-9A-Za-z ]+$")))
            {
                streetAddressPrompt.Text = "The street address can only contain letters, numbers and spaces.";
                streetAddressPrompt.Visible = true;
                valid = false;
            }
            if (suburbTextBox.Text == "")
            {
                suburbPrompt.Text = "You must enter a suburb for the owner.";
                suburbPrompt.Visible = true;
                valid = false;
            }
            else if (!(Regex.IsMatch(suburbTextBox.Text, @"^[0-9A-Za-z ]+$")))
            {
                suburbPrompt.Text = "The suburb can only contain letters.";
                suburbPrompt.Visible = true;
                valid = false;
            }
            if (phoneNumberTextBox.Text == "")
            {
                phoneNumberPrompt.Text = "You must enter a phone number for the owner.";
                phoneNumberPrompt.Visible = true;
                valid = false;
            }
            else if (!(Regex.IsMatch(phoneNumberTextBox.Text, @"^[0-9+\(\) ]+$")))
            {
                phoneNumberPrompt.Text = "The phone number can only contain numbers, spaces and brackets.";
                phoneNumberPrompt.Visible = true;
                valid = false;
            }
            //Returning bool saying whether fields are valid or not.
            return valid;
        }
    }
}


