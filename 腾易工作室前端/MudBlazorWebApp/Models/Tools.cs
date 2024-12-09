namespace MudBlazorWebApp.Models
{
    public static class Tools
    {
        public static List<string> GetEnamorImagePath(string path,int start,int counts)
        {
            List<string> paths=new List<string>();
            for(int i=0;i<counts;i++)
            {
                var temp=path+"/"+(start+i)+".jpg";
                paths.Add(temp);
            }
            return paths;
        }
        public static List<string> GetEnamorVideoPath(string path, int start, int counts)
        {
            List<string> paths = new List<string>();
            for (int i = 0; i < counts; i++)
            {
                var temp = path + "/video" + (start + i) + ".mp4";
                paths.Add(temp);
              //  Console.WriteLine(temp);
            }
            return paths;
        }
    }
}
