using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Luis_Miguel_Jerez.Shared.Models;

public class Productos
{
	[Key]

	[Required(ErrorMessage = "El ProductoId es requerido")]
	public int ProductoId { get; set; }

	public DateTime Fecha { get; set; }

	public string? Concepto { get; set; }

	[ForeignKey("ProductoId")]
	public ICollection<ProductosDetalle> ProductosDetalle { get; set; } = new List<ProductosDetalle>();
}

