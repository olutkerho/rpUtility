using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpUtility
{
    public partial class FrmStats : Form
    {
        public FrmStats()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            NPC npc = new NPC();
            npc.setFirstName(tbFirstName.Text);
            npc.setLastName(tbLastName.Text);
            npc.setAge(int.Parse(mtbAge.Text));
            npc.setRace(tbRace.Text);
            npc.setAlignment(tbAlignment.Text);
            npc.setSex(tbSex.Text);
            npc.setLevel(int.Parse(mtbLevel.Text));
            Stats stats = new Stats();
            stats.setStrength(int.Parse(mtbSrength.Text));
            stats.setDexterity(int.Parse(mtbDexterity.Text));
            stats.setConstitution(int.Parse(mtbConstitution.Text));
            stats.setIntelligence(int.Parse(mtbIntelligence.Text));
            stats.setWisdom(int.Parse(mtbWisdom.Text));
            stats.setCharisma(int.Parse(mtbCharisma.Text));
            stats.setArmorClass(int.Parse(mtbArmorClass.Text));
            stats.setSpeed(int.Parse(mtbSpeed.Text));
            stats.setHpMax(int.Parse(mtbHpMax.Text));
            stats.setHpCurrent(stats.getHpMax());
            stats.setHpTemp(0);
            stats.setProficiencyBonus(int.Parse(mtbProficiencyBonus.Text));
            stats.setStrengthMod();
            stats.setDexterityMod();
            stats.setConstitutionMod();
            stats.setIntelligenceMod();
            stats.setWisdomMod();
            stats.setCharismaMod();
            npc.setStats(stats);

            MessageBox.Show("lisätty");
            Binary.addNPC(npc);
            Binary.saveLists();
        }
    }
}
