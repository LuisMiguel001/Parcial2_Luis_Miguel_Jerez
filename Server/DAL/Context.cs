using Microsoft.EntityFrameworkCore;
using Parcial2_Luis_Miguel_Jerez.Shared.Models;

namespace Parcial2_Luis_Miguel_Jerez.Server.DAL;

public class Context : DbContext
{
	public Context(DbContextOptions<Context> options) 
		: base(options) { }

	public DbSet<Productos> Productos { get; set; }
	public DbSet<TipoProducto> TiposProductos { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.Entity<TipoProducto>().HasData(new List<TipoProducto>()
		{
			new TipoProducto(){TipoId=1, Descripcion="Maní"},
			new TipoProducto(){TipoId=2, Descripcion="Pistachos" },
			new TipoProducto(){TipoId=3, Descripcion="Pasas" },
			new TipoProducto(){TipoId=4, Descripcion="Ciruelas" },
			new TipoProducto(){TipoId=5, Descripcion="Arándanos" }
		});
	}
}

