using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace 腾易工作室后端.Models
{
	public class CommentConfig : IEntityTypeConfiguration<CommentModel>
	{
		public void Configure(EntityTypeBuilder<CommentModel> builder)
		{
			builder.Property(c => c.Id).IsRequired();
		}
	}
}
