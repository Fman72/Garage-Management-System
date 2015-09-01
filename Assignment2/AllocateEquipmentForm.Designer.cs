namespace Assignment2
{
    partial class AllocateEquipmentForm
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
            this.removeEquipmentButton = new System.Windows.Forms.Button();
            this.allocateEquipmentButton = new System.Windows.Forms.Button();
            this.serviceTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.equipmentDataGridView = new System.Windows.Forms.DataGridView();
            this.serviceTypeEquipmentDataGridView = new System.Windows.Forms.DataGridView();
            this.previousServiceTypeButton = new System.Windows.Forms.Button();
            this.nextServiceTypeButton = new System.Windows.Forms.Button();
            this.previousEquipmentButton = new System.Windows.Forms.Button();
            this.nextEquipmentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTypeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTypeEquipmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(630, 536);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(150, 25);
            this.returnButton.TabIndex = 15;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // removeEquipmentButton
            // 
            this.removeEquipmentButton.Location = new System.Drawing.Point(271, 398);
            this.removeEquipmentButton.Name = "removeEquipmentButton";
            this.removeEquipmentButton.Size = new System.Drawing.Size(103, 47);
            this.removeEquipmentButton.TabIndex = 14;
            this.removeEquipmentButton.Text = "Remove Equipment";
            this.removeEquipmentButton.UseVisualStyleBackColor = true;
            this.removeEquipmentButton.Click += new System.EventHandler(this.removeEquipmentButton_Click);
            // 
            // allocateEquipmentButton
            // 
            this.allocateEquipmentButton.Location = new System.Drawing.Point(271, 295);
            this.allocateEquipmentButton.Name = "allocateEquipmentButton";
            this.allocateEquipmentButton.Size = new System.Drawing.Size(103, 53);
            this.allocateEquipmentButton.TabIndex = 11;
            this.allocateEquipmentButton.Text = "Allocate Equipment";
            this.allocateEquipmentButton.UseVisualStyleBackColor = true;
            this.allocateEquipmentButton.Click += new System.EventHandler(this.allocateEquipmentButton_Click);
            // 
            // serviceTypeDataGridView
            // 
            this.serviceTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceTypeDataGridView.Location = new System.Drawing.Point(438, 295);
            this.serviceTypeDataGridView.MultiSelect = false;
            this.serviceTypeDataGridView.Name = "serviceTypeDataGridView";
            this.serviceTypeDataGridView.ReadOnly = true;
            this.serviceTypeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.serviceTypeDataGridView.Size = new System.Drawing.Size(325, 150);
            this.serviceTypeDataGridView.TabIndex = 10;
            // 
            // equipmentDataGridView
            // 
            this.equipmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipmentDataGridView.Location = new System.Drawing.Point(39, 30);
            this.equipmentDataGridView.MultiSelect = false;
            this.equipmentDataGridView.Name = "equipmentDataGridView";
            this.equipmentDataGridView.ReadOnly = true;
            this.equipmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.equipmentDataGridView.Size = new System.Drawing.Size(293, 150);
            this.equipmentDataGridView.TabIndex = 9;
            // 
            // serviceEquipmentDataGridView
            // 
            this.serviceTypeEquipmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceTypeEquipmentDataGridView.Location = new System.Drawing.Point(39, 296);
            this.serviceTypeEquipmentDataGridView.MultiSelect = false;
            this.serviceTypeEquipmentDataGridView.Name = "serviceEquipmentDataGridView";
            this.serviceTypeEquipmentDataGridView.ReadOnly = true;
            this.serviceTypeEquipmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.serviceTypeEquipmentDataGridView.Size = new System.Drawing.Size(203, 189);
            this.serviceTypeEquipmentDataGridView.TabIndex = 8;
            // 
            // previousServiceTypeButton
            // 
            this.previousServiceTypeButton.Location = new System.Drawing.Point(438, 460);
            this.previousServiceTypeButton.Name = "previousServiceTypeButton";
            this.previousServiceTypeButton.Size = new System.Drawing.Size(90, 25);
            this.previousServiceTypeButton.TabIndex = 58;
            this.previousServiceTypeButton.Text = "Previous";
            this.previousServiceTypeButton.UseVisualStyleBackColor = true;
            this.previousServiceTypeButton.Click += new System.EventHandler(this.previousServiceTypeButton_Click);
            // 
            // nextServiceTypeButton
            // 
            this.nextServiceTypeButton.Location = new System.Drawing.Point(673, 460);
            this.nextServiceTypeButton.Name = "nextServiceTypeButton";
            this.nextServiceTypeButton.Size = new System.Drawing.Size(90, 25);
            this.nextServiceTypeButton.TabIndex = 57;
            this.nextServiceTypeButton.Text = "Next";
            this.nextServiceTypeButton.UseVisualStyleBackColor = true;
            this.nextServiceTypeButton.Click += new System.EventHandler(this.nextServiceTypeButton_Click);
            // 
            // previousEquipmentButton
            // 
            this.previousEquipmentButton.Location = new System.Drawing.Point(39, 195);
            this.previousEquipmentButton.Name = "previousEquipmentButton";
            this.previousEquipmentButton.Size = new System.Drawing.Size(90, 25);
            this.previousEquipmentButton.TabIndex = 60;
            this.previousEquipmentButton.Text = "Previous";
            this.previousEquipmentButton.UseVisualStyleBackColor = true;
            this.previousEquipmentButton.Click += new System.EventHandler(this.previousEquipmentButton_Click);
            // 
            // nextEquipmentButton
            // 
            this.nextEquipmentButton.Location = new System.Drawing.Point(242, 195);
            this.nextEquipmentButton.Name = "nextEquipmentButton";
            this.nextEquipmentButton.Size = new System.Drawing.Size(90, 25);
            this.nextEquipmentButton.TabIndex = 59;
            this.nextEquipmentButton.Text = "Next";
            this.nextEquipmentButton.UseVisualStyleBackColor = true;
            this.nextEquipmentButton.Click += new System.EventHandler(this.nextEquipmentButton_Click);
            // 
            // AllocateEquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.previousEquipmentButton);
            this.Controls.Add(this.nextEquipmentButton);
            this.Controls.Add(this.previousServiceTypeButton);
            this.Controls.Add(this.nextServiceTypeButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.removeEquipmentButton);
            this.Controls.Add(this.allocateEquipmentButton);
            this.Controls.Add(this.serviceTypeDataGridView);
            this.Controls.Add(this.equipmentDataGridView);
            this.Controls.Add(this.serviceTypeEquipmentDataGridView);
            this.Name = "AllocateEquipmentForm";
            this.Text = "Allocate Equipment";
            ((System.ComponentModel.ISupportInitialize)(this.serviceTypeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTypeEquipmentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button removeEquipmentButton;
        private System.Windows.Forms.Button allocateEquipmentButton;
        private System.Windows.Forms.DataGridView serviceTypeDataGridView;
        private System.Windows.Forms.DataGridView equipmentDataGridView;
        private System.Windows.Forms.DataGridView serviceTypeEquipmentDataGridView;
        private System.Windows.Forms.Button previousServiceTypeButton;
        private System.Windows.Forms.Button nextServiceTypeButton;
        private System.Windows.Forms.Button previousEquipmentButton;
        private System.Windows.Forms.Button nextEquipmentButton;
    }
}