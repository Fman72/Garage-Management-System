using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;

namespace Assignment2
{
    //Purpose: Contains the design and methods for the Service Type maintenance form that allows users to use to the form to delete/update/create service type records in the database.
    //Author: Fraser Kearns
    //Date Created: 02/08/15
    public partial class ServiceMaintenanceForm : Form
    {
        //VARIABLE DECLARATIONS
        private DataModule dataModule;
        private MainForm mainForm;
        private CurrencyManager serviceCurrencyManager;
        private CurrencyManager serviceTypeCurrencyManager;
        private CurrencyManager vehicleCurrencyManager;
        private CurrencyManager ownerCurrencyManager;
        //CONSTRUCTOR
        public ServiceMaintenanceForm(DataModule dataModule, MainForm mainForm)
        {
            this.InitializeComponent();
            this.dataModule = dataModule;
            this.mainForm = mainForm;
            serviceCurrencyManager = (CurrencyManager)this.BindingContext[dataModule.greenDataSet, "SERVICE"];
            vehicleCurrencyManager = (CurrencyManager)this.BindingContext[dataModule.greenDataSet, "VEHICLE"];
            ownerCurrencyManager = (CurrencyManager)this.BindingContext[dataModule.greenDataSet, "OWNER"];
            serviceTypeCurrencyManager = (CurrencyManager)this.BindingContext[dataModule.greenDataSet, "SERVICETYPE"];
            this.BindControls();
            //changing data grid view column widths.
            this.setColumnWidths(serviceDataGridView, 80);
        }

        //Function that binds values from the database to controls on the form.
        public void BindControls()
        {
            serviceDataGridView.DataSource = dataModule.greenDataSet;
            serviceDataGridView.DataMember = "SERVICE";
            plateNumberDisplayLabel.DataBindings.Add("Text", dataModule.greenDataSet, "SERVICE.SERVICE_VEHICLE.PlateNumber");
            descriptionDisplayLabel.DataBindings.Add("Text", dataModule.greenDataSet, "SERVICE.SERVICE_SERVICETYPE.Description");
            hourlyRateDisplayLabel.DataBindings.Add("Text", dataModule.greenDataSet, "SERVICE.SERVICE_SERVICETYPE.HourlyRate");
        }

        //Function that runs when the plateNumber display label text changes - changes the corresond ing owner's name on the ownerDisplayLabel.
        private void plateNumberDisplayLabel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Getting vehicleId to get ownerID.
                int vehicleID = Convert.ToInt32(serviceDataGridView.Rows[serviceCurrencyManager.Position].Cells["VehicleID"].Value);
                vehicleCurrencyManager.Position = dataModule.vehicleView.Find(vehicleID);
                DataRow vehicleDataRow = dataModule.vehicleDataTable.Rows[vehicleCurrencyManager.Position];
                //Putting owner's name in the corresponding label.
                ownerCurrencyManager.Position = dataModule.ownerView.Find(vehicleDataRow["OwnerID"]);
                DataRow ownerDataRow = dataModule.ownerDataTable.Rows[ownerCurrencyManager.Position];
                fullNameDisplayLabel.Text = ownerDataRow["FirstName"] + " " + ownerDataRow["LastName"];
            }
            catch (InvalidCastException exception)
            {
                //If user selects final row in the data grid view do nothing.
            }
        }

        //ON-CLICK FUNCTIONS
        //decreases the currency manager count by 1 which displays different items in the listbox.
        private void previousButton_Click(object sender, EventArgs e)
        {
            if (serviceCurrencyManager.Position < serviceCurrencyManager.Count)
            {
                --serviceCurrencyManager.Position;
            }

        }

        //increases the currency manager count by 1 which displays different items in the listbox.
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (serviceCurrencyManager.Position < serviceCurrencyManager.Count)
            {
                ++serviceCurrencyManager.Position;
            }
        }

        //Closes the form.
        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ADD SERVICE
        //Validates the users input and saves a new service row to the database if all input is valid.
        private void saveAddButton_Click(object sender, EventArgs e)
        {
            if (this.validateFields(vehicleIDAddPrompt, vehicleIDAddComboBox, serviceTypeAddPrompt, serviceTypeAddComboBox, dateAddPrompt, dateAddPicker, hoursAddPrompt, hoursAddTextBox))
            {
                try
                {
                    DataRow newServiceRow = dataModule.serviceDataTable.NewRow();
                    newServiceRow["VehicleID"] = vehicleIDAddComboBox.SelectedValue.ToString();
                    newServiceRow["ServiceTypeID"] = serviceTypeAddComboBox.SelectedValue;
                    newServiceRow["Hours"] = hoursAddTextBox.Text;
                    newServiceRow["ServiceDate"] = dateAddPicker.Value.ToShortDateString();
                    newServiceRow["Status"] = "Pending";
                    dataModule.serviceDataTable.Rows.Add(newServiceRow);
                    //Committing the changes to the database.
                    dataModule.UpdateService();
                    MessageBox.Show("New service added successfully.", "Add Successful");
                }
                catch (ConstraintException exception)
                {
                    MessageBox.Show("That vehicle is already recieving that type of service.", "Add Error");
                }
            }
        }
        //Shows the add service panel.
        private void addServiceButton_Click(object sender, EventArgs e)
        {
            //setting datasources for combo boxes on panel.
            if (vehicleIDAddComboBox.DataSource == null)
            {
                vehicleIDAddComboBox.DataSource = dataModule.greenDataSet;
                vehicleIDAddComboBox.ValueMember = "VEHICLE.VehicleID";
                vehicleIDAddComboBox.DisplayMember = "VEHICLE.VehicleID";

            }
            if (serviceTypeAddComboBox.DataSource == null)
            {
                serviceTypeAddComboBox.DataSource = dataModule.greenDataSet;
                serviceTypeAddComboBox.ValueMember = "SERVICETYPE.ServiceTypeID";
                serviceTypeAddComboBox.DisplayMember = "SERVICETYPE.ServiceTypeID";
            }
            //Disabled controls on the service maintenance form so they do not interefere with process while new service is being added.
            markPaidServiceButton.Enabled = false;
            serviceDataGridView.Enabled = false;
            nextButton.Enabled = false;
            previousButton.Enabled = false;
            deleteServiceButton.Enabled = false;
            updateServiceButton.Enabled = false;
            addServiceButton.Enabled = false;
            addServicePanel.Show();
        }

        //Hides the add service type panel.
        private void cancelAddButton_Click(object sender, EventArgs e)
        {
            //Re-enabling controls on service maintenance form.
            markPaidServiceButton.Enabled = true;
            serviceDataGridView.Enabled = true;
            nextButton.Enabled = true;
            previousButton.Enabled = true;
            deleteServiceButton.Enabled = true;
            updateServiceButton.Enabled = true;
            addServiceButton.Enabled = true;
            addServicePanel.Hide();
        }
        
        //UPDATE SERVICE
        //Validates the users input and updates a Service row in the database if all input is valid.
        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            if (this.validateFields(dateUpdatePrompt, dateUpdatePicker, hoursUpdatePrompt, hoursUpdateTextBox))
            {
                DataRow updateServiceRow = dataModule.serviceDataTable.Rows[serviceCurrencyManager.Position];
                updateServiceRow["Hours"] = hoursUpdateTextBox.Text;
                updateServiceRow["ServiceDate"] = dateUpdatePicker.Value.ToShortDateString();
                //Committing the changes to the database.
                dataModule.UpdateService();
                MessageBox.Show("New service updated successfully.", "Update Successful");
            }
        }


        //Shows the update Service panel when the update service button is clicked.
        private void updateServiceButton_Click(object sender, EventArgs e)
        {
            
            //checking if status of service is pending
            if (serviceDataGridView.CurrentRow.Cells["Status"].Value.ToString() == "Pending")
            {
                //Showing existing values in update panel textboxes.
                DataRow updateServiceRow = dataModule.serviceDataTable.Rows[serviceCurrencyManager.Position];
                vehicleIDUpdateDisplayLabel.Text = updateServiceRow["VehicleID"].ToString();
                serviceTypeUpdateDisplayLabel.Text = Convert.ToString(updateServiceRow["ServiceTypeID"]);
                hoursUpdateTextBox.Text = (string)updateServiceRow["Hours"].ToString();
                //Disabled controls on the service  maintenance form so they do not interefere with process while new service is being added.
                serviceDataGridView.Enabled = false;
                nextButton.Enabled = false;
                markPaidServiceButton.Enabled = false;
                previousButton.Enabled = false;
                deleteServiceButton.Enabled = false;
                updateServiceButton.Enabled = false;
                addServiceButton.Enabled = false;
                updateServicePanel.Show();
            }
            else
            {
                MessageBox.Show("You may only modify services that have the status 'Pending'.", "Update Error");
            }
        }

        //Closes the update service panel.
        private void cancelUpdateButton_Click(object sender, EventArgs e)
        {
            //Re-enabling controls on service maintenance form.
            markPaidServiceButton.Enabled = true;
            serviceDataGridView.Enabled = true;
            nextButton.Enabled = true;
            previousButton.Enabled = true;
            deleteServiceButton.Enabled = true;
            updateServiceButton.Enabled = true;
            addServiceButton.Enabled = true;
            updateServicePanel.Hide();
        }
        //DELETE SERVICE
        //Function that runs when delete service button is clicked - confirms deletion then deletes the service.
        private void deleteServiceButton_Click(object sender, EventArgs e)
        {
            DataRow deleteServiceRow = dataModule.serviceDataTable.Rows[serviceCurrencyManager.Position];
            if (deleteServiceRow["Status"].ToString() == "Paid")
            {
                if (MessageBox.Show("Are you sure you want to delete this service?",
        "Confirm Deletion",
        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    deleteServiceRow.Delete();
                    dataModule.UpdateService();
                    MessageBox.Show("Service deleted successfully.", "Deletion Successful");
                }
            }
            else
            {
                MessageBox.Show("You may not delete services with the status 'Pending'.", "Delete Error");
            }
        }

        //Function that runs when mark as paid button is clicked. Marks an unpaid service as paid.
        private void markPaidServiceButton_Click(object sender, EventArgs e)
        {
            if (this.checkServicePending(serviceDataGridView.CurrentRow) == true)
            {
                dataModule.serviceDataTable.Rows[serviceCurrencyManager.Position]["Status"] = "Paid";
                MessageBox.Show("Service marked as paid.", "Marked as Paid");
                serviceCurrencyManager.EndCurrentEdit();
                dataModule.UpdateService();

            }
            else
            {
                MessageBox.Show("That service is already paid.", "Already Paid");
            }
        }

        //MISC FUNCTIONS
        //Function that sets the widths of columns in a Data Grid View
        public void setColumnWidths(DataGridView view, int width)
        {
            for (int i = 0; i < view.ColumnCount; i++)
            {
                view.Columns[i].Width = width; 
            }
        }

        //Validates all fields when adding a new service row - includes vehicleID and serviceTypeID validation.
        private bool validateFields(Label vehicleIDPrompt, ComboBox vehicleIDComboBox, Label serviceTypePrompt, ComboBox serviceTypeComboBox, Label datePrompt, DateTimePicker datePicker, Label hoursPrompt, TextBox hoursTextBox)
        {
            vehicleIDPrompt.Visible = false;
            serviceTypePrompt.Visible = false;
            datePrompt.Visible = false;
            hoursPrompt.Visible = false;

            bool valid = true;
            if (vehicleIDComboBox.SelectedItem == null)
            {
                vehicleIDPrompt.Text = "You must enter a vehicle ID for the service.";
                vehicleIDPrompt.Visible = true;
                valid = false;
            }
            if (serviceTypeComboBox.SelectedItem == null)
            {
                serviceTypePrompt.Text = "You must enter a service type for the service.";
                serviceTypePrompt.Visible = true;
                valid = false;
            }
            if (datePicker.Value == null)
            {
                datePrompt.Text = "You must enter a date for your service.";
                datePrompt.Visible = true;
                valid = false;
            }
            if (hoursTextBox.Text == "")
            {
                hoursPrompt.Text = "You must enter a duration for your service.";
                hoursPrompt.Visible = true;
                valid = false;
            }
            else if (!(Regex.IsMatch(hoursTextBox.Text, "^[1-9][0-9]+$")))
            {
                hoursPrompt.Text = "The duration must be a number.";
                hoursPrompt.Visible = true;
                valid = false;
            }

            //Returning bool saying whether fields are valid or not.
            return valid;
        }

        //Validates all fields when updating a service row.
        private bool validateFields(Label datePrompt, DateTimePicker datePicker, Label hoursPrompt, TextBox hoursTextBox)
        {
            datePrompt.Visible = false;
            hoursPrompt.Visible = false;

            bool valid = true;
            if (datePicker.Value == null)
            {
                datePrompt.Text = "You must enter a date for your service.";
                datePrompt.Visible = true;
                valid = false;
            }
            if (hoursTextBox.Text == "")
            {
                hoursPrompt.Text = "You must enter a duration for your service.";
                hoursPrompt.Visible = true;
                valid = false;
            }
            else if (!(Regex.IsMatch(hoursTextBox.Text, "^[1-9][0-9]+$")))
            {
                hoursPrompt.Text = "The duration must be a number greater than 0.";
                hoursPrompt.Visible = true;
                valid = false;
            }

            //Returning bool saying whether fields are valid or not.
            return valid;
        }

        //Function that checks whether the given row's service has a status of pending.
        private bool checkServicePending(DataGridViewRow currentRow)
        {
            if (currentRow.Cells["Status"].Value.ToString() == "Pending")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
