namespace MudBlazorWebApp.Models
{
	public enum DiaryType
	{
		/// <summary>
		/// 无类型，表示日记没有明确的分类
		/// </summary>
		None,

		/// <summary>
		/// 编程相关的日记
		/// </summary>
		Program,

		/// <summary>
		/// 旅行相关的日记
		/// </summary>
		Travel,

		/// <summary>
		/// 个人生活或心情的日记
		/// </summary>
		Personal,

		/// <summary>
		/// 工作/职场相关的日记
		/// </summary>
		Work,

		/// <summary>
		/// 学习或课程相关的日记
		/// </summary>
		Study,

		/// <summary>
		/// 健康/运动相关的日记
		/// </summary>
		Health,
		/// <summary>
		/// 饲养动物有关的日记
		/// </summary>
		Animal,
		/// <summary>
		/// 其他类型的日记
		/// </summary>
		Other
	}

	public enum WeatherType
	{
		/// <summary>
		/// 晴天
		/// </summary>
		Sunny,

		/// <summary>
		/// 阴天
		/// </summary>
		Cloudy,

		/// <summary>
		/// 雨天
		/// </summary>
		Rainy,

		/// <summary>
		/// 雪天
		/// </summary>
		Snowy,

		/// <summary>
		/// 多云
		/// </summary>
		PartlyCloudy,

		/// <summary>
		/// 雷雨天
		/// </summary>
		Thunderstorm,

		/// <summary>
		/// 风大天气
		/// </summary>
		Windy,

		/// <summary>
		/// 大雾天气
		/// </summary>
		Foggy,

		/// <summary>
		/// 暴雨天气
		/// </summary>
		HeavyRain,

		/// <summary>
		/// 其他天气情况
		/// </summary>
		Other
	}

	public class Misc
    {

    }
}
