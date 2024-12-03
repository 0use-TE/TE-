using MudBlazor;
using MudBlazorWebApp.Data;

namespace MudBlazorWebApp.Models
{
	public  static class Settings
	{
		public static string URL=null!;
		public static string diaryImageSrc2024 = "Images/Diary/2024/";
		public static string diaryImageSrc2025 = "Images/Diary/2024/";
		public static string diaryImageSrc2026 = "Images/Diary/2024/";
		public static string diaryImageSrc2027 = "Images/Diary/2024/";
		public static DateRange? DateRange { get; set; }
		public static Diary SelectedDiary { get; set; }=DiaryData.AllDiaries.First();
	}
}
