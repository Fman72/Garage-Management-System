using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace Assignment2
{

    //Purpose: Contains the design and methods for the Vehicle Maintenance form that allows users to use to the form to update/delete/create service type records in the database.
    //Author: Fraser Kearns
    //Date Created: 02/08/15
    public partial class VehicleMaintenanceForm : Form
    {
        //VARIABLE DECLARATIONS
        private DataModule dataModule;
        private MainForm mainForm;
        private CurrencyManager vehicleCurrencyManager;
        private CurrencyManager ownerCurrencyManager;

        //CONSTRUCTOR
        /// <summary>
        /// This is the constructor for the VehicleMaintenanceForm. It initialazes the display of the form, initializes the class variables and bind the controls on the form the their corresponding data sources.
        /// </summary>
        /// <param name="dataModule">The DataModule object this application uses for database connection.</param>
        /// <param name="mainForm">The MainForm that was clicked to open this form.</param>
        public VehicleMaintenanceForm(DataModule dataModule, MainForm mainForm)
        {
            this.InitializeComponent();
            this.dataModule = dataModule;
            this.mainForm = mainForm;
            this.BindControls();
        }


        /// <summary>
        /// Function that binds values from the database to controls on the form.
        /// </summary>
        public void BindControls()
        {
            vehicleIDDisplayLabel.DataBindings.Add("Text", dataModule.greenDataSet, "VEHICLE.VehicleID");
            plateNumberDisplayLabel.DataBindings.Add("Text", dataModule.greenDataSet, "VEHICLE.PlateNumber");
            makeDisplayLabel.DataBindings.Add("Text", dataModule.greenDataSet, "VEHICLE.Make");
            modelDisplayLabel.DataBindings.Add("Text", dataModule.greenDataSet, "VEHICLE.Model");
            vehicleListBox.DataSource = dataModule.greenDataSet;
            vehicleListBox.DisplayMember = "VEHICLE.PlateNumber";
            vehicleListBox.ValueMember = "VEHICLE.VehicleID";
            vehicleCurrencyManager = (CurrencyManager)this.BindingContext[dataModule.greenDataSet, "VEHICLE"];
            ownerCurrencyManager = (CurrencyManager)this.BindingContext[dataModule.greenDataSet, "OWNER"];
        }

        /// <summary>
        /// This function runs when the vehicle selected on the form changes. It updates the ownersNameDisplayLabel to contain the owner's name.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the vehicleIDDisplayLabel.</param>
        /// <param name="e">The event arguments for the TextChanged event passed to this function.</param>
        private void vehicleIDDisplayLabel_TextChanged(object sender, EventArgs e)
        {
            DataRow selectedOwner = this.getVehiclesOwner();

            ownersNameDisplayLabel.Text = selectedOwner["FirstName"].ToString();
            ownersNameDisplayLabel.Text += " " + selectedOwner["LastName"].ToString();
        }
        /// <summary>
        /// This function runs before each visible item in the addOwnerComboBox is formatted. It retrieves the owners full name and displays it in the combobox.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the ownerComboBox.</param>
        /// <param name="e">The event arguments for the Format event passed to this function.</param>
        private void addOwnerComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            int index;
            if( int.TryParse(e.Value.ToString(), out index) )
            {
                index = index - 1;
                DataRow ownerRow = dataModule.ownerDataTable.Rows[index];
                e.Value = ownerRow["FirstName"] + " " + ownerRow["LastName"];
            }

        }


        /// <summary>
        /// This function gets a DataRow containing information about a vehicles owner. It uses the text in the vehicleIdDisplayLabel to find the owner.
        /// </summary>
        /// <returns>Returns a DataRow object for the owner who owns the currently selected vehicle.</returns>
        private DataRow getVehiclesOwner()
        {
            int vehicleID = Convert.ToInt32(vehicleIDDisplayLabel.Text);
            vehicleCurrencyManager.Position = dataModule.vehicleView.Find(vehicleID);
            DataRow selectedVehicle = dataModule.vehicleDataTable.Rows[vehicleCurrencyManager.Position];
            int ownerID = (int)selectedVehicle["OwnerID"];
            ownerCurrencyManager.Position = dataModule.ownerView.Find(ownerID);
            DataRow selectedOwner = dataModule.ownerDataTable.Rows[ownerCurrencyManager.Position];

            return selectedOwner;
        }

        //ON-CLICK FUNCTIONS
        /// <summary>
        /// Decreases the vehicleCurrencyManager count by 1 which selects a different item in the vehicleListBox.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the previousButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void previousButton_Click(object sender, EventArgs e)
        {
            if (vehicleCurrencyManager.Position < vehicleCurrencyManager.Count)
            {
                --vehicleCurrencyManager.Position;
            }

        }
        /// <summary>
        /// Increases the vehicleCurrencyManager count by 1 which selects a different item in the vehicleListBox.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the nextButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (vehicleCurrencyManager.Position < vehicleCurrencyManager.Count)
            {
                ++vehicleCurrencyManager.Position;
            }
        }

        /// <summary>
        /// Closes the form.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the returnButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //ADD VEHICLE

        /// <summary>
        /// Validates the users input and saves a new vehicle row to the database if all input is valid.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the saveAddButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void saveAddButton_Click(object sender, EventArgs e)
        {
            //Validating fields
            if (this.validateFields(plateNumberAddPrompt, plateNumberAddTextBox, makeAddPrompt, makeAddTextBox, modelAddPrompt, modelAddTextBox, addOwnerComboBox, ownerAddPrompt))
            {
                DataRow newVehicleRow = dataModule.vehicleDataTable.NewRow();
                newVehicleRow["PlateNumber"] = (plateNumberAddTextBox.Text).ToUpper();
                newVehicleRow["Make"] = makeAddTextBox.Text;
                newVehicleRow["Model"] = modelAddTextBox.Text;
                newVehicleRow["OwnerID"] = addOwnerComboBox.SelectedValue;
                dataModule.vehicleDataTable.Rows.Add(newVehicleRow);
                //Committing the changes to the database.
                dataModule.UpdateVehicle();
                MessageBox.Show("Vehicle added successfully.", "Success");
            }
        }
        /// <summary>
        /// Shows the addVehiclePanel when the addVehicleButton is clicked.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the addVehicleButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void addVehicleButton_Click(object sender, EventArgs e)
        {
            //Disable controls on the Vehicle maintenance form so they do not interefere with process while new Vehicle is being added.
            nextButton.Enabled = false;
            previousButton.Enabled = false;
            deleteVehicleButton.Enabled = false;
            updateVehicleButton.Enabled = false;
            addVehicleButton.Enabled = false;
            if (addOwnerComboBox.DataSource == null)
            {
                addOwnerComboBox.DataSource = dataModule.greenDataSet;
                addOwnerComboBox.DisplayMember = "OWNER.OwnerID";
                addOwnerComboBox.ValueMember = "OWNER.OwnerID";
            }
            addVehiclePanel.Show();
        }
        /// <summary>
        /// Hides the addVehiclePanel when the cancelAddButton is clicked.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the cancelAddButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void cancelAddButton_Click(object sender, EventArgs e)
        {
            //Re-enabling controls on Vehicle maintenance form.
            vehicleListBox.Enabled = true;
            nextButton.Enabled = true;
            previousButton.Enabled = true;
            deleteVehicleButton.Enabled = true;
            updateVehicleButton.Enabled = true;
            addVehicleButton.Enabled = true;
            addVehiclePanel.Hide();
        }
        //UPDATE VEHICLE
        /// <summary>
        /// Validates the users input and updates a vehicle row in the database if all input is valid.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the saveUpdateButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            //Validating fields
            if (this.validateFields(plateNumberAddPrompt, plateNumberAddTextBox, makeAddPrompt, makeAddTextBox, modelAddPrompt, modelAddTextBox))
            {
                DataRow updateVehicleRow = dataModule.vehicleDataTable.Rows[vehicleCurrencyManager.Position];
                updateVehicleRow["PlateNumber"] = (plateNumberUpdateTextBox.Text).ToUpper();
                updateVehicleRow["Make"] = makeUpdateTextBox.Text;
                updateVehicleRow["Model"] = modelUpdateTextBox.Text;
                //Committing the changes to the database.
                dataModule.UpdateVehicle();
                MessageBox.Show("Vehicle updated successfully.", "Success");
            }
        }
        /// <summary>
        /// Shows the updateVehiclePanel when the updateVehicleButton is clicked.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the updateVehicleButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void updateVehicleButton_Click(object sender, EventArgs e)
        {
            //Showing existing values for the row in the update panel textboxes.
            DataRow updateVehicleRow = dataModule.vehicleDataTable.Rows[vehicleCurrencyManager.Position];
            plateNumberUpdateTextBox.Text = (string)updateVehicleRow["PlateNumber"];
            makeUpdateTextBox.Text = (string)updateVehicleRow["Make"];
            modelUpdateTextBox.Text = (string)updateVehicleRow["Model"];
            //Disabled controls on the Vehicle maintenance form so they do not interfere with the process while a Vehicle record is being updated.
            vehicleListBox.Enabled = false;
            nextButton.Enabled = false;
            previousButton.Enabled = false;
            deleteVehicleButton.Enabled = false;
            updateVehicleButton.Enabled = false;
            addVehicleButton.Enabled = false;
            updateVehiclePanel.Show();
        }
        /// <summary>
        /// Hides the updateVehiclePanel when the cancelUpdateButton is clicked.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the cancelUpdateButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void cancelUpdateButton_Click(object sender, EventArgs e)
        {
            //Re-enabling controls on Vehicle maintenance form.
            vehicleListBox.Enabled = true;
            nextButton.Enabled = true;
            previousButton.Enabled = true;
            deleteVehicleButton.Enabled = true;
            updateVehicleButton.Enabled = true;
            addVehicleButton.Enabled = true;
            updateVehiclePanel.Hide();
        }
        //DELETE VEHICLE
        /// <summary>
        /// Function that runs when deleteVehicleButton is clicked - confirms deletion then deletes the vehicle record if there are no services associated with the record.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the deleteVehicleButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void deleteVehicleButton_Click(object sender, EventArgs e)
        {
            DataRow deleteVehicleRow = dataModule.vehicleDataTable.Rows[vehicleCurrencyManager.Position];
            DataRow[] serviceRow = dataModule.serviceDataTable.Select("VehicleID = " + vehicleIDDisplayLabel.Text);
            if (serviceRow.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion",
                                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    deleteVehicleRow.Delete();
                    //Commit changes to the database.
                    dataModule.UpdateVehicle();
                    MessageBox.Show("Vehicle deleted successfully.", "Deletion Successful");
                }
            }
            else
            {
                MessageBox.Show("You may only delete Vehicles that do not have services.", "Error");
                return;
            }
            //Commit changes to the database.
        }

        //MISC FUNCTIONS
        /// <summary>
        /// Validates all fields when adding a new vehicle row - includes owner validation.
        /// </summary>
        /// <param name="plateNumberPrompt">The label used to prompt the user if they have entered an invalid plate number.</param>
        /// <param name="plateNumberTextBox">The textBox the user enters the plate number into.</param>
        /// <param name="makePrompt">The label used to prompt the user if they have entered an invalid make.</param>
        /// <param name="makeTextBox">The textBox the user enters the make into.</param>
        /// <param name="modelPrompt">The label used to prompt the user if they have entered an invalid model.</param>
        /// <param name="modelTextBox">The textBox the user enters the model into.</param>
        /// <param name="ownerComboBox">The comboBox the user uses to select the owner for the vehicle.</param>
        /// <param name="ownerPrompt">The label used to prompt the user if they have entered an invalid owner.</param>
        /// <returns>Returns a boolean indiciating whether or not the data the user has entered is valid.</returns>
        private bool validateFields(Label plateNumberPrompt, TextBox plateNumberTextBox, Label makePrompt, TextBox makeTextBox, Label modelPrompt, TextBox modelTextBox, ComboBox ownerComboBox, Label ownerPrompt)
        {
            plateNumberPrompt.Visible = false;
            makePrompt.Visible = false;
            modelPrompt.Visible = false;
            ownerPrompt.Visible = false;

            bool valid = true;
            if (plateNumberTextBox.Text == "")
            {
                plateNumberPrompt.Text = "You must enter a plate number for the vehicle.";
                plateNumberPrompt.Visible = true;
                valid = false;
            }
            else if (!(Regex.IsMatch(plateNumberTextBox.Text, @"^[a-zA-Z0-9]+$")) || (plateNumberTextBox.Text.Count() > 6))
            {
                plateNumberPrompt.Text = "The plate number can only contain letters and numbers \nand can be no more than 6 characters.";
                plateNumberPrompt.Visible = true;
                valid = false;
            }
            if (makeTextBox.Text == "")
            {
                makePrompt.Text = "You must enter a make for the vehicle.";
                makePrompt.Visible = true;
                valid = false;
            }
            else if (!(Regex.IsMatch(makeTextBox.Text, @"^[a-zA-Z0-9 ]+$")))
            {
                makePrompt.Text = "The make can only contain letters, numbers and spaces.";
                makePrompt.Visible = true;
                valid = false;
            }
            if (modelTextBox.Text == "")
            {
                modelPrompt.Text = "You must enter a model for the vehicle.";
                modelPrompt.Visible = true;
                valid = false;
            }
            else if (!(Regex.IsMatch(modelTextBox.Text, @"^[a-zA-Z0-9 ]+$")))
            {
                modelPrompt.Text = "The model can only contain letters, numbers and spaces.";
                modelPrompt.Visible = true;
                valid = false;
            }
            if (ownerComboBox.SelectedItem == null)
            {
                ownerPrompt.Text = "You must give the vehicle an owner.";
                ownerPrompt.Visible = true;
                valid = false;
            }
            //Returning bool saying whether fields are valid or not.
            return valid;
        }

        /// <summary>
        /// Validates all fields when updating new vehicle row.
        /// </summary>
        /// <param name="plateNumberPrompt">The label used to prompt the user if they have entered an invalid plate number.</param>
        /// <param name="plateNumberTextBox">The textBox the user enters the plate number into.</param>
        /// <param name="makePrompt">The label used to prompt the user if they have entered an invalid make.</param>
        /// <param name="makeTextBox">The textBox the user enters the make into.</param>
        /// <param name="modelPrompt">The label used to prompt the user if they have entered an invalid model.</param>
        /// <param name="modelTextBox">The textBox the user enters the model into.</param>
        /// <returns>Returns a boolean indiciating whether or not the data the user has entered is valid.</returns>
        private bool validateFields(Label plateNumberPrompt, TextBox plateNumberTextBox, Label makePrompt, TextBox makeTextBox, Label modelPrompt, TextBox modelTextBox)
        {
            plateNumberPrompt.Visible = false;
            makePrompt.Visible = false;
            modelPrompt.Visible = false;

            bool valid = true;
            if (plateNumberTextBox.Text == "")
            {
                plateNumberPrompt.Text = "You must enter a plate number for the vehicle.";
                plateNumberPrompt.Visible = true;
                valid = false;
            }
            else if (!(Regex.IsMatch(plateNumberTextBox.Text, @"^[a-zA-Z0-9]+$")) || (plateNumberTextBox.Text.Count() > 6))
            {
                plateNumberPrompt.Text = "The plate number can only contain letters and numbers and can be no more than 6 characters.";
                plateNumberPrompt.Visible = true;
                valid = false;
            }
            if (makeTextBox.Text == "")
            {
                makePrompt.Text = "You must enter a make for the vehicle.";
                makePrompt.Visible = true;
                valid = false;
            }
            else if (!(Regex.IsMatch(makeTextBox.Text, @"^[a-zA-Z0-9 ]+$")))
            {
                makePrompt.Text = "The make can only contain letters, numbers and spaces.";
                makePrompt.Visible = true;
                valid = false;
            }
            if (modelTextBox.Text == "")
            {
                modelPrompt.Text = "You must enter a model for the vehicle.";
                modelPrompt.Visible = true;
                valid = false;
            }
            else if (!(Regex.IsMatch(modelTextBox.Text, @"^[a-zA-Z0-9 ]+$")))
            {
                modelPrompt.Text = "The model can only contain letters, numbers and spaces.";
                modelPrompt.Visible = true;
                valid = false;
            }
            //Returning bool saying whether fields are valid or not.
            return valid;
        }
    }
}
