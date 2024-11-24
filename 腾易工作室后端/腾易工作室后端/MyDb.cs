using Microsoft.EntityFrameworkCore;
using 腾易工作室后端.Models;

namespace 腾易工作室后端
{
	public class MyDb:DbContext
	{
        public MyDb(DbContextOptions options) : base(options)
        {

        }
        public DbSet<CommentModel> CommentModels { get; set; }
		public DbSet<GamePageModel> GamePages { get; set; }
	}
}
