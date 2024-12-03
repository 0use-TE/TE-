using MudBlazor;

namespace MudBlazorWebApp.Models
{
	public  static class Settings
	{
		public static string URL=null!;
		public static DateRange? DateRange { get; set; }
		public static Diary SelectedDiary { get; set; }=null!;
	}
}
