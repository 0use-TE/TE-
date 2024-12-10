using Microsoft.VisualBasic;
using MudBlazorWebApp.Models;

namespace MudBlazorWebApp.Data
{
    public static class OpenSourceData
    {
        public static List<OpenSource> OpenSources2024 {  get; set; }= new List<OpenSource>()
        {
            new OpenSource(){Name="腾易工作室前后端源文件", Description="TE工作室网站采用Asp.Net C" +
                "ore技术，前后端分离设计，托管于GitHub上面", Author="Ouse", StartTime=new DateTime
                (2024,7,20), Url="https://github.com/0use-TE/TEStudio"},
             new OpenSource(){Name="腾易工作室前后端包文件", Description="TE工作室发布文件", Author="Ouse", StartTime=new DateTime(2024,7,20),Url="https://github.com/0use-TE/TEStudioPackage"},
              new OpenSource(){Name="游戏-抓大鹅", Description="由腾易工作室制作的一款益智解密小游戏，托管于GitHub上面", Author="Ouse", StartTime=new DateTime
                (2024,5,22)},
               new OpenSource(){Name="游戏-小狐狸大冒险", Description="由Ouse制作的一款2D横板游戏，也是Ouse制作的第一款游戏，托管于GitHub上面", Author="Ouse", StartTime=new DateTime
                (2024,7,20)},
               new OpenSource(){ Name="基于.Net Core的Web端控制51单片机课程设计",Description="由Ouse制作的51单片机课程设计，托管于Gitee上面",Author="Ouse",
               StartTime=new DateTime(2024,11,2)},
               new OpenSource(){ Name="超市购物清单",Description="基于Asp.Net Core,使用了Identity，由Ouse开发的一款超市购物清单，方面了购物,托管在Gitee上面", Author="Ouse"}
        };
    }
}
