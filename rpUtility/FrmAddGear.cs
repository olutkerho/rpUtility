using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpUtility {
    public partial class FrmAddGear : Form {
        public FrmAddGear(List<Gear> gearlist) {
            InitializeComponent();
            GearList = gearlist;
            cbMagic_CheckedChanged(cbMagic, EventArgs.Empty);
            cbCurse_CheckedChanged(cbCurse, EventArgs.Empty);
            cbStolen_CheckedChanged(cbStolen, EventArgs.Empty);
        }

        List<Gear> GearList;

        private void cbMagic_CheckedChanged(object sender, EventArgs e) {
            CheckBox temp = new CheckBox();
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked) {
                lbMagic.Visible = true;
                tbMagic.Visible = true;
            }
            else {
                lbMagic.Visible = false;
                tbMagic.Visible = false;
            }
        }

        private void cbCurse_CheckedChanged(object sender, EventArgs e) {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked) {
                lbCurse.Visible = true;
                tbCurse.Visible = true;
            }
            else {
                lbCurse.Visible = false;
                tbCurse.Visible = false;
            }
        }

        private void cbStolen_CheckedChanged(object sender, EventArgs e) {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked) {
                lbStolen.Visible = true;
                tbStolen.Visible = true;
            }
            else {
                lbStolen.Visible = false;
                tbStolen.Visible = false;
            }
        }

        private void cb_KeyDown(object sender, KeyEventArgs e) {
            CheckBox cb = (CheckBox)sender;
            if (e.KeyData == Keys.Enter) {
                if (cb.Checked) {
                    cb.Checked = false;
                }
                else {
                    cb.Checked = true;
                }
                ProcessTabKey(true);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            string Name = "", Nick = "", StolenFrom = "", MagicDesc = "", CurseDesc = "";
            int Value = 0, Weight = 0, Amount = 0;
            bool Stolen = false, Magical = false, Cursed = false;
            bool pass = true;
            if (tbName.Text != null && tbName.Text != "") {
                Name = tbName.Text;
            }
            else {
                pass = false;
                MessageBox.Show("You can't leave name empty");
            }
            if (tbNick.Text != null && tbNick.Text != "") {
                Nick = tbNick.Text;
            }
            if (tbValue.Text == null || tbValue.Text == "" || !int.TryParse(tbValue.Text, out Value)) {
                pass = false;
                MessageBox.Show("You can't leave value empty and you can only use numbers for value");
            }
            if (tbWeight.Text == null || tbWeight.Text == "" || !int.TryParse(tbWeight.Text, out Weight)) {
                pass = false;
                MessageBox.Show("You can't leave weight empty and you can only use numbers for weight");
            }
            if (tbAmount.Text == null || tbAmount.Text == "" || !int.TryParse(tbAmount.Text, out Amount)) {
                pass = false;
                MessageBox.Show("You can't leave amount empty and you can only use numbers for amount");
            }
            if (cbMagic.Checked) {
                if (tbMagic.Text != null && tbMagic.Text != "") {
                    Magical = true;
                    MagicDesc = tbMagic.Text;
                }
                else {
                    pass = false;
                    MessageBox.Show("You can't leave magic description empty");
                }
            }
            if (cbCurse.Checked) {
                if (tbCurse.Text != null && tbCurse.Text != "") {
                    Cursed = true;
                    CurseDesc = tbCurse.Text;
                }
                else {
                    pass = false;
                    MessageBox.Show("You can't leave curse description empty");
                }
            }
            if (cbStolen.Checked) {
                if (tbStolen.Text != null && tbStolen.Text != "") {
                    Stolen = true;
                    StolenFrom = tbStolen.Text;
                }
                else {
                    pass = false;
                    MessageBox.Show("You can't have a stolen item if it's not stolen from somebody");
                }
            }
                
            if (pass) {
                Gear g = new Gear(Name, Nick, Value, Weight, Amount, Stolen, StolenFrom, Magical, MagicDesc, Cursed, CurseDesc);
                GearList.Add(g);
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            tbName.Clear();
            tbNick.Clear();
            tbValue.Clear();
            tbWeight.Clear();
            tbAmount.Clear();
            tbMagic.Clear();
            tbCurse.Clear();
            tbStolen.Clear();
            cbMagic.Checked = false;
            cbCurse.Checked = false;
            cbStolen.Checked = false;
            tbName.Select();
        }
    }
}
