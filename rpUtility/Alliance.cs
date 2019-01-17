using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpUtility {
    public class Alliance {
        private string Name;
        private string HqLocation;
        private int Population;
        private string Wealth;
        private string LeaderName;
        private string Alignment;
        private string Origin;
        private int Age;
        private string Bio;
        private List<string> Goals;

        public Alliance() {
            Goals = new List<string>();
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

        public void setHqLocation(string hqlocation) {
            HqLocation = hqlocation;
        }

        public string getHqLocation() {
            string ret = "";
            if (HqLocation != null) {
                ret = HqLocation;
            }
            return ret;
        }

        public void setWealth(string wealth) {
            Wealth = wealth;
        }

        public string getWealth() {
            string ret = "";
            if (Wealth != null) {
                ret = Wealth;
            }
            return ret;
        }

        public void setLeaderName(string leadername) {
            LeaderName = leadername;
        }

        public string getLeaderName() {
            string ret = "";
            if (LeaderName != null) {
                ret = LeaderName;
            }
            return ret;
        }

        public void setAlignment(string alignment) {
            Alignment = alignment;
        }

        public string getAlignment() {
            string ret = "";
            if (Alignment != null) {
                ret = Alignment;
            }
            return ret;
        }

        public void setOrigin(string origin) {
            Origin = origin;
        }

        public string getOrigin() {
            string ret = "";
            if (Origin != null) {
                ret = Origin;
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

        public void setPopulation(int population) {
            Population = population;
        }

        public int getPopulation() {
            int ret = -1;
            if (Population != -1) {
                ret = Population;
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

        public void addGoal(string goal) {
            Goals.Add(goal);
        }

        public void removeGoal(string goal) {
            if (Goals.Contains(goal)) {
                try {
                    Goals.RemoveAt(Goals.IndexOf(goal));
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
