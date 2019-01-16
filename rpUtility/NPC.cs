using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpUtility {

     class NPC{
        private string FirstName;
        private string LastName;
        private int Age;
        private string Alignment;
        private string Class;
        private int Level;
        private int Xp;
        private string Bio;
        private Location Location;
        private List<Gear> GearList;
        private Alliance Alliance;
        private Relations Relations;
        //stats
        //roleplay info

        public NPC(){

        }

        public void setFirstName(string firstname) {
            FirstName = firstname;
        }

        public string getFirstName() {
            string ret = "";
            if (FirstName != null) {
                ret = FirstName;
            }
            return ret;
        }

        public void setLastName (string lastname) {
            LastName = lastname;
        }

        public string getLastName() {
            string ret = "";
            if (LastName != null) {
                ret = LastName;
            }
            return ret;
        }

        public void setAge(int age) {
            Age = age;
        }

        public int getAge() {
            int ret = -1;
            if (Age != -1) {
                ret = Age;
            }
            return ret;
        }

        public void setAlignment(string alignment) {
            Alignment = alignment;
        }

        public string getAlignment() {
            string ret = "";
            if (Alignment!= null) {
                ret = Alignment;
            }
            return ret;
        }

        public void setClass(string CLASS) {
            Class = CLASS;
        }

        public string getClass() {
            string ret = "";
            if (Class != null) {
                ret = Class;
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

        public void setXp(int xp) {
            Xp = xp;
        }

        public int getXp() {
            int ret = -1;
            if (Xp != -1) {
                ret = Xp;
            }
            return ret;
        }

        public void setBio(string bio) {
            Bio = bio;
        }

        public string getBio() {
            string ret = "";
            if (Bio != null) {
                ret = Bio;
            }
            return ret;
        }
    }
}
