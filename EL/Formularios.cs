using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Formularios")]
	public class Formularios
	 {
		[Key]
		public int IdFormulario { get; set; }
		[MaxLength(50)]
		[Required]
		public string Formulario { get; set; }
		[Required]
		public bool Activo { get; set; }
		[Required]
		public int IdUsuarioRegistra { get; set; }
		[Required]
		public DateTime FechaRegistro { get; set; }
		public int? IdUsuarioActualiza { get; set; }
		public DateTime? FechaActualizacion { get; set; }
		public Formularios()
		{
			Formulario = string.Empty;
		}
	 }
}
