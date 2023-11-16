using Microsoft.EntityFrameworkCore;

namespace _16_11.DAL
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options): base(options) 
		{

		}
	}
}
