using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducacionIT.Entidades
{
    [Table("Planilla")]
    public class Planilla
    {
        [Key]
        public int IDPlanilla { get; set; }
        public int IDCarrera { get; set; }
        public int IDMateria { get; set; }
        public int IDProfesor { get; set; }
        public int IDCurso { get; set; }
        public DateTime? Fecha { get; set; }

        [ForeignKey("IDCarrera")]
        public Carrera Carrera { get; set; }
        [ForeignKey("IDMateria")]
        public Materia Materia { get; set; }
        [ForeignKey("IDProfesor")]
        public Profesor Profesor { get; set; }
        [ForeignKey("IDCurso")]
        public Curso Curso { get; set; }
        public List<Detalle> Detalles { get; set; }
    }
}
