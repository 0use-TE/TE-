namespace MudBlazorWebApp.Models
{
    public class Diary
    {
        public Diary(string title,DiaryType diaryType,WeatherType weatherType,DateTime dateTime)
        {

            this.Title = title;
            this.DiaryType = diaryType;
            this.WeatherType = weatherType;
            this.DateTime = dateTime;
            URL=dateTime.Year+"-"+dateTime.Month+"-"+dateTime.Day;
        }
        public Guid Guid { get; set; }=Guid.NewGuid();
        public string Title { get; set; } = null!;
        public string URL { get; set; } = null!;
        
        public DiaryType DiaryType { get; set; }
        public WeatherType WeatherType { get; set; }
        public DateTime DateTime { get; set; }
    }
}
