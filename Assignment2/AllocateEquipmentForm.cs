using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment2
{
    /// <summary>
    /// Purpose: Contains the design and methods for the form that allows the user to allocate equipment records to service type records in the database.
    /// Author: Fraser Kearns
    /// Date Created: 14/08/15
    /// </summary>
    public partial class AllocateEquipmentForm : Form
    {
        //VARIABLE DECLARATIONS
        int oldRow;
        private DataModule dataModule;
        private MainForm mainForm;
        private CurrencyManager serviceTypeCurrencyManager;
        private CurrencyManager equipmentCurrencyManager;
        private CurrencyManager serviceTypeEquipmentCurrencyManager;

        //CONSTRUCTOR
        /// <summary>
        /// The constructor for the AllocateEquipmentForm. Initializes the objects variables and lays out the data grid views.
        /// </summary>
        /// <param name="dataModule">The DataModule object this application uses for database connection.</param>
        /// <param name="mainForm">The mainform object that contains the allocate equipment button that was clicked to show this form.</param>
        public AllocateEquipmentForm(DataModule dataModule, MainForm mainForm)
        {
            this.InitializeComponent();
            this.dataModule = dataModule;
            this.mainForm = mainForm;
            //creating currency managers for the various data grid views.
            equipmentCurrencyManager = (CurrencyManager)this.BindingContext[dataModule.greenDataSet, "EQUIPMENT"];
            serviceTypeCurrencyManager = (CurrencyManager)this.BindingContext[dataModule.greenDataSet, "SERVICETYPE"];
            serviceTypeEquipmentCurrencyManager = (CurrencyManager)this.BindingContext[dataModule.greenDataSet, "SERVICETYPEEQUIPMENT"];
            this.BindControls();
            //changing data grid view column widths.
            this.setColumnWidths(serviceTypeDataGridView, 80);
            this.serviceTypeDataGridView.Columns[1].Width = 106;
            this.setColumnWidths(equipmentDataGridView, 90);
            this.equipmentDataGridView.Columns[1].Width = 160;
            this.setColumnWidths(serviceTypeEquipmentDataGridView, 80);
        }
        /// <summary>
        /// The function that binds values from the database to controls on the form. This function is called by the object's constructor when the object is first created.
        /// </summary>
        public void BindControls()
        {
            //Binding tables to data grid views.
            serviceTypeDataGridView.DataSource = dataModule.greenDataSet;
            serviceTypeDataGridView.DataMember = "SERVICETYPE";

            equipmentDataGridView.DataSource = dataModule.greenDataSet;
            equipmentDataGridView.DataMember = "EQUIPMENT";

            serviceTypeEquipmentDataGridView.DataSource = dataModule.greenDataSet;
            serviceTypeEquipmentDataGridView.DataMember = "SERVICETYPE.SERVICETYPE_SERVICETYPEEQUIPMENT";
        }

        //ON-CLICK FUNCTIONS
        /// <summary>
        /// Decreases the serviceTypeCurrencyManager's count by 1 which displays different items in the serviceTypeDataGridView.
        /// </summary>
        /// <param name="sender">The object that called the onClick event. In this case the previousServiceTypeButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void previousServiceTypeButton_Click(object sender, EventArgs e)
        {
            if (serviceTypeCurrencyManager.Position < serviceTypeCurrencyManager.Count)
            {
                --serviceTypeCurrencyManager.Position;
            }

        }

        /// <summary>
        /// Increases the serviceTypeCurrencyManager's count by 1 which displays different items in the serviceTypeDataGridView.
        /// </summary>
        /// <param name="sender">The object that called the onClick event. In this case the nextServiceTypeButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void nextServiceTypeButton_Click(object sender, EventArgs e)
        {
            if (serviceTypeCurrencyManager.Position < serviceTypeCurrencyManager.Count)
            {
                ++serviceTypeCurrencyManager.Position;
            }
        }

        /// <summary>
        /// Decreases the equipmentCurrencyManager's count by 1 which displays different items in the equipmentDataGridView.
        /// </summary>
        /// <param name="sender">The object that called the onClick event. In this case the previousEquipmentButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void previousEquipmentButton_Click(object sender, EventArgs e)
        {
            if (equipmentCurrencyManager.Position < equipmentCurrencyManager.Count)
            {
                --equipmentCurrencyManager.Position;
            }

        }

        /// <summary>
        /// Increases the equipmentCurrencyManager's count by 1 which displays different items in the equipmentDataGridView.
        /// </summary>
        /// <param name="sender">The object that called the onClick event. In this case the nextEquipmentButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void nextEquipmentButton_Click(object sender, EventArgs e)
        {
            if (equipmentCurrencyManager.Position < equipmentCurrencyManager.Count)
            {
                ++equipmentCurrencyManager.Position;
            }
        }

        /// <summary>
        /// Closes the form.
        /// </summary>
        /// <param name="sender">The object that called the onClick event. In this case the returnButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //CREATE SERVICETYPEEQUIPMENT ENTRY
        /// <summary>
        /// Function that creates a new row in the SERVICETYPEEQUIPMENT Table.
        /// </summary>
        /// <param name="sender">The object that called the onClick event. In this case the allocateEquipmentButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void allocateEquipmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newEquipmentServiceTypeRow = dataModule.serviceTypeEquipmentDataTable.NewRow();
                newEquipmentServiceTypeRow["ServiceTypeID"] = serviceTypeDataGridView.CurrentRow.Cells[0].Value;
                newEquipmentServiceTypeRow["EquipmentID"] = equipmentDataGridView.CurrentRow.Cells[0].Value;
                dataModule.serviceTypeEquipmentDataTable.Rows.Add(newEquipmentServiceTypeRow);
                dataModule.UpdateServiceTypeEquipment();
                MessageBox.Show("Item of equipment allocated successfully.", "Allocation Successful");
            }
            catch (ConstraintException exception)
            {
                MessageBox.Show("That equipment has already been assigned to that service.", "Assignment Error");
            }
        }
        //DELETE SERVICETYPEEQUIPMENT ENTRY
        /// <summary>
        /// Function that deletes a row in the SERVICETYPEEQUIPMENT Table.
        /// </summary>
        /// <param name="sender">The object that called the onClick event. In this case the removeEquipmentButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void removeEquipmentButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this equipment?",
    "Confirm Removal",
    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Getting values form selected row in serviceTypeEquipmentDataGridView.
                DataGridViewRow serviceTypeEquipmentRow = serviceTypeEquipmentDataGridView.CurrentRow;
                Object[] valuesToFind = new Object[2];
                valuesToFind[0] = serviceTypeEquipmentRow.Cells["ServiceTypeID"].Value;
                valuesToFind[1] = serviceTypeEquipmentRow.Cells["EquipmentID"].Value;
                //Searching serviceTypeEquipmentDataGridView for primary keys matching those in currentRow.
                DataRow deleteServiceTypeEquipmentRow = dataModule.serviceTypeEquipmentDataTable.Rows.Find(valuesToFind);
                //Deleting matching row.
                deleteServiceTypeEquipmentRow.Delete();
                dataModule.UpdateServiceTypeEquipment();
                MessageBox.Show("Equipment removed successfully.", "Removal Successful");
            }
        }

        //MISC FUNCTIONS
        /// <summary>
        /// Function that sets the widths of columns in a Data Grid View
        /// </summary>
        /// <param name="view">The DataGridView object whose columns' width is to be set.</param>
        /// <param name="width">The width to set the DataGridView's columns to.</param>
        public void setColumnWidths(DataGridView view, int width)
        {
            for (int i = 0; i < view.ColumnCount; i++)
            {
                view.Columns[i].Width = width;
            }
        }
    }
}
