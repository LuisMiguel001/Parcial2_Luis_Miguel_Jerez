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

	[Required(ErrorMessage ="Debe introducir el productoId")]
	public int ProductoId { get; set; }

	public DateTime Fecha { get; set; }

	[Required(ErrorMessage = "Debe introducir el concepto")]
	public string? Concepto { get; set; }

	[ForeignKey("ProductoId")]
	public ICollection<ProductosDetalle> ClientesDetalle { get; set; } = new List<ProductosDetalle>();
}

