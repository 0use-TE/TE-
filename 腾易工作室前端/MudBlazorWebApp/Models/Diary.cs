namespace MudBlazorWebApp.Models
{
    public class Diary
    {
        public string Title { get; set; } = null!;
        
        public DiaryType DiaryType { get; set; }
        public WeatherType WeatherType { get; set; }
        public DateTime DateTime { get; set; }
    }
}
