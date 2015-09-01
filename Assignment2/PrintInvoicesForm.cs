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
    /// This class contains the design and functions for the form that allows the user to preview/print an invoices report for the data in the system.
    /// </summary>
    public partial class PrintInvoicesForm : Form
    {
        //DECLARING VARIABLES
        CurrencyManager serviceCurrencyManager;
        CurrencyManager serviceTypeCurrencyManager;
        CurrencyManager vehicleCurrencyManager;
        CurrencyManager ownerCurrencyManager;
        DataModule dataModule;
        MainForm mainForm;
        Brush blackBrush;
        Graphics printGraphics;
        int linesSoFar = 0;
        /// <summary>
        /// The constructor for the PrintInvoicesForm. Initializes the display objects and variables for the form.
        /// </summary>
        /// <param name="dataModule">The DataModule object this application uses for database connection.</param>
        /// <param name="mainForm">The MainForm that was clicked to open this form.</param>
        public PrintInvoicesForm(DataModule dataModule, MainForm mainForm)
        {
            InitializeComponent();
            this.dataModule = dataModule;
            this.mainForm = mainForm;
            serviceCurrencyManager = (CurrencyManager)this.BindingContext[dataModule.greenDataSet, "SERVICE"];
            ownerCurrencyManager = (CurrencyManager)this.BindingContext[dataModule.greenDataSet, "OWNER"];
            vehicleCurrencyManager = (CurrencyManager)this.BindingContext[dataModule.greenDataSet, "VEHICLE"];
            serviceTypeCurrencyManager = (CurrencyManager)this.BindingContext[dataModule.greenDataSet, "SERVICETYPE"];
            blackBrush = new SolidBrush(Color.Black);
            this.printPreviewDialog.Document = reportPrintDocument;
        }
        /// <summary>
        /// This function contains the logic for printing the report.
        /// </summary>
        /// <param name="sender">The conrol that called this function.</param>
        /// <param name="e">The PrintPageEventArgs for the PrintPageEvent that is passed to this function.</param>
        private void reportPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printGraphics = e.Graphics;
            Font standardFont = new Font("Arial", 10, FontStyle.Regular);
            Font importantFont = new Font("Arial", 14, FontStyle.Regular);

            //Iterating through each service in the system.
            foreach (DataRow serviceDataRow in dataModule.serviceDataTable.Rows)
            {
                //If the service is pending.
                if (serviceDataRow["Status"].ToString() == "Pending")
                {
                    //Getting the DataRow for the vehicle corresponding to this service.
                    vehicleCurrencyManager.Position = dataModule.vehicleView.Find(serviceDataRow["VehicleID"]);
                    DataRow vehiclePrintRow = dataModule.vehicleDataTable.Rows[vehicleCurrencyManager.Position];
                    //Getting the DataRow for the owner of the vehicle corresponding to this service.
                    ownerCurrencyManager.Position = dataModule.ownerView.Find(vehiclePrintRow["OwnerID"]);
                    DataRow ownerPrintRow = dataModule.ownerDataTable.Rows[ownerCurrencyManager.Position];
                    //Getting the DataRow for the serviceType corresponding to this service.
                    serviceTypeCurrencyManager.Position = dataModule.serviceTypeView.Find(serviceDataRow["ServiceTypeID"]);
                    DataRow serviceTypePrintRow = dataModule.serviceTypeDataTable.Rows[serviceTypeCurrencyManager.Position];
                    //Drawing owner details to preview form.
                    this.drawToPage("Owner", importantFont, 0, linesSoFar);
                    linesSoFar++;
                    linesSoFar++;
                    this.drawToPage("Owner ID: " + ownerPrintRow["OwnerID"], standardFont, 0, linesSoFar);
                    linesSoFar++;
                    this.drawToPage("Name: " + ownerPrintRow["FirstName"] + " " + ownerPrintRow["LastName"], standardFont, 0, linesSoFar);
                    linesSoFar++;
                    this.drawToPage("Address: " + ownerPrintRow["StreetAddress"], standardFont, 0, linesSoFar);
                    this.drawToPage(ownerPrintRow["Suburb"].ToString(), standardFont, 9, linesSoFar);
                }
            }
        }
        /// <summary>
        /// This function draw a string the the PrintDocument
        /// </summary>
        /// <param name="stringToDraw">The string to draw to the document.</param>
        /// <param name="fontToDraw">The font to draw the string in.</param>
        /// <param name="columnToDraw">The y co-ordinate to draw the string on. (The column to start the string on).</param>
        /// <param name="lineToDraw">The x co-ordinate to draw the string on. (The column to draw the string on).</param>
        private void drawToPage(String stringToDraw, Font fontToDraw, float columnToDraw, float lineToDraw)
        {
            printGraphics.DrawString(stringToDraw, fontToDraw, blackBrush, columnToDraw, lineToDraw);
        }

        /// <summary>
        /// Function that runs when the printPreviewButton is clicked. Displays the print preview dialog.
        /// </summary>
        /// <param name="sender">The object that called the onClick event. In this case the printPreviewButton.</param>
        /// <param name="e">The event arguments for the Click event passed to this function.</param>
        private void printPreviewButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }
    }
}
