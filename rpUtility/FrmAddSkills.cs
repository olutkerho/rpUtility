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
    public partial class FrmAddSkills : Form {
        public FrmAddSkills() {
            InitializeComponent();
            RefreshSkills();
            RefreshComboBox();
            MainSkills = Binary.getMainSkills();
        }

        List<Skill> Skills;
        List<string> MainSkills;

        private void btnAddSkill_Click(object sender, EventArgs e) {
            if (tbName.Text != "" && MainSkills.Contains(cmbMainSkill.Text)) {
                bool pass = true;
                foreach (Skill s in Skills) {
                    if (s.getName().ToLower() == tbName.Text.ToLower()) {
                        pass = false;
                    }
                }
                if (pass) {
                    Skill skill = new Skill();
                    skill.setName(tbName.Text);
                    skill.setMainSkill(cmbMainSkill.Text);
                    Binary.addSkill(skill);
                    Binary.saveLists();
                    tbName.Select();
                    tbName.Clear();
                    RefreshSkills();
                }
                else {
                    MessageBox.Show("Skill on jo olemassa");
                }

            }
            else {
                MessageBox.Show("Et saa jättää tyhjää kenttää, sekä MainSkill täytyy olla listasta.");
            }
        }

        private void RefreshSkills() {
            Binary.sortSkills();
            Skills = Binary.CloneSkills();
            flpSkills.Controls.Clear();
            foreach (Skill s in Skills) {
                Label lb = new Label();
                lb.Size = new Size(150, 15);
                lb.Margin = new Padding(0, 3, 0, 3);
                lb.TextAlign = ContentAlignment.TopLeft;
                lb.ForeColor = Color.Black;
                lb.Text = s.getName() + ", " + s.getMainSkill();
                flpSkills.Controls.Add(lb);

                CheckBox cb = new CheckBox();
                cb.Size = new Size(15, 15);
                cb.Margin = new Padding(0, 3, 0, 3);
                cb.TextAlign = ContentAlignment.TopLeft;
                cb.ForeColor = Color.Black;
                cb.Tag = s.getName();
                flpSkills.Controls.Add(cb);
            }
        }

        private void tbMainSkill_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                e.Handled = true;
                btnAddSkill_Click(cmbMainSkill, e);
            }
        }

        private void btnDeleteSkills_Click(object sender, EventArgs e) {
            CheckBox cb = new CheckBox();
            List<Control> controls = new List<Control>();
            foreach (Control ct in flpSkills.Controls) {
                if (ct.GetType() == cb.GetType()) {
                    controls.Add(ct);
                    foreach (CheckBox c in controls) {
                        if (c.Checked) {
                            int i = Skills.FindIndex(skill => skill.getName() == ct.Tag.ToString());
                            Binary.removeSkill(i);
                            Skills = Binary.CloneSkills();
                        }
                    }
                    controls = new List<Control>();
                }
            }
            RefreshSkills();
        }

        private void button1_Click(object sender, EventArgs e) {
            FrmAddMainSkill frm = new FrmAddMainSkill();
            frm.ShowDialog();
        }

        public void RefreshComboBox() {
            cmbMainSkill.DataSource = null;
            cmbMainSkill.DataSource = Binary.getMainSkills();
        }

        private void FrmAddSkills_Enter(object sender, EventArgs e) {
            RefreshComboBox();
        }

        private void FrmAddSkills_Activated(object sender, EventArgs e) {
            RefreshComboBox();
        }

        private void tbName_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                e.Handled = true;
                btnAddSkill_Click(cmbMainSkill, e);
            }
        }
    }
}
