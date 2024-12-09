namespace MudBlazorWebApp.Models
{
    public class OpenSource
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ? Url { get; set; }
        public string Author {  get; set; } = null!;
        public DateTime StartTime { get; set; }
    }
}
