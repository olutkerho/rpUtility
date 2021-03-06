﻿using System;
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
    public partial class FrmMain : Form {
        public FrmMain() {
            InitializeComponent();
            Binary.createLists();
            Binary.readAlliances();
            Binary.readLocations();
            Binary.readNPCs();
            Binary.readSkills();
            Binary.readMainSkills();
            Binary.findNPC(0);
            Binary.setSpellLevels();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            Binary.saveLists();
        }

        private void btnOpenStats_Click(object sender, EventArgs e)
        {
            FrmCreateNPC frm = new FrmCreateNPC();
            frm.Show();
        }

        private void btnEditSkills_Click(object sender, EventArgs e) {
            FrmAddSkills frm = new FrmAddSkills();
            frm.ShowDialog();
        }
    }
}
