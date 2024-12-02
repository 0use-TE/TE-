using MudBlazorWebApp.Models;

namespace MudBlazorWebApp.Data
{
	public static class DiaryData
	{
		#region 2024-12
		public static List<Diary> diary2024Y12M = new List<Diary>()
	{
		new Diary("小刺猬养成指南(一)", DiaryType.Animal, WeatherType.Sunny, new DateTime(2024, 12, 1)),
	};
		#endregion

		#region 2025-1
		public static List<Diary> diary2025Y1M = new List<Diary>()
		{
			// 添加日记
		};
		#endregion

		#region 2025-2
		public static List<Diary> diary2025Y2M = new List<Diary>()
		{
			// 添加日记
		};
		#endregion

		#region 2025-3
		public static List<Diary> diary2025Y3M = new List<Diary>()
		{
			// 添加日记
		};
		#endregion
		#region  所有日记
		public static List<Diary> AllDiaries
		{
			get
			{
				return diary2024Y12M
					.Concat(diary2025Y1M)
					.Concat(diary2025Y2M)
					.Concat(diary2025Y3M)
					.ToList();
			}
		}
		#endregion
	}

}
