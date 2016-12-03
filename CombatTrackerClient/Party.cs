﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CombatTrackerServer.Models
{
	public class Party
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Category { get; set; }
		public bool Locked { get; set; }
		public int JoinedPlayers { get; set; }
		public int MaxPlayers { get; set; }
	}
}
