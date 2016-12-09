﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatTrackerClient.Tools
{
    public class Character
    {
        #region CharacterPage Values
        private static string DEFAULT_NAME = "Unnamed Character";

        string id;
        public string ID
        {
            get
            {
                return id;
            }
            set
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
                //Save();
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
                //Save();
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
                //Save();
            }
        }

        string portraitPath;
        public string Portraitpath
        {
            get
            {
                return portraitPath;
            }
            set
            {
                portraitPath = value;
                //Save();
            }
        }
        #endregion

        #region BasePage Values
        int level = 1;
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
                //Save();
            }
        }
        #endregion

        #region Party
        List<Character> party;
        public List<Character> Party
        {
            get
            {
                return party;
            }
            set
            {
                party = value;
            }
        }

        Character partyLeader;
        public Character PartyLeader
        {
            get
            {
                return partyLeader;
            }
            set
            {
                partyLeader = value;
            }
        }
        #endregion

        public Character(Character leader = null)
        {
            partyLeader = leader;
            if (partyLeader == null)
            {
                partyLeader = this;
                party = new List<Character>();
            }
        }

        /*private async Task<bool> Save()
        {
            //CharacterSerializer.AddCharacterToSerializationList(this);
            await CharacterSerializer.Serialize();

            return true;
        }*/
    }
}
