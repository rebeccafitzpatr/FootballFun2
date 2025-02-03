namespace FootballFun2.Models
{
	public class Player
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public string ImageUrl { get; set; }

		public string Position { get; set; }

		public List<TeamPlayer> TeamPlayers { get; set; }
	}
}
