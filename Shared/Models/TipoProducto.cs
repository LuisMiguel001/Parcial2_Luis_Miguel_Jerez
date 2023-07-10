using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Luis_Miguel_Jerez.Shared.Models;

public class TipoProducto
{
	[Key]

	public int TipoId { get; set; }

	public int ProductoId { get; set; }

	public string Descripcion { get; set; }

	public string? Producto { get; set; }
}

