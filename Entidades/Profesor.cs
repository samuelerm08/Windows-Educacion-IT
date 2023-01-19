using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducacionIT.Entidades
{
    [Table("Profesor")]
    public class Profesor
    {
        [Key]
        public int IDProfesor { get; set; }
        [Required]
        public int IDLocalidad { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Apellido { get; set; }
        [ForeignKey("IDLocalidad")]        
        public Localidad Localidad { get; set; }
        public List<Planilla> Planillas { get; set; }
    }
}
