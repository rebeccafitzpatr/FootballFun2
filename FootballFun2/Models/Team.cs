namespace FootballFun2.Models
{
	public class Team
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string ImageUrl { get; set; }
		public string Manager { get; set; }

		public List<TeamPlayer> TeamPlayers { get; set; }
}
}
