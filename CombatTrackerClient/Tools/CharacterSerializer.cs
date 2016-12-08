using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Windows.Data.Xml.Dom;
using Windows.Storage;

namespace CombatTrackerClient.Tools
{
    class CharacterSerializer
    {
        public static Dictionary<string, Character> characters = new Dictionary<string, Character>();
        public static Dictionary<string, Character> Characters
        {
            get
            {
                return characters;
            }
            set
            {
                characters = value;
            }
        }
        private static Character lastVisited;
        private static StorageFile file;
        private static string last = "last", filename = "chars.xml", xmltag = "Characters";
        public static int CURRENTindex = 0;

        public static void AddCharacterToSerializationList(Character character)
        {
            if (Characters.Count > 0 && Characters.ContainsKey(character.ID))
                Characters.Remove(character.ID);

            Characters.Add(character.ID, character);
        }

        public static void AddLastCharacterToSerializationList(Character character)
        {
            if (Characters.ContainsKey(last))
                Characters.Remove(last);

            Characters.Add(last, character);
        }

        public static void RemoveCharacterFromSerializationList(Character character)
        {
            if (Characters.Count > 0 && Characters.ContainsKey(character.ID))
            {
                Characters.Remove(character.ID);
                Serialize();
            }
        }

        static StorageFolder charFolder;
        public static StorageFolder CharFolder
        {
            set
            {
                charFolder = value;
            }
        }

        public static async Task<bool> Serialize()
        {
            string serializedString = JsonConvert.SerializeObject(Characters);

            if (serializedString.Length < 5)
                System.Diagnostics.Debug.WriteLine("WARNING!");
            
            for (int k = 0; k < CharacterSerializer.Characters.Count; k++)
                System.Diagnostics.Debug.WriteLine(CharacterSerializer.Characters.ElementAt(k).Key + " saved");
            
            XmlDocument characterDoc = new XmlDocument();

            string characterXml = "<" + xmltag + ">";
            characterXml += "<JSON>" + serializedString + "</JSON>";
            characterXml += "</" + xmltag + ">";

            characterDoc.LoadXml(characterXml);

            file = await charFolder.CreateFileAsync(filename, CreationCollisionOption.ReplaceExisting);

            await characterDoc.SaveToFileAsync(file);

            return true;
        }

        public static async Task<bool> Deserialize()
        {
            file = await charFolder.GetFileAsync(filename);

            XDocument doc = XDocument.Load(file.Path);

            string f = LoadFromXDocument(doc);

            Characters = JsonConvert.DeserializeObject<Dictionary<string, Character>>(f);


            for (int k = 0; k < CharacterSerializer.Characters.Count; k++)
            {
                System.Diagnostics.Debug.WriteLine(CharacterSerializer.Characters.ElementAt(k).Key + " loaded");
            }

            MainPage.CHARACTER = Characters.ElementAt(CURRENTindex).Value;

            return true;
        }

        private static string LoadFromXDocument(XDocument doc)
        {
            var data = from query in doc.Descendants(xmltag)
                       select new CharLoadData()
                       {
                           json = (string)query.Element("JSON")
                       };

            return data.ElementAt(0).json;
        }

        public static Character FindCharacterByID(string ID)
        {
            return Characters[ID];
        }

        public static int FindCharacterIndex(Character character)
        {
            for (int i = 0; i<Characters.Count; i++)
            {
                if (character == Characters.Values.ElementAt(i))
                    return i;
            }

            return -1;
        }

        public static string GenerateID()
        {
            Random r = new Random(), r2 = new Random();
            //string id = "0" + Math.Round(r.NextDouble() * 10000) + characters.Count + Math.Round(r2.NextDouble() * 100);
            string id = "0100" + Characters.Count;
            return id;
        }

        public struct CharLoadData
        {
            public string json;
        }
    }
}
