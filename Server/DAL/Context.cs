using Microsoft.EntityFrameworkCore;
using Parcial2_Luis_Miguel_Jerez.Shared.Models;

namespace Parcial2_Luis_Miguel_Jerez.Server.DAL;

public class Context : DbContext
{
	public Context(DbContextOptions<Context> options) 
		: base(options) { }

	public DbSet<Productos> Productos { get; set; }	
}

