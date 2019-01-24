namespace rpUtility {
    partial class FrmInventory {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.flpGear = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddGear = new System.Windows.Forms.Button();
            this.btnAddContainer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpGear
            // 
            this.flpGear.Location = new System.Drawing.Point(12, 12);
            this.flpGear.Name = "flpGear";
            this.flpGear.Size = new System.Drawing.Size(530, 318);
            this.flpGear.TabIndex = 2;
            // 
            // btnAddGear
            // 
            this.btnAddGear.Location = new System.Drawing.Point(548, 336);
            this.btnAddGear.Name = "btnAddGear";
            this.btnAddGear.Size = new System.Drawing.Size(110, 23);
            this.btnAddGear.TabIndex = 1;
            this.btnAddGear.Text = "Add gear";
            this.btnAddGear.UseVisualStyleBackColor = true;
            this.btnAddGear.Click += new System.EventHandler(this.btnAddGear_Click);
            // 
            // btnAddContainer
            // 
            this.btnAddContainer.Location = new System.Drawing.Point(548, 307);
            this.btnAddContainer.Name = "btnAddContainer";
            this.btnAddContainer.Size = new System.Drawing.Size(110, 23);
            this.btnAddContainer.TabIndex = 3;
            this.btnAddContainer.Text = "Add container";
            this.btnAddContainer.UseVisualStyleBackColor = true;
            this.btnAddContainer.Click += new System.EventHandler(this.btnAddContainer_Click);
            // 
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(670, 371);
            this.Controls.Add(this.btnAddContainer);
            this.Controls.Add(this.flpGear);
            this.Controls.Add(this.btnAddGear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmInventory";
            this.Text = "FrmInventory";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpGear;
        private System.Windows.Forms.Button btnAddGear;
        private System.Windows.Forms.Button btnAddContainer;
    }
}