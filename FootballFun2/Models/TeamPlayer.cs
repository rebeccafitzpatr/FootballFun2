﻿namespace FootballFun2.Models
{
	public class TeamPlayer
	{

		public int TeamId { get; set; }
		public int PlayerId { get; set; }
		public Team Team { get; set; }
		public Player Player { get; set; }
	}
}
