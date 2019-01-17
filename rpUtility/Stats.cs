using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpUtility {
    [Serializable]
    public class Stats {
        private int Strength;
        private int Dexterity;
        private int Constitution;
        private int Intelligence;
        private int Wisdom;
        private int Charisma;
        private int ProficiencyBonus;
        private int ArmorClass;
        private int Speed;
        private int HpMax;
        private int HpCurrent;
        private int HpTemp;
        private List<string> Traits;
        private List<string> Proficiencies;
        private List<Spell> Spells;
        private List<Attack> Attacks;
        private List<Skill> Skills;
        private List<SpellSlot> SpellSlots;

        private int StrengthMod;
        private int DexterityMod;
        private int ConstitutionMod;
        private int IntelligenceMod;
        private int WisdomMod;
        private int CharismaMod;
        private int PassivePerception;

        public Stats() {
            Traits = new List<string>();
            Proficiencies = new List<string>();
            Spells = new List<Spell>();
            Attacks = new List<Attack>();
            SpellSlots = new List<SpellSlot>();
            Skills = new List<Skill>();
        }

        public void setStrength(int strength) {
            Strength = strength;
        }

        public int getStrength() {
            int ret = -1;
            if (Strength != -1) {
                ret = Strength;
            }
            return ret;
        }

        public void setDexterity(int dexterity) {
            Dexterity = dexterity;
        }

        public int getDexterity() {
            int ret = -1;
            if (Dexterity != -1) {
                ret = Dexterity;
            }
            return ret;
        }

        public void setConstitution(int constitution) {
            Constitution = constitution;
        }

        public int getConstitution() {
            int ret = -1;
            if (Constitution != -1) {
                ret = Constitution;
            }
            return ret;
        }

        public void setIntelligence(int intelligence) {
            Intelligence = intelligence;
        }

        public int getIntelligence() {
            int ret = -1;
            if (Intelligence != -1) {
                ret = Intelligence;
            }
            return ret;
        }

        public void setWisdom(int wisdom) {
            Wisdom = wisdom;
        }

        public int getWisdom() {
            int ret = -1;
            if (Wisdom != -1) {
                ret = Wisdom;
            }
            return ret;
        }

        public void setCharisma(int charisma) {
            Charisma = charisma;
        }

        public int getCharisma() {
            int ret = -1;
            if (Charisma != -1) {
                ret = Charisma;
            }
            return ret;
        }

        public void setProficiencyBonus(int proficiencybonus) {
            ProficiencyBonus = proficiencybonus;
        }

        public int getProficiencyBonus() {
            int ret = -1;
            if (ProficiencyBonus != -1) {
                ret = ProficiencyBonus;
            }
            return ret;
        }

        public void setArmorClass(int armorclass) {
            ArmorClass = armorclass;
        }

        public int getArmorClass() {
            int ret = -1;
            if (ArmorClass != -1) {
                ret = ArmorClass;
            }
            return ret;
        }

        public void setSpeed(int speed) {
            Speed = speed;
        }

        public int getSpeed() {
            int ret = -1;
            if (Speed != -1) {
                ret = Speed;
            }
            return ret;
        }

        public void setHpMax(int hpmax) {
            HpMax = hpmax;
        }

        public int getHpMax() {
            int ret = -1;
            if (HpMax != -1) {
                ret = HpMax;
            }
            return ret;
        }

        public void setHpCurrent(int hpcurrent) {
            HpCurrent = hpcurrent;
        }

        public int getHpCurrent() {
            int ret = -1;
            if (HpCurrent != -1) {
                ret = HpCurrent;
            }
            return ret;
        }

        public void setHpTemp(int hptemp) {
            HpTemp = hptemp;
        }

        public int getHpTemp() {
            int ret = -1;
            if (HpTemp != -1) {
                ret = HpTemp;
            }
            return ret;
        }

        public void setStrengthMod(){
            if (Strength != -1 && Strength != 0){
                StrengthMod = Strength / 2 - 5;
            }
        }

        public int getStrengthMod(){
            return StrengthMod;
        }

        public void setDexterityMod(){
            if (Dexterity != -1 && Dexterity != 0){
                DexterityMod = Dexterity/ 2 - 5;
            }
        }

        public int getDexterityMod(){
            return DexterityMod;
        }

        public void setConstitutionMod(){
            if (Constitution != -1 && Constitution!= 0){
                ConstitutionMod = Constitution/ 2 - 5;
            }
        }

        public int getConstitutionMod(){
            return ConstitutionMod;
        }

        public void setIntelligenceMod(){
            if (Intelligence != -1 && Intelligence!= 0){
                IntelligenceMod = Intelligence/ 2 - 5;
            }
        }

        public int getIntelligenceMod(){
            return IntelligenceMod;
        }

        public void setWisdomMod(){
            if (Wisdom != -1 && Wisdom!= 0){
                WisdomMod = Wisdom / 2 - 5;
            }
        }

        public int getWisdomMod(){
            return WisdomMod;
        }

        public void setCharismaMod(){
            if (Charisma != -1 && Charisma!= 0){
                CharismaMod= Charisma / 2 - 5;
            }
        }

        public int getCharismaMod(){
            return CharismaMod;
        }
    }

}