using HomeworkMain.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeworkMain.Data
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
		{ 
			//Database.EnsureCreated();
		}
		public DbSet<Book> books { get; set; }
		public DbSet<Review> reviews { get; set; }
	}
}
