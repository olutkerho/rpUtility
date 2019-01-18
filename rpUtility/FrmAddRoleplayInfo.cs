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
    public partial class FrmAddRoleplayInfo : Form {
        public FrmAddRoleplayInfo() {
            InitializeComponent();
        }

        private static RoleplayInfo rp = new RoleplayInfo();

        private void FrmAddRoleplayInfo_FormClosing(object sender, FormClosingEventArgs e) {
            rp.setVoiceType(tbVoiceType.Text);
            rp.setTalkSpeed(tbTalkSpeed.Text);
            rp.setGestures(tbGestures.Text);
            rp.setAccent(tbAccent.Text);
        }

        public static RoleplayInfo getRoleplayInfo() {
            return rp;
        }
    }
}
