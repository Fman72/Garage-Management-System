namespace Assignment2
{
    partial class MainForm
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
            this.reportGroup = new System.Windows.Forms.GroupBox();
            this.invoicesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.maintenanceGroup = new System.Windows.Forms.GroupBox();
            this.serviceTypeMaintenanceButton = new System.Windows.Forms.Button();
            this.equipmentMaintenanceButton = new System.Windows.Forms.Button();
            this.serviceMaintenanceButton = new System.Windows.Forms.Button();
            this.allocateEquipmentButton = new System.Windows.Forms.Button();
            this.vehicleMaintenanceButton = new System.Windows.Forms.Button();
            this.ownerMaintenanceButton = new System.Windows.Forms.Button();
            this.reportGroup.SuspendLayout();
            this.maintenanceGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportGroup
            // 
            this.reportGroup.Controls.Add(this.invoicesButton);
            this.reportGroup.Controls.Add(this.exitButton);
            this.reportGroup.Location = new System.Drawing.Point(493, 35);
            this.reportGroup.Name = "reportGroup";
            this.reportGroup.Size = new System.Drawing.Size(250, 500);
            this.reportGroup.TabIndex = 3;
            this.reportGroup.TabStop = false;
            this.reportGroup.Text = "Reporting";
            // 
            // invoicesButton
            // 
            this.invoicesButton.Location = new System.Drawing.Point(40, 50);
            this.invoicesButton.Name = "invoicesButton";
            this.invoicesButton.Size = new System.Drawing.Size(174, 23);
            this.invoicesButton.TabIndex = 1;
            this.invoicesButton.Text = "Invoices";
            this.invoicesButton.UseVisualStyleBackColor = true;
            this.invoicesButton.Click += new System.EventHandler(this.invoicesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(40, 425);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(174, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // maintenanceGroup
            // 
            this.maintenanceGroup.Controls.Add(this.serviceTypeMaintenanceButton);
            this.maintenanceGroup.Controls.Add(this.equipmentMaintenanceButton);
            this.maintenanceGroup.Controls.Add(this.serviceMaintenanceButton);
            this.maintenanceGroup.Controls.Add(this.allocateEquipmentButton);
            this.maintenanceGroup.Controls.Add(this.vehicleMaintenanceButton);
            this.maintenanceGroup.Controls.Add(this.ownerMaintenanceButton);
            this.maintenanceGroup.Location = new System.Drawing.Point(50, 35);
            this.maintenanceGroup.Name = "maintenanceGroup";
            this.maintenanceGroup.Size = new System.Drawing.Size(250, 500);
            this.maintenanceGroup.TabIndex = 2;
            this.maintenanceGroup.TabStop = false;
            this.maintenanceGroup.Text = "Maintenance";
            // 
            // serviceTypeMaintenanceButton
            // 
            this.serviceTypeMaintenanceButton.Location = new System.Drawing.Point(40, 125);
            this.serviceTypeMaintenanceButton.Name = "serviceTypeMaintenanceButton";
            this.serviceTypeMaintenanceButton.Size = new System.Drawing.Size(170, 25);
            this.serviceTypeMaintenanceButton.TabIndex = 5;
            this.serviceTypeMaintenanceButton.Text = "Service Type Maintenance";
            this.serviceTypeMaintenanceButton.UseVisualStyleBackColor = true;
            this.serviceTypeMaintenanceButton.Click += new System.EventHandler(this.serviceTypeMaintenanceButton_Click);
            // 
            // equipmentMaintenanceButton
            // 
            this.equipmentMaintenanceButton.Location = new System.Drawing.Point(40, 200);
            this.equipmentMaintenanceButton.Name = "equipmentMaintenanceButton";
            this.equipmentMaintenanceButton.Size = new System.Drawing.Size(170, 25);
            this.equipmentMaintenanceButton.TabIndex = 4;
            this.equipmentMaintenanceButton.Text = "Equipment Maintenance";
            this.equipmentMaintenanceButton.UseVisualStyleBackColor = true;
            this.equipmentMaintenanceButton.Click += new System.EventHandler(this.equipmentMaintenanceButton_Click);
            // 
            // serviceMaintenanceButton
            // 
            this.serviceMaintenanceButton.Location = new System.Drawing.Point(40, 350);
            this.serviceMaintenanceButton.Name = "serviceMaintenanceButton";
            this.serviceMaintenanceButton.Size = new System.Drawing.Size(170, 25);
            this.serviceMaintenanceButton.TabIndex = 3;
            this.serviceMaintenanceButton.Text = "Service Maintenance";
            this.serviceMaintenanceButton.UseVisualStyleBackColor = true;
            this.serviceMaintenanceButton.Click += new System.EventHandler(this.serviceMaintenanceButton_Click);
            // 
            // allocateEquipmentButton
            // 
            this.allocateEquipmentButton.Location = new System.Drawing.Point(40, 425);
            this.allocateEquipmentButton.Name = "allocateEquipmentButton";
            this.allocateEquipmentButton.Size = new System.Drawing.Size(170, 25);
            this.allocateEquipmentButton.TabIndex = 2;
            this.allocateEquipmentButton.Text = "Allocate Equipment";
            this.allocateEquipmentButton.UseVisualStyleBackColor = true;
            this.allocateEquipmentButton.Click += new System.EventHandler(this.allocateEquipmentButton_Click);
            // 
            // vehicleMaintenanceButton
            // 
            this.vehicleMaintenanceButton.Location = new System.Drawing.Point(40, 275);
            this.vehicleMaintenanceButton.Name = "vehicleMaintenanceButton";
            this.vehicleMaintenanceButton.Size = new System.Drawing.Size(170, 25);
            this.vehicleMaintenanceButton.TabIndex = 1;
            this.vehicleMaintenanceButton.Text = "Vehicle Maintenance";
            this.vehicleMaintenanceButton.UseVisualStyleBackColor = true;
            this.vehicleMaintenanceButton.Click += new System.EventHandler(this.vehicleMaintenanceButton_Click);
            // 
            // ownerMaintenanceButton
            // 
            this.ownerMaintenanceButton.Location = new System.Drawing.Point(40, 50);
            this.ownerMaintenanceButton.Name = "ownerMaintenanceButton";
            this.ownerMaintenanceButton.Size = new System.Drawing.Size(170, 25);
            this.ownerMaintenanceButton.TabIndex = 0;
            this.ownerMaintenanceButton.Text = "Owner Maintenance";
            this.ownerMaintenanceButton.UseVisualStyleBackColor = true;
            this.ownerMaintenanceButton.Click += new System.EventHandler(this.ownerMaintenanceButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.reportGroup);
            this.Controls.Add(this.maintenanceGroup);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.reportGroup.ResumeLayout(false);
            this.maintenanceGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox reportGroup;
        private System.Windows.Forms.Button invoicesButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox maintenanceGroup;
        private System.Windows.Forms.Button serviceTypeMaintenanceButton;
        private System.Windows.Forms.Button equipmentMaintenanceButton;
        private System.Windows.Forms.Button serviceMaintenanceButton;
        private System.Windows.Forms.Button allocateEquipmentButton;
        private System.Windows.Forms.Button vehicleMaintenanceButton;
        private System.Windows.Forms.Button ownerMaintenanceButton;
    }
}

