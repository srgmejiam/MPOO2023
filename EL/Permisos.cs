using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Permisos")]
	public class Permisos
	 {
		[Key]
		public int IdPermiso { get; set; }
		[MaxLength(50)]
		[Required]
		public string Permiso { get; set; }
		[Required]
		public bool Activo { get; set; }
		[Required]
		public int IdUsuarioRegistra { get; set; }
		[Required]
		public DateTime FechaRegistro { get; set; }
		public int? IdUsuarioActualiza { get; set; }
		public DateTime? FechaActualizacion { get; set; }
		public Permisos()
		{
			Permiso = string.Empty;
		}
	 }
}
