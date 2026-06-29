using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCrud_Proyecto01.Modelos;

public class TipoLibro
{
    [Key]
    public int IdTipoLibro { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(100)]
    public string Nombre { get; set; }

    [StringLength(100)]
    public string? Descripcion { get; set; }

    [Required(ErrorMessage = "El código es obligatorio")]
    [StringLength(30)]
    public string Codigo { get; set; }

    [Required(ErrorMessage = "El estado es obligatorio")]
    [StringLength(15)]
    public string Estado { get; set; }

    public DateTime FechaCreacion { get; set; } = DateTime.Now;

    public DateTime? FechaActualizacion { get; set; } = DateTime.Now;
}