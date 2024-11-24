namespace MudBlazorWebApp.Models
{
	public class Game
	{
		public int Id { get; set; }
		public string Developers { get; set; } = "腾易工作室";
		public string? Tag {  get; set; }
        public string ?Name { get; set; }
		public string Brief { get; set; }
		public string downloadLink { get; set; } = null!;
        public string ?Context { get; set; }
		public List<string> PathList { get; set; } = new List<string>();
	}
}
