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
    public partial class FrmAddSpellslots : Form {
        public FrmAddSpellslots(Stats stats) {
            InitializeComponent();
            Stats = stats;
            SpellLevels = Binary.getSpellLevels();
            SpellSlot = new SpellSlot();
            SpellSlots = Stats.getSpellSlots();
            RefreshSpellLevels();
        }

        Stats Stats;
        List<int> SpellLevels;
        List<SpellSlot> SpellSlots;
        SpellSlot SpellSlot;

        private void RefreshSpellLevels() {
            flpSpellLevels.Controls.Clear();
            foreach (int i in SpellLevels) {
                Label lb = new Label();
                lb.Size = new Size(42, 13);
                lb.Text = "Level " + i.ToString();
                lb.Tag = i;
                flpSpellLevels.Controls.Add(lb);

                TextBox tb = new TextBox();
                tb.Size = new Size(100, 20);
                tb.Text = "0";
                tb.Tag = i;
                flpSpellLevels.Controls.Add(tb);
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            TextBox tb = new TextBox();
            int i;
            bool pass = true;
            foreach (Control c in flpSpellLevels.Controls) {
                if (c.GetType() == tb.GetType()) {
                    if (!int.TryParse(c.Text, out i)) {
                        pass = false;
                        SpellSlots = Stats.getSpellSlots();
                        break;
                    }
                    else {
                        SpellSlot = new SpellSlot();
                        SpellSlot.setLevel(int.Parse(c.Tag.ToString()));
                        SpellSlot.setAmount(i);
                        SpellSlots.Add(SpellSlot);
                    }
                }
            }
            if (!pass) {
                MessageBox.Show("Use only numbers in defining the amount of spellslots");
            }
            else {
                Stats.setSpellSlots(SpellSlots);
                this.Close();
            }
        }
    }
}
