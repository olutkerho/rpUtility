namespace rpUtility {
    partial class FrmAddCargo {
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNick = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCapacity = new System.Windows.Forms.TextBox();
            this.cbAttachable = new System.Windows.Forms.CheckBox();
            this.cbCarried = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(111, 10);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(148, 20);
            this.tbName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nickname";
            // 
            // tbNick
            // 
            this.tbNick.Location = new System.Drawing.Point(111, 36);
            this.tbNick.Name = "tbNick";
            this.tbNick.Size = new System.Drawing.Size(148, 20);
            this.tbNick.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Capacity";
            // 
            // tbCapacity
            // 
            this.tbCapacity.Location = new System.Drawing.Point(111, 62);
            this.tbCapacity.Name = "tbCapacity";
            this.tbCapacity.Size = new System.Drawing.Size(148, 20);
            this.tbCapacity.TabIndex = 4;
            // 
            // cbAttachable
            // 
            this.cbAttachable.AutoSize = true;
            this.cbAttachable.Location = new System.Drawing.Point(309, 12);
            this.cbAttachable.Name = "cbAttachable";
            this.cbAttachable.Size = new System.Drawing.Size(77, 17);
            this.cbAttachable.TabIndex = 6;
            this.cbAttachable.Text = "Attachable";
            this.cbAttachable.UseVisualStyleBackColor = true;
            // 
            // cbCarried
            // 
            this.cbCarried.AutoSize = true;
            this.cbCarried.Location = new System.Drawing.Point(309, 38);
            this.cbCarried.Name = "cbCarried";
            this.cbCarried.Size = new System.Drawing.Size(59, 17);
            this.cbCarried.TabIndex = 7;
            this.cbCarried.Text = "Carried";
            this.cbCarried.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(111, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmAddCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 143);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbCarried);
            this.Controls.Add(this.cbAttachable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCapacity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Name = "FrmAddCargo";
            this.Text = "FrmAddCargo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCapacity;
        private System.Windows.Forms.CheckBox cbAttachable;
        private System.Windows.Forms.CheckBox cbCarried;
        private System.Windows.Forms.Button btnAdd;
    }
}