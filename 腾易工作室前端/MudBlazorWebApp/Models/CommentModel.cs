namespace MudBlazorWebApp.Models
{
    public class CommentModel
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime DateTime { get; set; }
    }
}
