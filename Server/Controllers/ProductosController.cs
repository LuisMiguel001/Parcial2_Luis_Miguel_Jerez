using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parcial2_Luis_Miguel_Jerez.Server.DAL;
using Parcial2_Luis_Miguel_Jerez.Shared.Models;

namespace Parcial2_Luis_Miguel_Jerez.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductosController : ControllerBase
{
	private readonly Context _context;

	public ProductosController(Context context)
	{
		_context = context;
	}

	[HttpGet]
	public async Task<ActionResult<IEnumerable<Productos>>> GetProducto()
	{
		if(_context.Productos == null)
		{
			return NotFound();
		}
		return await _context.Productos.ToListAsync();
	}

	[HttpGet("{id}")]
	public async Task<ActionResult<Productos>> GetProducto(int id)
	{
		if(_context.Productos == null)
		{
			return NotFound();
		}

		var producto = await _context.Productos.FindAsync(id);
		if (producto == null)
		{
			return NotFound();
		}
		return producto;
	}

	[HttpPost]
	public async Task<ActionResult<Productos>> PostProductos(Productos producto)
	{
		if (!Existe(producto.ProductoId))
			_context.Productos.Add(producto);
		else
			_context.Productos.Update(producto);

		await _context.SaveChangesAsync();
		return Ok(producto);
	}

	[HttpDelete]
	public async Task<ActionResult> DeleteProducto(int id)
	{
		if(_context.Productos == null)
		{
			return NotFound();
		}

		var producto = await _context.Productos.FindAsync(id);

		if(producto == null)
		{
			return NotFound();
		}

		_context.Productos.Remove(producto);
		await _context.AddRangeAsync(producto);

		return NoContent();
	}

	private bool Existe(int id)
	{
		return (_context.Productos?.Any(c => c.ProductoId == id)).GetValueOrDefault();
	}
}

