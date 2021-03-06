﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpUtility {
    [Serializable]
    public class Spell {
        private string Name;
        private int Level;
        private string School;
        private List<string> Components;
        private string Material;
        private string CastTime;
        private string Range;
        private string Duration;
        private string Damage;

        public Spell() {
            Components = new List<string>();
        }

        public void setMaterial(string material) {
            Material = material;
        }

        public string getMaterial() {
            string ret = "";
            if (Material != null) {
                ret = Material;
            }
            return ret;
        }

        public void setName(string name) {
            Name = name;
        }

        public string getName() {
            string ret = "";
            if (Name != null) {
                ret = Name;
            }
            return ret;
        }

        public void setLevel(int level) {
            Level = level;
        }

        public int getLevel() {
            int ret = -1;
            if (Level != -1) {
                ret = Level;
            }
            return ret;
        }

        public void setSchool(string school) {
            School = school;
        }

        public string getSchool() {
            string ret = "";
            if (School != null) {
                ret = School;
            }
            return ret;
        }

        public void setCastTime(string casttime) {
            CastTime = casttime;
        }

        public string getCastTime() {
            string ret = "";
            if (CastTime != null) {
                ret = CastTime;
            }
            return ret;
        }

        public void setRange(string range) {
            Range = range;
        }

        public string getRange() {
            string ret = "";
            if (Range != null) {
                ret = Range;
            }
            return ret;
        }

        public void setDuration(string duration) {
            Duration = duration;
        }

        public string getDuration() {
            string ret = "";
            if (Duration != null) {
                ret = Duration;
            }
            return ret;
        }

        public void setDamage(string damage) {
            Damage = damage;
        }

        public string getDamage() {
            string ret = "";
            if (Damage != null) {
                ret = Damage;
            }
            return ret;
        }

        public void addComponent(string component) {
            Components.Add(component);
        }

        public void removeComponent(string component) {
            if (Components.Contains(component)) {
                try {
                    Components.RemoveAt(Components.IndexOf(component));
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public List<string> getComponents() {
            List<string> ret = new List<string>();
            foreach (string s in Components) {
                if (s != "" && s != null) {
                    ret.Add(s);
                }
            }
            return ret;
        }
    }

}