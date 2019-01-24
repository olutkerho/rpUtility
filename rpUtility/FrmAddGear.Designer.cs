namespace rpUtility {
    partial class FrmAddGear {
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbNick = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMagic = new System.Windows.Forms.CheckBox();
            this.cbCurse = new System.Windows.Forms.CheckBox();
            this.cbStolen = new System.Windows.Forms.CheckBox();
            this.tbStolen = new System.Windows.Forms.TextBox();
            this.lbStolen = new System.Windows.Forms.Label();
            this.tbCurse = new System.Windows.Forms.TextBox();
            this.lbCurse = new System.Windows.Forms.Label();
            this.tbMagic = new System.Windows.Forms.TextBox();
            this.lbMagic = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(98, 16);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(169, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbNick
            // 
            this.tbNick.Location = new System.Drawing.Point(98, 42);
            this.tbNick.Name = "tbNick";
            this.tbNick.Size = new System.Drawing.Size(169, 20);
            this.tbNick.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nickname";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(98, 94);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(169, 20);
            this.tbWeight.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Weight ( lb )";
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(98, 68);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(169, 20);
            this.tbValue.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Value ( silver )";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(98, 120);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(169, 20);
            this.tbAmount.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Amount";
            // 
            // cbMagic
            // 
            this.cbMagic.AutoSize = true;
            this.cbMagic.Location = new System.Drawing.Point(307, 18);
            this.cbMagic.Name = "cbMagic";
            this.cbMagic.Size = new System.Drawing.Size(63, 17);
            this.cbMagic.TabIndex = 5;
            this.cbMagic.Text = "Magical";
            this.cbMagic.UseVisualStyleBackColor = true;
            this.cbMagic.CheckedChanged += new System.EventHandler(this.cbMagic_CheckedChanged);
            this.cbMagic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_KeyDown);
            // 
            // cbCurse
            // 
            this.cbCurse.AutoSize = true;
            this.cbCurse.Location = new System.Drawing.Point(307, 44);
            this.cbCurse.Name = "cbCurse";
            this.cbCurse.Size = new System.Drawing.Size(59, 17);
            this.cbCurse.TabIndex = 6;
            this.cbCurse.Text = "Cursed";
            this.cbCurse.UseVisualStyleBackColor = true;
            this.cbCurse.CheckedChanged += new System.EventHandler(this.cbCurse_CheckedChanged);
            this.cbCurse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_KeyDown);
            // 
            // cbStolen
            // 
            this.cbStolen.AutoSize = true;
            this.cbStolen.Location = new System.Drawing.Point(307, 70);
            this.cbStolen.Name = "cbStolen";
            this.cbStolen.Size = new System.Drawing.Size(56, 17);
            this.cbStolen.TabIndex = 7;
            this.cbStolen.Text = "Stolen";
            this.cbStolen.UseVisualStyleBackColor = true;
            this.cbStolen.CheckedChanged += new System.EventHandler(this.cbStolen_CheckedChanged);
            this.cbStolen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_KeyDown);
            // 
            // tbStolen
            // 
            this.tbStolen.Location = new System.Drawing.Point(98, 198);
            this.tbStolen.Name = "tbStolen";
            this.tbStolen.Size = new System.Drawing.Size(169, 20);
            this.tbStolen.TabIndex = 10;
            // 
            // lbStolen
            // 
            this.lbStolen.AutoSize = true;
            this.lbStolen.Location = new System.Drawing.Point(12, 201);
            this.lbStolen.Name = "lbStolen";
            this.lbStolen.Size = new System.Drawing.Size(60, 13);
            this.lbStolen.TabIndex = 20;
            this.lbStolen.Text = "Stolen from";
            // 
            // tbCurse
            // 
            this.tbCurse.Location = new System.Drawing.Point(98, 172);
            this.tbCurse.Name = "tbCurse";
            this.tbCurse.Size = new System.Drawing.Size(169, 20);
            this.tbCurse.TabIndex = 9;
            // 
            // lbCurse
            // 
            this.lbCurse.AutoSize = true;
            this.lbCurse.Location = new System.Drawing.Point(12, 175);
            this.lbCurse.Name = "lbCurse";
            this.lbCurse.Size = new System.Drawing.Size(63, 13);
            this.lbCurse.TabIndex = 19;
            this.lbCurse.Text = "Curse desc.";
            // 
            // tbMagic
            // 
            this.tbMagic.Location = new System.Drawing.Point(98, 146);
            this.tbMagic.Name = "tbMagic";
            this.tbMagic.Size = new System.Drawing.Size(169, 20);
            this.tbMagic.TabIndex = 8;
            // 
            // lbMagic
            // 
            this.lbMagic.AutoSize = true;
            this.lbMagic.Location = new System.Drawing.Point(12, 149);
            this.lbMagic.Name = "lbMagic";
            this.lbMagic.Size = new System.Drawing.Size(65, 13);
            this.lbMagic.TabIndex = 18;
            this.lbMagic.Text = "Magic desc.";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(98, 234);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(192, 234);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmAddGear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 269);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbStolen);
            this.Controls.Add(this.lbStolen);
            this.Controls.Add(this.tbCurse);
            this.Controls.Add(this.lbCurse);
            this.Controls.Add(this.tbMagic);
            this.Controls.Add(this.lbMagic);
            this.Controls.Add(this.cbStolen);
            this.Controls.Add(this.cbCurse);
            this.Controls.Add(this.cbMagic);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddGear";
            this.Text = "FrmAddGear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbNick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbMagic;
        private System.Windows.Forms.CheckBox cbCurse;
        private System.Windows.Forms.CheckBox cbStolen;
        private System.Windows.Forms.TextBox tbStolen;
        private System.Windows.Forms.Label lbStolen;
        private System.Windows.Forms.TextBox tbCurse;
        private System.Windows.Forms.Label lbCurse;
        private System.Windows.Forms.TextBox tbMagic;
        private System.Windows.Forms.Label lbMagic;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
    }
}