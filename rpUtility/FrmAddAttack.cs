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
    public partial class FrmAddAttack : Form
    {
        List<Attack> list;
        Attack att;


        bool isNew;

        public FrmAddAttack(List<Attack> AtkList)
        {
            InitializeComponent();
            list = AtkList;
            isNew = true;
        }

        public FrmAddAttack(Attack Atk)
        {
            isNew = false;

            InitializeComponent();

            tbName.Text = Atk.getName();
            tbHitBonus.Text = Atk.getHitBonus().ToString();
            tbDamage.Text = Atk.getDamage();
            tbDamageType.Text = Atk.getDamageType();
            tbRange.Text = Atk.getRange().ToString();
        }

        private void modifyAtk(Attack att)
        {
            att.setName(tbName.Text);
            att.setHitBonus(int.Parse(tbHitBonus.Text));
            att.setDamage(tbHitBonus.Text);
            att.setDamageType(tbDamageType.Text);
            att.setRange(int.Parse(tbRange.Text));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                att = new Attack();
                modifyAtk(att);
                list.Add(att);
            }
            else
            {
                modifyAtk(att);
            }
            
            Close();
        }
    }
}
