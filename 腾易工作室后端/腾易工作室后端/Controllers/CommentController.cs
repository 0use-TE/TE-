using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using 腾易工作室后端.Models;

namespace 腾易工作室后端.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CommentController : ControllerBase
    {
        private readonly MyDb _db;
        public CommentController(MyDb db)
        { 
            _db = db;
        }
        [HttpPost]
        public void PostComment(CommentModel comment)
        {
			Console.WriteLine("接受到了！");
            _db.Add(comment);
            _db.SaveChanges();
		}
		[HttpGet]
		public ActionResult<List<CommentModel>> GetPagedComments(int page, int pageSize)
		{
			if (page <= 0 || pageSize <= 0) // 确保请求的页码和数量是有效的
			{
				return BadRequest("Page and pageSize must be greater than zero.");
			}
			// 获取所有评论，按 Id 升序排序
			var allComments = _db.CommentModels.OrderBy(c => c.Id).ToList();
			// 使用 Skip 和 Take 来分页
			var pagedComments = allComments
				.Skip((page - 1) * pageSize) // 跳过前面的评论
				.Take(pageSize) // 取出当前页的评论
				.ToList(); // 转换为 List
			return Ok(pagedComments);
		}



		[HttpPost]
        public void PostGameComment(GamePageModel comment)
        {
            _db.Add(comment);
            _db.SaveChanges();
        }
        [HttpGet]
        public ActionResult<List<GamePageModel>> RandomGetGameComment(int counts, string gameName)
        {
         
            // 获取与指定游戏名匹配的评论
            var matchingComments = _db.GamePages
                .Where(c => c.GameName == gameName) // 筛选游戏名匹配的评论
                .ToList(); // 转换为 List
   
            var random = new Random();
            // 如果请求的数量大于匹配的评论数量，则限制为匹配评论的数量
            int numberOfCommentsToTake = Math.Min(counts, matchingComments.Count);

            // 随机排序并选择指定数量的评论
            var randomComments = matchingComments
                .OrderBy(x => random.Next()) // 随机排序
                .Take(numberOfCommentsToTake) // 选择指定数量的评论
                .ToList(); // 转换为 List
            return Ok(randomComments);
        }

    }
}
