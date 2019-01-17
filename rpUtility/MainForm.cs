using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace rpUtility {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            Binary.createLists();
            Binary.readAlliances();
            Binary.readLocations();
            Binary.readNPCs();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            Binary.saveLists();
        }

        private void btnOpenStats_Click(object sender, EventArgs e)
        {
            FrmStats frm = new FrmStats();
            frm.Show();
        }
    }
}
