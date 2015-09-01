namespace Assignment2
{
    partial class ServiceMaintenanceForm
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
            this.serviceDataGridView = new System.Windows.Forms.DataGridView();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.plateNumberDisplayLabel = new System.Windows.Forms.Label();
            this.fullNameDisplayLabel = new System.Windows.Forms.Label();
            this.descriptionDisplayLabel = new System.Windows.Forms.Label();
            this.hourlyRateDisplayLabel = new System.Windows.Forms.Label();
            this.markPaidServiceButton = new System.Windows.Forms.Button();
            this.deleteServiceButton = new System.Windows.Forms.Button();
            this.updateServiceButton = new System.Windows.Forms.Button();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.addServicePanel = new System.Windows.Forms.Panel();
            this.updateServicePanel = new System.Windows.Forms.Panel();
            this.serviceTypeUpdateDisplayLabel = new System.Windows.Forms.Label();
            this.vehicleIDUpdateDisplayLabel = new System.Windows.Forms.Label();
            this.hoursUpdateTextBox = new System.Windows.Forms.TextBox();
            this.hoursUpdatePrompt = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateUpdatePicker = new System.Windows.Forms.DateTimePicker();
            this.dateUpdatePrompt = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cancelUpdateButton = new System.Windows.Forms.Button();
            this.saveUpdateButton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.hoursAddTextBox = new System.Windows.Forms.TextBox();
            this.hoursAddPrompt = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateAddPicker = new System.Windows.Forms.DateTimePicker();
            this.dateAddPrompt = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.serviceTypeAddComboBox = new System.Windows.Forms.ComboBox();
            this.serviceTypeAddPrompt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.vehicleIDAddComboBox = new System.Windows.Forms.ComboBox();
            this.cancelAddButton = new System.Windows.Forms.Button();
            this.saveAddButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.vehicleIDAddPrompt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.greenDataSet = new Assignment2.GreenDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).BeginInit();
            this.addServicePanel.SuspendLayout();
            this.updateServicePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceDataGridView
            // 
            this.serviceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceDataGridView.Location = new System.Drawing.Point(30, 50);
            this.serviceDataGridView.MultiSelect = false;
            this.serviceDataGridView.Name = "serviceDataGridView";
            this.serviceDataGridView.ReadOnly = true;
            this.serviceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.serviceDataGridView.Size = new System.Drawing.Size(459, 394);
            this.serviceDataGridView.TabIndex = 0;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(140, 470);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(90, 25);
            this.nextButton.TabIndex = 55;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(30, 470);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(90, 25);
            this.previousButton.TabIndex = 56;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Vehicle Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Hourly Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Owner\'s Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(576, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Plate Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Service Type Details:";
            // 
            // plateNumberDisplayLabel
            // 
            this.plateNumberDisplayLabel.AutoSize = true;
            this.plateNumberDisplayLabel.Location = new System.Drawing.Point(671, 88);
            this.plateNumberDisplayLabel.Name = "plateNumberDisplayLabel";
            this.plateNumberDisplayLabel.Size = new System.Drawing.Size(0, 13);
            this.plateNumberDisplayLabel.TabIndex = 63;
            this.plateNumberDisplayLabel.TextChanged += new System.EventHandler(this.plateNumberDisplayLabel_TextChanged);
            // 
            // fullNameDisplayLabel
            // 
            this.fullNameDisplayLabel.AutoSize = true;
            this.fullNameDisplayLabel.Location = new System.Drawing.Point(671, 124);
            this.fullNameDisplayLabel.Name = "fullNameDisplayLabel";
            this.fullNameDisplayLabel.Size = new System.Drawing.Size(0, 13);
            this.fullNameDisplayLabel.TabIndex = 65;
            // 
            // descriptionDisplayLabel
            // 
            this.descriptionDisplayLabel.AutoSize = true;
            this.descriptionDisplayLabel.Location = new System.Drawing.Point(671, 196);
            this.descriptionDisplayLabel.Name = "descriptionDisplayLabel";
            this.descriptionDisplayLabel.Size = new System.Drawing.Size(0, 13);
            this.descriptionDisplayLabel.TabIndex = 66;
            // 
            // hourlyRateDisplayLabel
            // 
            this.hourlyRateDisplayLabel.AutoSize = true;
            this.hourlyRateDisplayLabel.Location = new System.Drawing.Point(671, 232);
            this.hourlyRateDisplayLabel.Name = "hourlyRateDisplayLabel";
            this.hourlyRateDisplayLabel.Size = new System.Drawing.Size(0, 13);
            this.hourlyRateDisplayLabel.TabIndex = 67;
            // 
            // markPaidServiceButton
            // 
            this.markPaidServiceButton.Location = new System.Drawing.Point(333, 470);
            this.markPaidServiceButton.Name = "markPaidServiceButton";
            this.markPaidServiceButton.Size = new System.Drawing.Size(156, 25);
            this.markPaidServiceButton.TabIndex = 68;
            this.markPaidServiceButton.Text = "Mark Service As Paid";
            this.markPaidServiceButton.UseVisualStyleBackColor = true;
            this.markPaidServiceButton.Click += new System.EventHandler(this.markPaidServiceButton_Click);
            // 
            // deleteServiceButton
            // 
            this.deleteServiceButton.Location = new System.Drawing.Point(346, 523);
            this.deleteServiceButton.Name = "deleteServiceButton";
            this.deleteServiceButton.Size = new System.Drawing.Size(143, 25);
            this.deleteServiceButton.TabIndex = 71;
            this.deleteServiceButton.Text = "Delete Service";
            this.deleteServiceButton.UseVisualStyleBackColor = true;
            this.deleteServiceButton.Click += new System.EventHandler(this.deleteServiceButton_Click);
            // 
            // updateServiceButton
            // 
            this.updateServiceButton.Location = new System.Drawing.Point(188, 523);
            this.updateServiceButton.Name = "updateServiceButton";
            this.updateServiceButton.Size = new System.Drawing.Size(143, 25);
            this.updateServiceButton.TabIndex = 70;
            this.updateServiceButton.Text = "Modify Service";
            this.updateServiceButton.UseVisualStyleBackColor = true;
            this.updateServiceButton.Click += new System.EventHandler(this.updateServiceButton_Click);
            // 
            // addServiceButton
            // 
            this.addServiceButton.Location = new System.Drawing.Point(30, 523);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(143, 25);
            this.addServiceButton.TabIndex = 69;
            this.addServiceButton.Text = "Add Service";
            this.addServiceButton.UseVisualStyleBackColor = true;
            this.addServiceButton.Click += new System.EventHandler(this.addServiceButton_Click);
            // 
            // addServicePanel
            // 
            this.addServicePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addServicePanel.Controls.Add(this.hoursAddTextBox);
            this.addServicePanel.Controls.Add(this.hoursAddPrompt);
            this.addServicePanel.Controls.Add(this.label12);
            this.addServicePanel.Controls.Add(this.dateAddPicker);
            this.addServicePanel.Controls.Add(this.dateAddPrompt);
            this.addServicePanel.Controls.Add(this.label11);
            this.addServicePanel.Controls.Add(this.serviceTypeAddComboBox);
            this.addServicePanel.Controls.Add(this.serviceTypeAddPrompt);
            this.addServicePanel.Controls.Add(this.label9);
            this.addServicePanel.Controls.Add(this.vehicleIDAddComboBox);
            this.addServicePanel.Controls.Add(this.cancelAddButton);
            this.addServicePanel.Controls.Add(this.saveAddButton);
            this.addServicePanel.Controls.Add(this.label7);
            this.addServicePanel.Controls.Add(this.vehicleIDAddPrompt);
            this.addServicePanel.Controls.Add(this.label8);
            this.addServicePanel.Location = new System.Drawing.Point(202, 52);
            this.addServicePanel.Name = "addServicePanel";
            this.addServicePanel.Size = new System.Drawing.Size(555, 347);
            this.addServicePanel.TabIndex = 72;
            this.addServicePanel.Visible = false;
            // 
            // updateServicePanel
            // 
            this.updateServicePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateServicePanel.Controls.Add(this.serviceTypeUpdateDisplayLabel);
            this.updateServicePanel.Controls.Add(this.vehicleIDUpdateDisplayLabel);
            this.updateServicePanel.Controls.Add(this.hoursUpdateTextBox);
            this.updateServicePanel.Controls.Add(this.hoursUpdatePrompt);
            this.updateServicePanel.Controls.Add(this.label13);
            this.updateServicePanel.Controls.Add(this.dateUpdatePicker);
            this.updateServicePanel.Controls.Add(this.dateUpdatePrompt);
            this.updateServicePanel.Controls.Add(this.label15);
            this.updateServicePanel.Controls.Add(this.label17);
            this.updateServicePanel.Controls.Add(this.cancelUpdateButton);
            this.updateServicePanel.Controls.Add(this.saveUpdateButton);
            this.updateServicePanel.Controls.Add(this.label18);
            this.updateServicePanel.Controls.Add(this.label20);
            this.updateServicePanel.Location = new System.Drawing.Point(202, 52);
            this.updateServicePanel.Name = "updateServicePanel";
            this.updateServicePanel.Size = new System.Drawing.Size(555, 347);
            this.updateServicePanel.TabIndex = 74;
            this.updateServicePanel.Visible = false;
            // 
            // serviceTypeUpdateDisplayLabel
            // 
            this.serviceTypeUpdateDisplayLabel.AutoSize = true;
            this.serviceTypeUpdateDisplayLabel.Location = new System.Drawing.Point(227, 110);
            this.serviceTypeUpdateDisplayLabel.Name = "serviceTypeUpdateDisplayLabel";
            this.serviceTypeUpdateDisplayLabel.Size = new System.Drawing.Size(0, 13);
            this.serviceTypeUpdateDisplayLabel.TabIndex = 53;
            // 
            // vehicleIDUpdateDisplayLabel
            // 
            this.vehicleIDUpdateDisplayLabel.AutoSize = true;
            this.vehicleIDUpdateDisplayLabel.Location = new System.Drawing.Point(227, 50);
            this.vehicleIDUpdateDisplayLabel.Name = "vehicleIDUpdateDisplayLabel";
            this.vehicleIDUpdateDisplayLabel.Size = new System.Drawing.Size(0, 13);
            this.vehicleIDUpdateDisplayLabel.TabIndex = 52;
            // 
            // hoursUpdateTextBox
            // 
            this.hoursUpdateTextBox.Location = new System.Drawing.Point(231, 227);
            this.hoursUpdateTextBox.Name = "hoursUpdateTextBox";
            this.hoursUpdateTextBox.Size = new System.Drawing.Size(100, 20);
            this.hoursUpdateTextBox.TabIndex = 51;
            // 
            // hoursUpdatePrompt
            // 
            this.hoursUpdatePrompt.AutoSize = true;
            this.hoursUpdatePrompt.ForeColor = System.Drawing.Color.Red;
            this.hoursUpdatePrompt.Location = new System.Drawing.Point(230, 254);
            this.hoursUpdatePrompt.Name = "hoursUpdatePrompt";
            this.hoursUpdatePrompt.Size = new System.Drawing.Size(0, 13);
            this.hoursUpdatePrompt.TabIndex = 50;
            this.hoursUpdatePrompt.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(125, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 48;
            this.label13.Text = "Duration:";
            // 
            // dateUpdatePicker
            // 
            this.dateUpdatePicker.CustomFormat = "\"dd-MMM-yy\"";
            this.dateUpdatePicker.Location = new System.Drawing.Point(230, 164);
            this.dateUpdatePicker.Name = "dateUpdatePicker";
            this.dateUpdatePicker.Size = new System.Drawing.Size(200, 20);
            this.dateUpdatePicker.TabIndex = 47;
            // 
            // dateUpdatePrompt
            // 
            this.dateUpdatePrompt.AutoSize = true;
            this.dateUpdatePrompt.ForeColor = System.Drawing.Color.Red;
            this.dateUpdatePrompt.Location = new System.Drawing.Point(230, 194);
            this.dateUpdatePrompt.Name = "dateUpdatePrompt";
            this.dateUpdatePrompt.Size = new System.Drawing.Size(0, 13);
            this.dateUpdatePrompt.TabIndex = 45;
            this.dateUpdatePrompt.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(125, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "Date:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(125, 110);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "Service Type:";
            // 
            // cancelUpdateButton
            // 
            this.cancelUpdateButton.Location = new System.Drawing.Point(293, 292);
            this.cancelUpdateButton.Name = "cancelUpdateButton";
            this.cancelUpdateButton.Size = new System.Drawing.Size(150, 25);
            this.cancelUpdateButton.TabIndex = 39;
            this.cancelUpdateButton.Text = "Cancel";
            this.cancelUpdateButton.UseVisualStyleBackColor = true;
            this.cancelUpdateButton.Click += new System.EventHandler(this.cancelUpdateButton_Click);
            // 
            // saveUpdateButton
            // 
            this.saveUpdateButton.Location = new System.Drawing.Point(128, 292);
            this.saveUpdateButton.Name = "saveUpdateButton";
            this.saveUpdateButton.Size = new System.Drawing.Size(150, 25);
            this.saveUpdateButton.TabIndex = 38;
            this.saveUpdateButton.Text = "Update Service";
            this.saveUpdateButton.UseVisualStyleBackColor = true;
            this.saveUpdateButton.Click += new System.EventHandler(this.saveUpdateButton_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(230, 320);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 13);
            this.label18.TabIndex = 12;
            this.label18.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(125, 50);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Vehicle ID:";
            // 
            // hoursAddTextBox
            // 
            this.hoursAddTextBox.Location = new System.Drawing.Point(231, 227);
            this.hoursAddTextBox.Name = "hoursAddTextBox";
            this.hoursAddTextBox.Size = new System.Drawing.Size(100, 20);
            this.hoursAddTextBox.TabIndex = 51;
            // 
            // hoursAddPrompt
            // 
            this.hoursAddPrompt.AutoSize = true;
            this.hoursAddPrompt.ForeColor = System.Drawing.Color.Red;
            this.hoursAddPrompt.Location = new System.Drawing.Point(230, 254);
            this.hoursAddPrompt.Name = "hoursAddPrompt";
            this.hoursAddPrompt.Size = new System.Drawing.Size(0, 13);
            this.hoursAddPrompt.TabIndex = 50;
            this.hoursAddPrompt.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(125, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Duration:";
            // 
            // dateAddPicker
            // 
            this.dateAddPicker.CustomFormat = "\"dd-MMM-yy\"";
            this.dateAddPicker.Location = new System.Drawing.Point(230, 164);
            this.dateAddPicker.Name = "dateAddPicker";
            this.dateAddPicker.Size = new System.Drawing.Size(200, 20);
            this.dateAddPicker.TabIndex = 47;
            // 
            // dateAddPrompt
            // 
            this.dateAddPrompt.AutoSize = true;
            this.dateAddPrompt.ForeColor = System.Drawing.Color.Red;
            this.dateAddPrompt.Location = new System.Drawing.Point(230, 194);
            this.dateAddPrompt.Name = "dateAddPrompt";
            this.dateAddPrompt.Size = new System.Drawing.Size(0, 13);
            this.dateAddPrompt.TabIndex = 45;
            this.dateAddPrompt.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(125, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Date:";
            // 
            // serviceTypeAddComboBox
            // 
            this.serviceTypeAddComboBox.FormattingEnabled = true;
            this.serviceTypeAddComboBox.Location = new System.Drawing.Point(230, 106);
            this.serviceTypeAddComboBox.Name = "serviceTypeAddComboBox";
            this.serviceTypeAddComboBox.Size = new System.Drawing.Size(121, 21);
            this.serviceTypeAddComboBox.TabIndex = 43;
            // 
            // serviceTypeAddPrompt
            // 
            this.serviceTypeAddPrompt.AutoSize = true;
            this.serviceTypeAddPrompt.ForeColor = System.Drawing.Color.Red;
            this.serviceTypeAddPrompt.Location = new System.Drawing.Point(230, 136);
            this.serviceTypeAddPrompt.Name = "serviceTypeAddPrompt";
            this.serviceTypeAddPrompt.Size = new System.Drawing.Size(0, 13);
            this.serviceTypeAddPrompt.TabIndex = 42;
            this.serviceTypeAddPrompt.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(125, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Service Type:";
            // 
            // vehicleIDAddComboBox
            // 
            this.vehicleIDAddComboBox.FormattingEnabled = true;
            this.vehicleIDAddComboBox.Location = new System.Drawing.Point(230, 47);
            this.vehicleIDAddComboBox.Name = "vehicleIDAddComboBox";
            this.vehicleIDAddComboBox.Size = new System.Drawing.Size(121, 21);
            this.vehicleIDAddComboBox.TabIndex = 40;
            // 
            // cancelAddButton
            // 
            this.cancelAddButton.Location = new System.Drawing.Point(293, 292);
            this.cancelAddButton.Name = "cancelAddButton";
            this.cancelAddButton.Size = new System.Drawing.Size(150, 25);
            this.cancelAddButton.TabIndex = 39;
            this.cancelAddButton.Text = "Cancel";
            this.cancelAddButton.UseVisualStyleBackColor = true;
            this.cancelAddButton.Click += new System.EventHandler(this.cancelAddButton_Click);
            // 
            // saveAddButton
            // 
            this.saveAddButton.Location = new System.Drawing.Point(128, 292);
            this.saveAddButton.Name = "saveAddButton";
            this.saveAddButton.Size = new System.Drawing.Size(150, 25);
            this.saveAddButton.TabIndex = 38;
            this.saveAddButton.Text = "Save Service";
            this.saveAddButton.UseVisualStyleBackColor = true;
            this.saveAddButton.Click += new System.EventHandler(this.saveAddButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(230, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 12;
            this.label7.Visible = false;
            // 
            // vehicleIDAddPrompt
            // 
            this.vehicleIDAddPrompt.AutoSize = true;
            this.vehicleIDAddPrompt.ForeColor = System.Drawing.Color.Red;
            this.vehicleIDAddPrompt.Location = new System.Drawing.Point(230, 77);
            this.vehicleIDAddPrompt.Name = "vehicleIDAddPrompt";
            this.vehicleIDAddPrompt.Size = new System.Drawing.Size(0, 13);
            this.vehicleIDAddPrompt.TabIndex = 9;
            this.vehicleIDAddPrompt.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Vehicle ID:";
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(614, 523);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(143, 25);
            this.returnButton.TabIndex = 73;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // greenDataSet
            // 
            this.greenDataSet.DataSetName = "GreenDataSet";
            this.greenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ServiceMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.updateServicePanel);
            this.Controls.Add(this.addServicePanel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.deleteServiceButton);
            this.Controls.Add(this.updateServiceButton);
            this.Controls.Add(this.addServiceButton);
            this.Controls.Add(this.markPaidServiceButton);
            this.Controls.Add(this.hourlyRateDisplayLabel);
            this.Controls.Add(this.descriptionDisplayLabel);
            this.Controls.Add(this.fullNameDisplayLabel);
            this.Controls.Add(this.plateNumberDisplayLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.serviceDataGridView);
            this.Name = "ServiceMaintenanceForm";
            this.Text = "Service Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).EndInit();
            this.addServicePanel.ResumeLayout(false);
            this.addServicePanel.PerformLayout();
            this.updateServicePanel.ResumeLayout(false);
            this.updateServicePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greenDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView serviceDataGridView;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label plateNumberDisplayLabel;
        private System.Windows.Forms.Label fullNameDisplayLabel;
        private System.Windows.Forms.Label descriptionDisplayLabel;
        private System.Windows.Forms.Label hourlyRateDisplayLabel;
        private System.Windows.Forms.Button markPaidServiceButton;
        private System.Windows.Forms.Button deleteServiceButton;
        private System.Windows.Forms.Button updateServiceButton;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.Panel addServicePanel;
        private System.Windows.Forms.ComboBox serviceTypeAddComboBox;
        private System.Windows.Forms.Label serviceTypeAddPrompt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox vehicleIDAddComboBox;
        private System.Windows.Forms.Button cancelAddButton;
        private System.Windows.Forms.Button saveAddButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label vehicleIDAddPrompt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateAddPicker;
        private System.Windows.Forms.Label dateAddPrompt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label hoursAddPrompt;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.TextBox hoursAddTextBox;
        private System.Windows.Forms.Panel updateServicePanel;
        private System.Windows.Forms.Label serviceTypeUpdateDisplayLabel;
        private System.Windows.Forms.Label vehicleIDUpdateDisplayLabel;
        private System.Windows.Forms.TextBox hoursUpdateTextBox;
        private System.Windows.Forms.Label hoursUpdatePrompt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateUpdatePicker;
        private System.Windows.Forms.Label dateUpdatePrompt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button cancelUpdateButton;
        private System.Windows.Forms.Button saveUpdateButton;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private GreenDataSet greenDataSet;
    }
}