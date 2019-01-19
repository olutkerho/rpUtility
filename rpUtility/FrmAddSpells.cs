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
    public partial class FrmAddSpells : Form {
        public FrmAddSpells(Stats stats) {
            InitializeComponent();
            Stats = stats;
            Spells = Stats.getSpells();
            RefreshSpells();
            cbMaterial_CheckedChanged(this, EventArgs.Empty);
        }

        Stats Stats;
        public List<Spell> Spells;

        private void RefreshSpells() {
            flpSpells.Controls.Clear();
            foreach (Spell s in Spells) {
                Label lb = new Label();
                lb.Size = new Size(150, 15);
                lb.Margin = new Padding(0, 3, 0, 3);
                lb.TextAlign = ContentAlignment.TopLeft;
                lb.ForeColor = Color.Black;
                lb.Text = s.getName();
                lb.MouseClick += new MouseEventHandler(lbSpell_MouseClick);
                lb.Leave += new EventHandler(lbSpell_Leave);
                flpSpells.Controls.Add(lb);

                CheckBox cb = new CheckBox();
                cb.Size = new Size(15, 15);
                cb.Margin = new Padding(0, 3, 0, 3);
                cb.TextAlign = ContentAlignment.TopLeft;
                cb.ForeColor = Color.Black;
                cb.Tag = s.getName();
                flpSpells.Controls.Add(cb);
            }
        }

        private void lbSpell_Leave(object sender, EventArgs e) {
            Label lb = (Label)sender;
            lb.ForeColor = Color.Black;
        }

        private void lbSpell_MouseClick(object sender, MouseEventArgs e) {
            Label lb = (Label)sender;
            lb.Select();
            lb.ForeColor = Color.Red;
            Spell spell = Spells.Find(s => s.getName() == lb.Text);
            if (spell != null) {
                tbCastTime.Text = spell.getCastTime();
                tbDamage.Text = spell.getDamage();
                tbDuration.Text = spell.getDuration();
                tbLevel.Text = spell.getLevel().ToString();
                tbName.Text = spell.getName();
                tbRange.Text = spell.getRange();
                tbSchool.Text = spell.getSchool();
                List<string> components = spell.getComponents();
                if (components.Contains("Verbal")) {
                    cbVerbal.Checked = true;
                }
                else {
                    cbVerbal.Checked = false;
                }
                if (components.Contains("Somatic")) {
                    cbSomatic.Checked = true;
                }
                else {
                    cbSomatic.Checked = false;
                }
                if (components.Contains("Material")) {
                    cbMaterial.Checked = true;
                    tbMaterials.Text = spell.getMaterial();
                }
                else {
                    cbMaterial.Checked = false;
                    tbMaterials.Clear();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            bool pass = true;
            bool newspell = true;
            int l = -1;
            if (tbName.Text == "" || tbName.Text == null) {
                MessageBox.Show("Name can't be empty");
                pass = false;
            }
            if (tbSchool.Text == "" || tbSchool.Text == null) {
                MessageBox.Show("School can't be empty");
                pass = false;
            }
            if (tbLevel.Text == "" || tbLevel.Text == null) {
                MessageBox.Show("Level can't be empty");
                pass = false;
            }
            else if (!int.TryParse(tbLevel.Text, out l)) {
                MessageBox.Show("Type only numbers for level");
                pass = false;
            }
            else if (l < 0) {
                MessageBox.Show("Level can't be below 0");
                pass = false;
            }
            if (tbDamage.Text == "" || tbDamage.Text == null) {
                MessageBox.Show("Damabe can't be empty");
                pass = false;
            }
            if (tbCastTime.Text == "" || tbCastTime.Text == null) {
                MessageBox.Show("Cast time can't be empty");
                pass = false;
            }
            if (tbDuration.Text == "" || tbDuration.Text == null) {
                MessageBox.Show("Duration can't be empty");
                pass = false;
            }
            if (tbRange.Text == "" || tbRange.Text == null) {
                MessageBox.Show("Range can't be empty");
                pass = false;
            }
            if (cbMaterial.Checked && (tbMaterials.Text == "" || tbMaterials.Text == null)) {
                pass = false;
            }
            if (pass) {
                Spell spell = new Spell();
                foreach (Spell s in Spells) {
                    if (s.getName().ToLower() == tbName.Text.ToLower()) {
                        spell = s;
                        newspell = false;
                    }
                }
                spell.setCastTime(tbCastTime.Text);
                spell.setDamage(tbDamage.Text);
                spell.setDuration(tbDuration.Text);
                spell.setLevel(l);
                spell.setName(tbName.Text);
                spell.setRange(tbRange.Text);
                spell.setSchool(tbSchool.Text);
                if (cbMaterial.Checked) {
                    spell.addComponent("Material");
                    spell.setMaterial(tbMaterials.Text);
                }
                if (cbSomatic.Checked) {
                    spell.addComponent("Somatic");
                }
                if (cbVerbal.Checked) {
                    spell.addComponent("Verbal");
                }
                if (newspell) {
                    Spells.Add(spell);
                }
                RefreshSpells();
            }
        }

        private void cbMaterial_CheckedChanged(object sender, EventArgs e) {
            if (cbMaterial.Checked) {
                lbMaterial.Visible = true;
                tbMaterials.Visible = true;
            }
            else {
                lbMaterial.Visible = false;
                tbMaterials.Visible = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            tbCastTime.Clear();
            tbDamage.Clear();
            tbDuration.Clear();
            tbLevel.Clear();
            tbMaterials.Clear();
            tbName.Clear();
            tbRange.Clear();
            tbSchool.Clear();
            cbVerbal.Checked = false;
            cbSomatic.Checked = false;
            cbMaterial.Checked = false;
            tbName.Select();
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            CheckBox cb = new CheckBox();
            List<Control> controls = new List<Control>();
            foreach (Control ct in flpSpells.Controls) {
                if (ct.GetType() == cb.GetType()) {
                    controls.Add(ct);
                    foreach (CheckBox c in controls) {
                        if (c.Checked) {
                            int i = Spells.FindIndex(s => s.getName() == ct.Tag.ToString());
                            Spells.RemoveAt(i);
                        }
                    }
                    controls = new List<Control>();
                }
            }
            RefreshSpells();
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

        private void FrmAddSpells_FormClosing(object sender, FormClosingEventArgs e) {
            Stats.setSpells(Spells);
        }
    }
}
