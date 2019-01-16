﻿using System;

namespace rpUtility {
    public class Attack {
        private string Name;
        private int HitBonus;
        private string Damage;
        private string DamageType;
        private string Range;

        public Attack() {
        }

        public void setHitBonus(int hitbonus) {
            HitBonus = hitbonus;
        }

        public int getHitBonus() {
            return HitBonus;
        }

        public void setName(string name) {
            Name = name;
        }

        public string getName() {
            string ret = "";
            if(Name != null) {
                ret = Name;
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

        public void setDamageType(string damagetype) {
            DamageType = damagetype;
        }

        public string getDamageType() {
            string ret = "";
            if (DamageType != null) {
                ret = DamageType;
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
    } 
}
