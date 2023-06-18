using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("RolFormularios")]
	public class RolFormularios
	 {
		[Key]
		public int IdRolFormulario { get; set; }
		[Required]
		public short IdRol { get; set; }
		[Required]
		public int IdFormulario { get; set; }
		[Required]
		public bool Activo { get; set; }
		[Required]
		public int IdUsuarioRegistra { get; set; }
		[Required]
		public DateTime FechaRegistro { get; set; }
		public int? IdUsuarioActualiza { get; set; }
		public DateTime? FechaActualizacion { get; set; }
	 }
}
