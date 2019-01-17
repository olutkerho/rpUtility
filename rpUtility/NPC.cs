using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpUtility {

     public class NPC{
        private string FirstName;
        private string LastName;
        private int Age;
        private string Alignment;
        private string Class;
        private int Level;
        private int Xp;
        private string Bio;
        private string Location;
        private List<Gear> GearList;
        private string Alliance;
        private Relations Relations;
        private Stats Stats;
        private List<string> Secrets;
        private List<string> Flaws;
        private List<string> Perks;
        private RoleplayInfo RoleplayInfo;
        private int Height; //Height in centimeters
        private int Weight; //Weight in kilograms
        private string SkinColour;
        private string Sex;
        private string Appearance;
        private string Race;



        public NPC(){
            GearList = new List<Gear>();
            Secrets = new List<string>();
            Flaws = new List<string>();
            Perks = new List<string>();
            Stats = new Stats();
        }

        public void setStats(Stats stats) {
            Stats = stats;
        }

        public Stats getStats() {
            Stats ret = new Stats();
            if (Stats != null) {
                ret = Stats;
            }
            return ret;
        }

        public void setRace(string race) {
            Race = race;
        }

        public string getRace() {
            string ret = "";
            if (Race != null) {
                ret = Race;
            }
            return ret;
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

        public void setLocation(string location) {
            Location = location;
        }

        public string getLocation() {
            string ret = "";
            if (Location != null) {
                ret = Location;
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

        public void setAlliance(string alliance) {
            Alliance = alliance;
        }

        public string getAlliance() {
            string ret = "";
            if (Alliance != null) {
                ret = Alliance;
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

        public void addSecret(string secret) {
            Secrets.Add(secret);
        }

        public void removeSecret(string secret) {
            if (Secrets.Contains(secret)) {
                try {
                    Secrets.RemoveAt(Secrets.IndexOf(secret));
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void addFlaw (string flaw) {
            Flaws.Add(flaw);
        }

        public void removeFlaw(string flaw) {
            if (Flaws.Contains(flaw)) {
                try {
                    Flaws.RemoveAt(Flaws.IndexOf(flaw));
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void addPerk(string perk) {
            Perks.Add(perk);
        }

        public void removePerk(string perk) {
            if (Perks.Contains(perk)) {
                try {
                    Perks.RemoveAt(Perks.IndexOf(perk));
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void setHeight(int height) {
            Height = height;
        }

        public int getHeight() {
            int ret = -1;
            if (Height != -1) {
                ret = Height;
            }
            return ret;
        }

        public void setWeight(int weight) {
            Weight = weight;
        }

        public int getWeight() {
            int ret = -1;
            if (Weight != -1) {
                ret = Weight;
            }
            return ret;
        }

        public void setAppearance(string appearance) {
            Appearance = appearance;
        }

        public string getAppearance() {
            string ret = "";
            if (Appearance != null) {
                ret = Appearance;
            }
            return ret;
        }

        public void setSex(string sex) {
            Sex = sex;
        }

        public string getSex() {
            string ret = "";
            if (Sex != null) {
                ret = Sex;
            }
            return ret;
        }

        public void setSkinColour(string skincolour) {
            SkinColour = skincolour;
        }

        public string getSkinColour() {
            string ret = "";
            if (SkinColour != null) {
                ret = SkinColour;
            }
            return ret;
        }
    }
}
