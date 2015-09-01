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
    //Purpose: Contains the design and methods for the main form which allows the user to navigate around the application. From the main form the user can access the invoice reports and a variety of record maintenenace forms.
    //Author: Fraser Kearns
    //Date Created: 02/08/15
    public partial class MainForm : Form
    {
        //VARIABLE DECLARATIONS
        private DataModule dataModule;
        private OwnerMaintenanceForm ownerMaintenanceForm;
        private ServiceTypeMaintenanceForm serviceTypeMaintenanceForm;
        private EquipmentMaintenanceForm equipmentMaintenanceForm;
        private VehicleMaintenanceForm vehicleMaintenanceForm;
        private ServiceMaintenanceForm serviceMaintenanceForm;
        private AllocateEquipmentForm allocateEquipmentForm;
        private PrintInvoicesForm printInvoicesForm;

        //CONSTRUCTOR
        /// <summary>
        /// The constructor for the main form - intializes the display objects and registers event listeners to these objects.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();  
        }

        //MISC FUNCTIONS
        /// <summary>
        /// Function that runs when the main forms loads - creates a DataModule object.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the mainForm.</param>
        /// <param name="e">The event arguments for the onLoad event passed to this function.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            dataModule = new DataModule();
        }

        //ON-CLICK FUNCTIONS
        /// <summary>
        /// Function that runs when the ownerMaintenanceButton is clicked - creates and displays a ownerMaintenanceForm.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the ownerMaintenanceButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void ownerMaintenanceButton_Click(object sender, EventArgs e)
        {
            if (ownerMaintenanceForm == null)
            {
                ownerMaintenanceForm = new OwnerMaintenanceForm(dataModule, this);
            }
            ownerMaintenanceForm.ShowDialog();
        }

        /// <summary>
        /// Function that runs when the serviceTypeMaintenanceButton is clicked - creates and displays a serviceTypeMaintenanceForm.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the serviceTypeMaintenanceButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void serviceTypeMaintenanceButton_Click(object sender, EventArgs e)
        {
            if (serviceTypeMaintenanceForm == null)
            {
                serviceTypeMaintenanceForm = new ServiceTypeMaintenanceForm(dataModule, this);
            }
            serviceTypeMaintenanceForm.ShowDialog();
        }

        /// <summary>
        /// Function that runs when the equipmentMaintenanceButton is clicked - creates and displays a equipmentMaintenanceForm.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the equipmentMaintenanceButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void equipmentMaintenanceButton_Click(object sender, EventArgs e)
        {
            if (equipmentMaintenanceForm == null)
            {
                equipmentMaintenanceForm = new EquipmentMaintenanceForm(dataModule, this);
            }
            equipmentMaintenanceForm.ShowDialog();
        }

        /// <summary>
        /// Function that runs when the vehicleMaintenanceButton is clicked - creates and displays a vehicleMaintenanceForm.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the vehicleMaintenanceButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void vehicleMaintenanceButton_Click(object sender, EventArgs e)
        {
            if (vehicleMaintenanceForm == null)
            {
                vehicleMaintenanceForm = new VehicleMaintenanceForm(dataModule, this);
            }
            vehicleMaintenanceForm.ShowDialog();
        }

        /// <summary>
        /// Function that runs when the serviceMaintenanceButton is clicked - creates and displays a serviceMaintenanceForm.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the serviceMaintenanceButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void serviceMaintenanceButton_Click(object sender, EventArgs e)
        {
            if (serviceMaintenanceForm == null)
            {
                serviceMaintenanceForm = new ServiceMaintenanceForm(dataModule, this);
            }
            serviceMaintenanceForm.ShowDialog();
        }

        /// <summary>
        /// Function that runs when the allocateEquipmentButton is clicked - creates and displays an allocateEquipmentForm.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the allocateEquipmentButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void allocateEquipmentButton_Click(object sender, EventArgs e)
        {
            if (allocateEquipmentForm == null)
            {
                allocateEquipmentForm = new AllocateEquipmentForm(dataModule, this);
            }
            allocateEquipmentForm.ShowDialog();
        }

        ///<summary>
        /// Function that runs when the invoicesButton is clicked - creates a displays a printInvoicesForm.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the invoicesButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void invoicesButton_Click(object sender, EventArgs e)
        {
            if (printInvoicesForm == null)
            {
                printInvoicesForm = new PrintInvoicesForm(dataModule, this);
            }
            printInvoicesForm.ShowDialog();
        }

        ///<summary>
        /// Function that runs when the exitButton is clicked - closes the program.
        /// </summary>
        /// <param name="sender">The object that called this function. In this case the exitButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
