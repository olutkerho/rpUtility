using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpUtility {
    public class Location{
        private string Name;
        private string CountryName;
        private int Population;
        private int SoldierCount;
        private bool HasWalls;
        private bool HasTavern;
        private bool HasBlacksmith;
        private bool HasAlchemist;
        private bool HasGeneralStore;
        private bool HasTemple;
        private bool HasPalace;
        private bool HasCastle;
        private bool HasInn;
        private bool HasStables;
        private string LeaderName;

        public Location(){
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

        public void setCountryName(string countryname) {
            CountryName = countryname;
        }

        public string getCountryName() {
            string ret = "";
            if (CountryName != null) {
                ret = CountryName;
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

        public void setSoldierCount(int soldiercount) {
            SoldierCount = soldiercount;
        }

        public int getSoldierCount() {
            int ret = -1;
            if (SoldierCount != -1) {
                ret = SoldierCount;
            }
            return ret;
        }

        public void setHasWalls(bool haswalls) {
            HasWalls = haswalls;
        }

        public bool getHasWalls() {
            return HasWalls;
        }

        public void setHasTavern(bool hastavern) {
            HasTavern = hastavern;
        }

        public bool getHasTavern() {
            return HasTavern;
        }

        public void setHasBlacksmith(bool hasblacksmith) {
            HasBlacksmith = hasblacksmith;
        }

        public bool getHasBlacksmith() {
            return HasBlacksmith;
        }

        public void setHasAlchemist(bool hasalchemist) {
            HasAlchemist = hasalchemist;
        }

        public bool getHasAlchemist() {
            return HasAlchemist;
        }

        public void setHasGeneralStroe(bool hasgeneralstore) {
            HasGeneralStore = hasgeneralstore;
        }

        public bool getHasGeneralStore() {
            return HasGeneralStore;
        }

        public void setHasTemple(bool hastemple) {
            HasTemple = hastemple;
        }

        public bool getHasTemple() {
            return HasTemple;
        }

        public void setHasPalace(bool haspalace) {
            HasPalace = haspalace;
        }

        public bool getHasPalace() {
            return HasPalace;
        }

        public void setHasCastle(bool hascastle) {
            HasCastle = hascastle;
        }

        public bool getHasCastle() {
            return HasCastle;
        }

        public void setHasInn(bool hasinn) {
            HasInn = hasinn;
        }

        public bool getHasInn() {
            return HasInn;
        }

        public void setHasStables(bool hasstables) {
            HasStables = hasstables;
        }

        public bool getHasStables() {
            return HasStables;
        }
    }
}
