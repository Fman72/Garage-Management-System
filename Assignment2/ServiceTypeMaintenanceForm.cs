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
    //Purpose: Contains the design and methods for the Service Type maintenance form that allows users to use to the form to delete/update/create service type records in the database.
    //Author: Fraser Kearns
    //Date Created: 02/08/15
    public partial class ServiceTypeMaintenanceForm : Form
    {
        //VARIABLE DECLARATIONS
        private DataModule dataModule;
        private MainForm mainForm;
        private CurrencyManager currencyManager;

        //CONSTRUCTOR
        public ServiceTypeMaintenanceForm(DataModule dataModule, MainForm mainForm)
        {
            this.InitializeComponent();
            this.dataModule = dataModule;
            this.mainForm = mainForm;
            this.BindControls();
        }

        //Function that binds values from the database to controls on the form.
        public void BindControls()
        {
            serviceTypeIDDisplayLabel.DataBindings.Add("Text", dataModule.greenDataSet, "SERVICETYPE.ServiceTypeID");
            descriptionDisplayLabel.DataBindings.Add("Text", dataModule.greenDataSet, "SERVICETYPE.Description");
            //Formatting hourly rate databinding so that it displays in a currency format.
            Binding hourlyRateBinding = new Binding("Text", dataModule.greenDataSet, "SERVICETYPE.HourlyRate");
            hourlyRateBinding.Format += convertDecimalToCurrency;
            hourlyRateDisplayLabel.DataBindings.Add(hourlyRateBinding);
            serviceTypeListBox.DataSource = dataModule.greenDataSet;
            serviceTypeListBox.DisplayMember = "SERVICETYPE.Description";
            serviceTypeListBox.ValueMember = "SERVICETYPE.ServiceTypeID";
            currencyManager = (CurrencyManager)this.BindingContext[dataModule.greenDataSet, "SERVICETYPE"];
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
        //ADD SERVICETYPE
        //Validates the users input and saves a new service type row to the database if all input is valid.
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.validateFields(descriptionAddPrompt, descriptionAddTextBox, hourlyRateAddPrompt, hourlyRateAddTextBox))
            {
                DataRow newServiceTypeRow = dataModule.serviceTypeDataTable.NewRow();
                newServiceTypeRow["Description"] = descriptionAddTextBox.Text;
                newServiceTypeRow["HourlyRate"] = hourlyRateAddTextBox.Text;
                dataModule.serviceTypeDataTable.Rows.Add(newServiceTypeRow);
                //Committing the changes to the database.
                dataModule.UpdateServiceType();
                MessageBox.Show("New Service Type Added Successfully!", "Success");
            }
        }
        //Shows the add service type panel.
        private void addServiceTypeButton_Click(object sender, EventArgs e)
        {
            //Disabled controls on the service type maintenance form so they do not interefere with process while new service type is being added.
            nextButton.Enabled = false;
            previousButton.Enabled = false;
            deleteServiceTypeButton.Enabled = false;
            updateServiceTypeButton.Enabled = false;
            addServiceTypeButton.Enabled = false;
            addServiceTypePanel.Show();
        }
        //Hides the add service type panel.
        private void cancelAddButton_Click(object sender, EventArgs e)
        {
            //Re-enabling controls on service type maintenance form.
            serviceTypeListBox.Enabled = true;
            nextButton.Enabled = true;
            previousButton.Enabled = true;
            deleteServiceTypeButton.Enabled = true;
            updateServiceTypeButton.Enabled = true;
            addServiceTypeButton.Enabled = true;
            addServiceTypePanel.Hide();
        }
        
        //UPDATE SERVICETYPE
        //Validates the users input and updates an ServiceType row in the database if all input is valid.
        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            if (this.validateFields(descriptionUpdatePrompt, descriptionUpdateTextBox, hourlyRateUpdatePrompt, hourlyRateUpdateTextBox))
            {
                DataRow updateServiceTypeRow = dataModule.serviceTypeDataTable.Rows[currencyManager.Position];
                updateServiceTypeRow["Description"] = descriptionUpdateTextBox.Text;
                updateServiceTypeRow["HourlyRate"] = hourlyRateUpdateTextBox.Text;
                dataModule.UpdateServiceType();
                MessageBox.Show("Service Type updated successfully", "Success");
            }
        }
        //Shows the update ServiceType panel when the update service type button is clicked.
        private void updateServiceTypeButton_Click(object sender, EventArgs e)
        {
            //Showing existing values in update panel textboxes.
            DataRow updateServiceTypeRow = dataModule.serviceTypeDataTable.Rows[currencyManager.Position];
            descriptionUpdateTextBox.Text = (string)updateServiceTypeRow["Description"];
            hourlyRateUpdateTextBox.Text = Convert.ToString(updateServiceTypeRow["HourlyRate"]);
            //Disabled controls on the service type maintenance form so they do not interefere with process while new service type is being added.
            serviceTypeListBox.Enabled = false;
            nextButton.Enabled = false;
            previousButton.Enabled = false;
            deleteServiceTypeButton.Enabled = false;
            updateServiceTypeButton.Enabled = false;
            addServiceTypeButton.Enabled = false;
            updateServiceTypePanel.Show();
        }
        //Closes the update panel.
        private void cancelUpdateButton_Click(object sender, EventArgs e)
        {
            serviceTypeListBox.Enabled = true;
            nextButton.Enabled = true;
            previousButton.Enabled = true;
            deleteServiceTypeButton.Enabled = true;
            updateServiceTypeButton.Enabled = true;
            addServiceTypeButton.Enabled = true;
            updateServiceTypePanel.Hide();
        }
        //DELETE SERVICETYPE
        //Function that runs when delete service type button is clicked - confirms deletion then deletes the service type if it is not attached to any service or equipment records.
        private void deleteServiceTypeButton_Click(object sender, EventArgs e)
        {
            DataRow deleteServiceTypeRow = dataModule.serviceTypeDataTable.Rows[currencyManager.Position];
            DataRow[] serviceTypeEquipmentRow = dataModule.serviceTypeEquipmentDataTable.Select("ServiceTypeID = " + serviceTypeIDDisplayLabel.Text);
            DataRow[] serviceRow = dataModule.serviceDataTable.Select("ServiceTypeID = " + serviceTypeIDDisplayLabel.Text);
            if ((serviceTypeEquipmentRow.Length == 0) && (serviceRow.Length == 0))
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion",
                                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    deleteServiceTypeRow.Delete();
                    //Commit changes to the database.
                    dataModule.UpdateServiceType();
                    MessageBox.Show("Service Type deleted successfully.", "Deletion Successful");
                }
            }
            else if (serviceTypeEquipmentRow.Length > 0)
            {
                MessageBox.Show("You may only delete Service Types that are not assigned to services.", "Error");
                return;
            }
            else if (serviceRow.Length > 0)
            {
                MessageBox.Show("You may only delete Service Types that are not allocated equipment.", "Error");
                return;
            }
        }
        //MISC FUNCTIONS
        //Funtions used to display hourly rate in the currrency format.
        private void convertDecimalToCurrency(object sender, ConvertEventArgs e)
        {
            e.Value = String.Format("{0:C}", e.Value);
        }
        //Validates all fields when adding a new service type row.
        private bool validateFields(Label descriptionPrompt, TextBox descriptionTextBox, Label hourlyRatePrompt, TextBox hourlyRateTextBox)
        {
            descriptionPrompt.Visible = false;
            hourlyRatePrompt.Visible = false;
            bool valid = true;
            if (descriptionTextBox.Text == "")
            {
                descriptionPrompt.Text = "You must enter a description for the ServiceType.";
                descriptionPrompt.Visible = true;
                valid = false;
            }
            else if (!(Regex.IsMatch(descriptionTextBox.Text, @"^[a-zA-Z ]+$")))
            {
                descriptionPrompt.Text = "The description can only contain letters.";
                descriptionPrompt.Visible = true;
                valid = false;
            }
            if (hourlyRateTextBox.Text == "")
            {
                hourlyRatePrompt.Text = "You must enter an hourly rate for the Service Type.";
                hourlyRatePrompt.Visible = true;
                valid = false;
            }
            else if (!(Regex.IsMatch(hourlyRateTextBox.Text, @"^[0-9]+(\.[0-9]{1,2})?$")))
            {
                hourlyRatePrompt.Text = "The hourly rate must be a number with no more than 2 decimal figures.";
                hourlyRatePrompt.Visible = true;
                valid = false;
            }
            //Returning bool saying whether fields are valid or not.
            return valid;
        }
    }
}
