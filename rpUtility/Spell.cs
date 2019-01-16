using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpUtility {
    public class Spell {
        private int Level;
        private string School;
        private List<string> Components;
        private string CastTime;
        private string Range;
        private string Duration;
        private string Damage;

        public Spell() {
            Components = new List<string>();
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
                    //Messagebox
                }
            }
        }
    }

}