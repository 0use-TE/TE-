namespace 腾易工作室后端.Models
{
    public class GamePageModel
    {
        public int Id { get; set; }
        public string ? GameName {  get; set; }
        public string? NickName { get; set; }
        public int Score {  get; set; }
        public string ?Content {  get; set; }
        public DateTime DateTime { get; set; }
    }
}
