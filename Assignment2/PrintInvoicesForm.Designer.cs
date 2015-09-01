namespace Assignment2
{
    partial class PrintInvoicesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintInvoicesForm));
            this.reportPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewButton = new System.Windows.Forms.Button();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // reportPrintDocument
            // 
            this.reportPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.reportPrintDocument_PrintPage);
            // 
            // printPreviewButton
            // 
            this.printPreviewButton.Location = new System.Drawing.Point(691, 538);
            this.printPreviewButton.Name = "printPreviewButton";
            this.printPreviewButton.Size = new System.Drawing.Size(75, 23);
            this.printPreviewButton.TabIndex = 1;
            this.printPreviewButton.Text = "Preview";
            this.printPreviewButton.UseVisualStyleBackColor = true;
            this.printPreviewButton.Click += new System.EventHandler(this.printPreviewButton_Click);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // PrintInvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.printPreviewButton);
            this.Name = "PrintInvoicesForm";
            this.Text = "PrintInvoicesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument reportPrintDocument;
        private System.Windows.Forms.Button printPreviewButton;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}