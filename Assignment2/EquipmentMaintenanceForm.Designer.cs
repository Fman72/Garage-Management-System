namespace Assignment2
{
    partial class EquipmentMaintenanceForm
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
            this.returnButton = new System.Windows.Forms.Button();
            this.descriptionDisplayLabel = new System.Windows.Forms.Label();
            this.deleteEquipmentButton = new System.Windows.Forms.Button();
            this.updateEquipmentButton = new System.Windows.Forms.Button();
            this.addEquipmentButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.equipmentIDDisplayLabel = new System.Windows.Forms.Label();
            this.equipmentIDLabel = new System.Windows.Forms.Label();
            this.equipmentListBox = new System.Windows.Forms.ListBox();
            this.addEquipmentPanel = new System.Windows.Forms.Panel();
            this.addCancelButton = new System.Windows.Forms.Button();
            this.saveAddButton = new System.Windows.Forms.Button();
            this.phoneNumberPrompt = new System.Windows.Forms.Label();
            this.descriptionAddPrompt = new System.Windows.Forms.Label();
            this.descriptionAddTextBox = new System.Windows.Forms.TextBox();
            this.descriptionInputLabel = new System.Windows.Forms.Label();
            this.updateEquipmentPanel = new System.Windows.Forms.Panel();
            this.updateCancelButton = new System.Windows.Forms.Button();
            this.saveUpdateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionUpdatePrompt = new System.Windows.Forms.Label();
            this.descriptionUpdateTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addEquipmentPanel.SuspendLayout();
            this.updateEquipmentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(600, 536);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(150, 25);
            this.returnButton.TabIndex = 64;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // descriptionDisplayLabel
            // 
            this.descriptionDisplayLabel.AutoSize = true;
            this.descriptionDisplayLabel.Location = new System.Drawing.Point(364, 103);
            this.descriptionDisplayLabel.Name = "descriptionDisplayLabel";
            this.descriptionDisplayLabel.Size = new System.Drawing.Size(0, 13);
            this.descriptionDisplayLabel.TabIndex = 60;
            // 
            // deleteEquipmentButton
            // 
            this.deleteEquipmentButton.Location = new System.Drawing.Point(600, 491);
            this.deleteEquipmentButton.Name = "deleteEquipmentButton";
            this.deleteEquipmentButton.Size = new System.Drawing.Size(150, 25);
            this.deleteEquipmentButton.TabIndex = 57;
            this.deleteEquipmentButton.Text = "Delete Equipment";
            this.deleteEquipmentButton.UseVisualStyleBackColor = true;
            this.deleteEquipmentButton.Click += new System.EventHandler(this.deleteEquipmentButton_Click);
            // 
            // updateEquipmentButton
            // 
            this.updateEquipmentButton.Location = new System.Drawing.Point(430, 491);
            this.updateEquipmentButton.Name = "updateEquipmentButton";
            this.updateEquipmentButton.Size = new System.Drawing.Size(150, 25);
            this.updateEquipmentButton.TabIndex = 56;
            this.updateEquipmentButton.Text = "Modify Equipment";
            this.updateEquipmentButton.UseVisualStyleBackColor = true;
            this.updateEquipmentButton.Click += new System.EventHandler(this.updateEquipmentButton_Click);
            // 
            // addEquipmentButton
            // 
            this.addEquipmentButton.Location = new System.Drawing.Point(260, 491);
            this.addEquipmentButton.Name = "addEquipmentButton";
            this.addEquipmentButton.Size = new System.Drawing.Size(150, 25);
            this.addEquipmentButton.TabIndex = 55;
            this.addEquipmentButton.Text = "Add Equipment";
            this.addEquipmentButton.UseVisualStyleBackColor = true;
            this.addEquipmentButton.Click += new System.EventHandler(this.addEquipmentButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(140, 491);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(90, 25);
            this.nextButton.TabIndex = 54;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(30, 491);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(90, 25);
            this.previousButton.TabIndex = 53;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(260, 103);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 51;
            this.descriptionLabel.Text = "Description:";
            // 
            // equipmentIDDisplayLabel
            // 
            this.equipmentIDDisplayLabel.AutoSize = true;
            this.equipmentIDDisplayLabel.Location = new System.Drawing.Point(364, 50);
            this.equipmentIDDisplayLabel.Name = "equipmentIDDisplayLabel";
            this.equipmentIDDisplayLabel.Size = new System.Drawing.Size(0, 13);
            this.equipmentIDDisplayLabel.TabIndex = 50;
            // 
            // equipmentIDLabel
            // 
            this.equipmentIDLabel.AutoSize = true;
            this.equipmentIDLabel.Location = new System.Drawing.Point(260, 50);
            this.equipmentIDLabel.Name = "equipmentIDLabel";
            this.equipmentIDLabel.Size = new System.Drawing.Size(74, 13);
            this.equipmentIDLabel.TabIndex = 49;
            this.equipmentIDLabel.Text = "Equipment ID:";
            // 
            // equipmentListBox
            // 
            this.equipmentListBox.FormattingEnabled = true;
            this.equipmentListBox.Location = new System.Drawing.Point(30, 50);
            this.equipmentListBox.Name = "equipmentListBox";
            this.equipmentListBox.Size = new System.Drawing.Size(200, 394);
            this.equipmentListBox.TabIndex = 48;
            // 
            // addEquipmentPanel
            // 
            this.addEquipmentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addEquipmentPanel.Controls.Add(this.addCancelButton);
            this.addEquipmentPanel.Controls.Add(this.saveAddButton);
            this.addEquipmentPanel.Controls.Add(this.phoneNumberPrompt);
            this.addEquipmentPanel.Controls.Add(this.descriptionAddPrompt);
            this.addEquipmentPanel.Controls.Add(this.descriptionAddTextBox);
            this.addEquipmentPanel.Controls.Add(this.descriptionInputLabel);
            this.addEquipmentPanel.Location = new System.Drawing.Point(205, 50);
            this.addEquipmentPanel.Name = "addEquipmentPanel";
            this.addEquipmentPanel.Size = new System.Drawing.Size(575, 171);
            this.addEquipmentPanel.TabIndex = 65;
            this.addEquipmentPanel.Visible = false;
            // 
            // addCancelButton
            // 
            this.addCancelButton.Location = new System.Drawing.Point(286, 107);
            this.addCancelButton.Name = "addCancelButton";
            this.addCancelButton.Size = new System.Drawing.Size(150, 25);
            this.addCancelButton.TabIndex = 39;
            this.addCancelButton.Text = "Cancel";
            this.addCancelButton.UseVisualStyleBackColor = true;
            this.addCancelButton.Click += new System.EventHandler(this.cancelAddButton_Click);
            // 
            // saveAddButton
            // 
            this.saveAddButton.Location = new System.Drawing.Point(118, 107);
            this.saveAddButton.Name = "saveAddButton";
            this.saveAddButton.Size = new System.Drawing.Size(150, 25);
            this.saveAddButton.TabIndex = 38;
            this.saveAddButton.Text = "Save Equipment";
            this.saveAddButton.UseVisualStyleBackColor = true;
            this.saveAddButton.Click += new System.EventHandler(this.saveAddButton_Click);
            // 
            // phoneNumberPrompt
            // 
            this.phoneNumberPrompt.AutoSize = true;
            this.phoneNumberPrompt.ForeColor = System.Drawing.Color.Red;
            this.phoneNumberPrompt.Location = new System.Drawing.Point(230, 320);
            this.phoneNumberPrompt.Name = "phoneNumberPrompt";
            this.phoneNumberPrompt.Size = new System.Drawing.Size(0, 13);
            this.phoneNumberPrompt.TabIndex = 12;
            this.phoneNumberPrompt.Visible = false;
            // 
            // descriptionAddPrompt
            // 
            this.descriptionAddPrompt.AutoSize = true;
            this.descriptionAddPrompt.ForeColor = System.Drawing.Color.Red;
            this.descriptionAddPrompt.Location = new System.Drawing.Point(230, 80);
            this.descriptionAddPrompt.Name = "descriptionAddPrompt";
            this.descriptionAddPrompt.Size = new System.Drawing.Size(0, 13);
            this.descriptionAddPrompt.TabIndex = 9;
            this.descriptionAddPrompt.Visible = false;
            // 
            // descriptionAddTextBox
            // 
            this.descriptionAddTextBox.Location = new System.Drawing.Point(230, 50);
            this.descriptionAddTextBox.Name = "descriptionAddTextBox";
            this.descriptionAddTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionAddTextBox.TabIndex = 4;
            // 
            // descriptionInputLabel
            // 
            this.descriptionInputLabel.AutoSize = true;
            this.descriptionInputLabel.Location = new System.Drawing.Point(125, 50);
            this.descriptionInputLabel.Name = "descriptionInputLabel";
            this.descriptionInputLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionInputLabel.TabIndex = 0;
            this.descriptionInputLabel.Text = "Description:";
            // 
            // updateEquipmentPanel
            // 
            this.updateEquipmentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateEquipmentPanel.Controls.Add(this.updateCancelButton);
            this.updateEquipmentPanel.Controls.Add(this.saveUpdateButton);
            this.updateEquipmentPanel.Controls.Add(this.label1);
            this.updateEquipmentPanel.Controls.Add(this.descriptionUpdatePrompt);
            this.updateEquipmentPanel.Controls.Add(this.descriptionUpdateTextBox);
            this.updateEquipmentPanel.Controls.Add(this.label3);
            this.updateEquipmentPanel.Location = new System.Drawing.Point(205, 50);
            this.updateEquipmentPanel.Name = "updateEquipmentPanel";
            this.updateEquipmentPanel.Size = new System.Drawing.Size(575, 171);
            this.updateEquipmentPanel.TabIndex = 66;
            this.updateEquipmentPanel.Visible = false;
            // 
            // updateCancelButton
            // 
            this.updateCancelButton.Location = new System.Drawing.Point(286, 107);
            this.updateCancelButton.Name = "updateCancelButton";
            this.updateCancelButton.Size = new System.Drawing.Size(150, 25);
            this.updateCancelButton.TabIndex = 39;
            this.updateCancelButton.Text = "Cancel";
            this.updateCancelButton.UseVisualStyleBackColor = true;
            this.updateCancelButton.Click += new System.EventHandler(this.cancelUpdateButton_Click);
            // 
            // saveUpdateButton
            // 
            this.saveUpdateButton.Location = new System.Drawing.Point(118, 107);
            this.saveUpdateButton.Name = "saveUpdateButton";
            this.saveUpdateButton.Size = new System.Drawing.Size(150, 25);
            this.saveUpdateButton.TabIndex = 38;
            this.saveUpdateButton.Text = "Save Equipment";
            this.saveUpdateButton.UseVisualStyleBackColor = true;
            this.saveUpdateButton.Click += new System.EventHandler(this.saveUpdateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(230, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            this.label1.Visible = false;
            // 
            // descriptionUpdatePrompt
            // 
            this.descriptionUpdatePrompt.AutoSize = true;
            this.descriptionUpdatePrompt.ForeColor = System.Drawing.Color.Red;
            this.descriptionUpdatePrompt.Location = new System.Drawing.Point(230, 80);
            this.descriptionUpdatePrompt.Name = "descriptionUpdatePrompt";
            this.descriptionUpdatePrompt.Size = new System.Drawing.Size(0, 13);
            this.descriptionUpdatePrompt.TabIndex = 9;
            this.descriptionUpdatePrompt.Visible = false;
            // 
            // descriptionUpdateTextBox
            // 
            this.descriptionUpdateTextBox.Location = new System.Drawing.Point(230, 50);
            this.descriptionUpdateTextBox.Name = "descriptionUpdateTextBox";
            this.descriptionUpdateTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionUpdateTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description:";
            // 
            // EquipmentMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.addEquipmentPanel);
            this.Controls.Add(this.updateEquipmentPanel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.descriptionDisplayLabel);
            this.Controls.Add(this.deleteEquipmentButton);
            this.Controls.Add(this.updateEquipmentButton);
            this.Controls.Add(this.addEquipmentButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.equipmentIDDisplayLabel);
            this.Controls.Add(this.equipmentIDLabel);
            this.Controls.Add(this.equipmentListBox);
            this.Name = "EquipmentMaintenanceForm";
            this.Text = "Equipment Maintenance";
            this.addEquipmentPanel.ResumeLayout(false);
            this.addEquipmentPanel.PerformLayout();
            this.updateEquipmentPanel.ResumeLayout(false);
            this.updateEquipmentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label descriptionDisplayLabel;
        private System.Windows.Forms.Button deleteEquipmentButton;
        private System.Windows.Forms.Button updateEquipmentButton;
        private System.Windows.Forms.Button addEquipmentButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label equipmentIDDisplayLabel;
        private System.Windows.Forms.Label equipmentIDLabel;
        private System.Windows.Forms.ListBox equipmentListBox;
        private System.Windows.Forms.Panel addEquipmentPanel;
        private System.Windows.Forms.Button addCancelButton;
        private System.Windows.Forms.Button saveAddButton;
        private System.Windows.Forms.Label phoneNumberPrompt;
        private System.Windows.Forms.Label descriptionAddPrompt;
        private System.Windows.Forms.TextBox descriptionAddTextBox;
        private System.Windows.Forms.Label descriptionInputLabel;
        private System.Windows.Forms.Panel updateEquipmentPanel;
        private System.Windows.Forms.Button updateCancelButton;
        private System.Windows.Forms.Button saveUpdateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label descriptionUpdatePrompt;
        private System.Windows.Forms.TextBox descriptionUpdateTextBox;
        private System.Windows.Forms.Label label3;

    }
}