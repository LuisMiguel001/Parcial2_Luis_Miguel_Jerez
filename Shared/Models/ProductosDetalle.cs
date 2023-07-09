using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Luis_Miguel_Jerez.Shared.Models;

public class ProductosDetalle
{
	public int DetalleId { get; set; }

	public int ProductoId { get; set; }

	[Required(ErrorMessage = "El producto es requerido")]
	public string? Producto { get; set; }

	public string? Descripcion { get; set; }

	[Required(ErrorMessage = "La cantidad es requerida")]
	public int Cantidad { get; set; }
}

