using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace rpUtility {
        public static class Binary {
        private static string NPCFile = Directory.GetCurrentDirectory() + "\\NPC.dat";
        private static string LocationFile = Directory.GetCurrentDirectory() + "\\Locations.dat";
        private static string AllianceFile = Directory.GetCurrentDirectory() + "\\Alliances.dat";
        private static List<Alliance> Alliances;
        private static List<NPC> NPCs;
        private static List<Location> Locations;

        public static void saveLists() {
            SerializeAlliance(Alliances);
            SerializeLocation(Locations);
            SerializeNPC(NPCs);
        }

        public static void addAlliance(Alliance alliance)
        {
            Alliances.Add(alliance);
        }

        public static void addNPC(NPC npc)
        {
            NPCs.Add(npc);
        }

        public static void addLocation(Location location)
        {
            Locations.Add(location);
        }

        public static void removeAlliance(Alliance alliance)
        {
            if (Alliances.Contains(alliance))
            {
                try
                {
                    Alliances.RemoveAt(Alliances.IndexOf(alliance));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void removeNPC(NPC npc)
        {
            if (NPCs.Contains(npc))
            {
                try
                {
                    NPCs.RemoveAt(NPCs.IndexOf(npc));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void removeLocation(Location location)
        {
            if (Locations.Contains(location))
            {
                try
                {
                    Locations.RemoveAt(Locations.IndexOf(location));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void createLists() {
            Alliances = new List<Alliance>();
            NPCs = new List<NPC>();
            Locations = new List<Location>();
        }

        public static void readAlliances() {
            Alliances = DeserializeAlliance();
            if (Alliances == null) {
                Alliances = new List<Alliance>();
            }
        }

        public static void readNPCs() {
            NPCs = DeserializeNPC();
            if (NPCs == null) {
                NPCs = new List<NPC>();
            }
        }

        public static void readLocations() {
            Locations = DeserializeLocation();
            if (Locations == null) {
                Locations = new List<Location>();
            }
        }

        public static List <NPC> DeserializeNPC() {
            if (System.IO.File.Exists(NPCFile)) {
                using (var file = System.IO.File.OpenRead(NPCFile)) {
                    var reader = new BinaryFormatter();
                    return (List<NPC>)reader.Deserialize(file);
                }
            }
            else {
                return null;
            }
        }

        public static void SerializeNPC(List <NPC> input) {
            using (var file = System.IO.File.OpenWrite(NPCFile)) {
                var writer = new BinaryFormatter();
                writer.Serialize(file, NPCs); 
            }
        }

        public static List<Location> DeserializeLocation() {
            if (System.IO.File.Exists(LocationFile)) {
                using (var file = System.IO.File.OpenRead(LocationFile)) {
                    var reader = new BinaryFormatter();
                    return (List<Location>)reader.Deserialize(file);
                }
            }
            else {
                return null;
            }
        }

        public static void SerializeLocation(List<Location> input) {
            using (var file = System.IO.File.OpenWrite(LocationFile)) {
                var writer = new BinaryFormatter();
                writer.Serialize(file, Locations);
            }
        }

        public static List<Alliance> DeserializeAlliance() {
            if (System.IO.File.Exists(AllianceFile)) {
                using (var file = System.IO.File.OpenRead(AllianceFile)) {
                    var reader = new BinaryFormatter();
                    return (List<Alliance>)reader.Deserialize(file);
                }
            }
            else {
                return null;
            }
        }

        public static void SerializeAlliance(List<Alliance> input) {
            using (var file = System.IO.File.OpenWrite(AllianceFile)) {
                var writer = new BinaryFormatter();
                writer.Serialize(file, Alliances);
            }
        }
    }
}
