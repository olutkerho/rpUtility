namespace rpUtility
{
    partial class FrmAddAttack
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbHitBonus = new System.Windows.Forms.MaskedTextBox();
            this.tbDamageType = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbDamage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRange = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ATK Bonus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Damage Type";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(32, 59);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(140, 20);
            this.tbName.TabIndex = 3;
            // 
            // tbHitBonus
            // 
            this.tbHitBonus.Location = new System.Drawing.Point(181, 59);
            this.tbHitBonus.Mask = "00";
            this.tbHitBonus.Name = "tbHitBonus";
            this.tbHitBonus.PromptChar = ' ';
            this.tbHitBonus.Size = new System.Drawing.Size(58, 20);
            this.tbHitBonus.TabIndex = 4;
            // 
            // tbDamageType
            // 
            this.tbDamageType.Location = new System.Drawing.Point(182, 133);
            this.tbDamageType.Name = "tbDamageType";
            this.tbDamageType.Size = new System.Drawing.Size(140, 20);
            this.tbDamageType.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(182, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbDamage
            // 
            this.tbDamage.Location = new System.Drawing.Point(32, 133);
            this.tbDamage.Name = "tbDamage";
            this.tbDamage.Size = new System.Drawing.Size(140, 20);
            this.tbDamage.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Damage";
            // 
            // tbRange
            // 
            this.tbRange.Location = new System.Drawing.Point(248, 59);
            this.tbRange.Mask = "00";
            this.tbRange.Name = "tbRange";
            this.tbRange.PromptChar = ' ';
            this.tbRange.Size = new System.Drawing.Size(58, 20);
            this.tbRange.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Range";
            // 
            // FrmAddAttack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 208);
            this.Controls.Add(this.tbRange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDamage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbDamageType);
            this.Controls.Add(this.tbHitBonus);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddAttack";
            this.Text = "Add Attack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.MaskedTextBox tbHitBonus;
        private System.Windows.Forms.TextBox tbDamageType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbDamage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tbRange;
        private System.Windows.Forms.Label label5;
    }
}