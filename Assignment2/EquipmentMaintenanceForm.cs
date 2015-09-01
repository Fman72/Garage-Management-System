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
    //Purpose: Contains the design and methods for the Equipment maintenance form that allows users to use to the form to update/delete/create equipment records in the database.
    //Author: Fraser Kearns
    //Date Created: 02/08/15
    public partial class EquipmentMaintenanceForm : Form
    {
        //VARIABLE DECLARATIONS
        private DataModule dataModule;
        private MainForm mainForm;
        private CurrencyManager currencyManager;

        //CONSTRUCTOR
        /// <summary>
        /// This is the constructor for the EquipmentMaintenanceForm. It initialazes the display of the form, initializes the class variables and bind the controls on the form the their corresponding data sources.
        /// </summary>
        /// <param name="dataModule">The DataModule object this application uses for database connection.</param>
        /// <param name="mainForm">The MainForm that was clicked to open this form.</param>
        public EquipmentMaintenanceForm(DataModule dataModule, MainForm mainForm)
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
            equipmentIDDisplayLabel.DataBindings.Add("Text", dataModule.greenDataSet, "EQUIPMENT.EquipmentID");
            descriptionDisplayLabel.DataBindings.Add("Text", dataModule.greenDataSet, "EQUIPMENT.Description");
            equipmentListBox.DataSource = dataModule.greenDataSet;
            equipmentListBox.DisplayMember = "EQUIPMENT.Description";
            equipmentListBox.ValueMember = "EQUIPMENT.EquipmentID";
            currencyManager = (CurrencyManager)this.BindingContext[dataModule.greenDataSet, "Equipment"];
        }


        //ON-CLICK FUNCTIONS
        /// <summary>
        /// Decreases the currencyManager count by 1 which selects a different item in the equipmentListBox.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the previousButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void previousButton_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count)
            {
                --currencyManager.Position;
            }

        }

        /// <summary>
        /// Increases the currencyManager count by 1 which selects a different item in the equipmentListBox.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the nextButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count)
            {
                ++currencyManager.Position;
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
        //ADD EQUIPMENT
        /// <summary>
        /// Validates the users input and saves a new equipment row to the database if all input is valid.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the saveAddButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void saveAddButton_Click(object sender, EventArgs e)
        {
            if (this.validateFields(descriptionAddPrompt, descriptionAddTextBox))
            {
                DataRow newEquipmentRow = dataModule.equipmentDataTable.NewRow();
                newEquipmentRow["Description"] = descriptionAddTextBox.Text;
                dataModule.equipmentDataTable.Rows.Add(newEquipmentRow);
                //Committing changes to database.
                dataModule.UpdateEquipment();
                MessageBox.Show("Item of Equipment added successfully", "Success");
            }
        }

        /// <summary>
        /// Shows the addEquipmentPanel when the addEquipmentButton is clicked.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the addEquipmentButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void addEquipmentButton_Click(object sender, EventArgs e)
        {
            //Disabled controls on the equipment maintenance form so they do not interefere with process while new equipment is being added.
            nextButton.Enabled = false;
            previousButton.Enabled = false;
            deleteEquipmentButton.Enabled = false;
            updateEquipmentButton.Enabled = false;
            addEquipmentButton.Enabled = false;
            addEquipmentPanel.Show();
        }

        /// <summary>
        /// Hides the addEquipmentPanel when the cancelAddButton is clicked.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the cancelAddButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void cancelAddButton_Click(object sender, EventArgs e)
        {
            //Re-enabling controls on equipment maintenance form.
            equipmentListBox.Enabled = true;
            nextButton.Enabled = true;
            previousButton.Enabled = true;
            deleteEquipmentButton.Enabled = true;
            updateEquipmentButton.Enabled = true;
            addEquipmentButton.Enabled = true;
            addEquipmentPanel.Hide();
        }
     
        //UPDATE EQUIPMENT
        /// <summary>
        /// Validates the users input and updates an equipment row in the database if all input is valid.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the saveUpdateButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            if (this.validateFields(descriptionUpdatePrompt, descriptionUpdateTextBox))
            {
                DataRow updateEquipmentRow = dataModule.equipmentDataTable.Rows[currencyManager.Position];
                updateEquipmentRow["Description"] = descriptionUpdateTextBox.Text;
                dataModule.UpdateEquipment();
                MessageBox.Show("Item of Equipment updated successfully", "Success");
            }
        }
        /// <summary>
        /// Shows the updateEquipmentPanel when the updateEquipmentButton is clicked.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the updateEquipmentButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void updateEquipmentButton_Click(object sender, EventArgs e)
        {
            //Showing existing values in update panel textboxes.
            DataRow updateEquipmentRow = dataModule.equipmentDataTable.Rows[currencyManager.Position];
            descriptionUpdateTextBox.Text = (string)updateEquipmentRow["Description"];
            //Disabled controls on the equipment maintenance form so they do not interefere with process while new equipment is being added.
            equipmentListBox.Enabled = false;
            nextButton.Enabled = false;
            previousButton.Enabled = false;
            deleteEquipmentButton.Enabled = false;
            updateEquipmentButton.Enabled = false;
            addEquipmentButton.Enabled = false;
            updateEquipmentPanel.Show();
        }
        /// <summary>
        /// Hides the updateEquipmentPanel when the cancelUpdateButton is clicked.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the cancelUpdateButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void cancelUpdateButton_Click(object sender, EventArgs e)
        {
            equipmentListBox.Enabled = true;
            nextButton.Enabled = true;
            previousButton.Enabled = true;
            deleteEquipmentButton.Enabled = true;
            updateEquipmentButton.Enabled = true;
            addEquipmentButton.Enabled = true;
            updateEquipmentPanel.Hide();
        }
        //DELETE EQUIPMENT
        
        /// <summary>
        /// Function that runs when delete equipment button is clicked - confirms deletion then deletes the equipment if it is not attached to any servicetypes.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the deleteEquipmentButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void deleteEquipmentButton_Click(object sender, EventArgs e)
        {
            DataRow deleteEquipmentRow = dataModule.equipmentDataTable.Rows[currencyManager.Position];
            DataRow[] serviceTypeEquipmentRow = dataModule.serviceTypeEquipmentDataTable.Select("EquipmentID = " + equipmentIDDisplayLabel.Text);
            if (serviceTypeEquipmentRow.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion",
                                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    deleteEquipmentRow.Delete();
                    //Commit changes to the database.
                    dataModule.UpdateEquipment();
                    MessageBox.Show("Item of equipment deleted successfully.", "Deletion Successful");
                }
            }
            else
            {
                MessageBox.Show("You may only delete equipment that is not allocated to a service type.", "Error");
                return;
            }
            //Commit changes to the database.
            
        }
        //MISC FUNCTIONS
        /// <summary>
        /// Validates all fields when adding/updating an equipment row.
        /// </summary>
        /// <param name="descriptionPrompt">The label used to prompt the user if they have entered an invalid description.</param>
        /// <param name="descriptionTextBox">The textBox the user enters the description into.</param>
        /// <returns></returns>
        private bool validateFields(Label descriptionPrompt, TextBox descriptionTextBox)
        {
            descriptionPrompt.Visible = false;
            bool valid = true;
            if (descriptionTextBox.Text == "")
            {
                descriptionPrompt.Text = "You must enter a description for the equipment.";
                descriptionPrompt.Visible = true;
                valid = false;
            }
            else if (!(Regex.IsMatch(descriptionTextBox.Text, @"^[a-zA-Z ]+$")))
            {
                descriptionPrompt.Text = "The description can only contain letters.";
                descriptionPrompt.Visible = true;
                valid = false;
            }
            //Returning bool saying whether fields are valid or not.
            return valid;
        }
    }
}

