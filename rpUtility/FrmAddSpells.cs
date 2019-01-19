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
        }

        Stats Stats;
        List<Spell> Spells = new List<Spell>();

        private void RefreshSpells() {
            flpSpells.Controls.Clear();
            foreach (Spell s in Spells) {
                Label lb = new Label();
                lb.Size = new Size(150, 15);
                lb.Margin = new Padding(0, 3, 0, 3);
                lb.TextAlign = ContentAlignment.TopLeft;
                lb.ForeColor = Color.Black;
                lb.Text = s.getName() + ", " + s.getLevel();
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

        private void btnAdd_Click(object sender, EventArgs e) {
            bool pass = true;
            if (tbName.Text == "" || tbName.Text == null) {
                MessageBox.Show("Name can't be empty");
                pass = false;
            }

            bool school = true;
            if (tbSchool.Text == "" || tbSchool.Text == null) {
                MessageBox.Show("School can't be empty");
                pass = false;
            }

            bool level = true;
            if (tbLevel.Text == "" || tbLevel.Text == null) {
                MessageBox.Show("Level can't be empty");
                pass = false;
            }
            else if (int.TryParse(tbLevel.Text, out int l)) {
                MessageBox.Show("Type only numbers for level");
                pass = false;
            }
            else if (l < 0) {
                MessageBox.Show("Level can't be below 0");
                pass = false;
            }

            bool damage = true;
            if (tbDamage.Text == "" || tbDamage.Text == null) {
                MessageBox.Show("Damabe can't be empty");
                pass = false;
            }

            bool casttime = true;
            if (tbCastTime.Text == "" || tbCastTime.Text == null) {
                MessageBox.Show("Cast time can't be empty");
                pass = false;
            }

            bool duration = true;
            if (tbDuration.Text == "" || tbDuration.Text == null) {
                MessageBox.Show("Duration can't be empty");
                pass = false;
            }

            bool range = true;
            if (tbRange.Text == "" || tbRange.Text == null) {
                MessageBox.Show("Range can't be empty");
                pass = false;
            }
        }
    }
}
