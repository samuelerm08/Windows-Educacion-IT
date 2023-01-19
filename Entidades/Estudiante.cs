using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducacionIT.Entidades
{
    [Table("Estudiante")]
    public class Estudiante
    {
        [Key]
        public int IDEstudiante { get; set; }
        public int IDLocalidad { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Apellido { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Telefono { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Calle { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string Numero { get; set; }
        [ForeignKey("IDLocalidad")]
        public Localidad Localidad { get; set; }
        public List<Evaluacion> Evaluaciones { get; set; }
    }
}
