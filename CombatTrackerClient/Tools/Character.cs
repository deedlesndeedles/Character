using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatTrackerClient.Tools
{
    public class Character
    {
        private static string DEFAULT_NAME = "Unnamed Character";

        string id;
        public string ID
        {
            get
            {
                return id;
            }
            private set
            {
                id = value;
            }
        }

        string name = "";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                Save();
            }
        }

        string player = "";
        public string Player
        {
            get
            {
                return player;
            }
            set
            {
                player = value;
                Save();
            }
        }

        string campaign = "";
        public string Campaign
        {
            get
            {
                return campaign;
            }
            set
            {
                campaign = value;
                Save();
            }
        }

        public Character()
        {
            if (ID == null)
                ID = CharacterSerializer.GenerateID();
        }

        private void Save()
        {
            CharacterSerializer.AddCharacterToSerializationList(this);
            CharacterSerializer.Serialize();
        }
    }
}
