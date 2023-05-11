using Microsoft.EntityFrameworkCore;
using TraversalApiProject.DAL.Entities;

namespace TraversalApiProject.DAL.Context
{
	public class VisitorContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);

			optionsBuilder.UseSqlServer("Server = DESKTOP-9E5P6SH; initial catalog = TraversalDbApi; integrated security = true;");
		}

		public DbSet<Visitor> Visitors { get; set; }	
	}
}
