using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducacionIT.Entidades
{
    [Table("Detalle")]
    public class Detalle
    {
        [Key]
        public int IDDetalle { get; set; }
        public int IDPlanilla { get; set; }
        public int IDEstado { get; set; }
        [ForeignKey("IDPlanilla")]
        public Planilla Planilla { get; set; }
        [ForeignKey("IDEstado")]
        public Estado Estado { get; set; }
        public List<Evaluacion> Evaluaciones { get; set; }
    }
}
