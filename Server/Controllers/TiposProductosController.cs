using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parcial2_Luis_Miguel_Jerez.Server.DAL;
using Parcial2_Luis_Miguel_Jerez.Shared.Models;

namespace Parcial2_Luis_Miguel_Jerez.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TiposProductosController : ControllerBase
{
	private readonly Context _context;

	public TiposProductosController(Context context)
	{
		_context = context;
	}

	[HttpGet("{id}")]
	public async Task<ActionResult<TipoProducto>> GetTiposProductos(int id)
	{
		var tipo = await _context.TiposProductos.FindAsync(id);

		return tipo!;
	}

	[HttpGet]
	public async Task<ActionResult<IEnumerable<TipoProducto>>> GetTiposProductos()
	{
		if (_context.TiposProductos == null)
		{
			return NotFound();
		}
		return await _context.TiposProductos.ToListAsync();
	}
}

