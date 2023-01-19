using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducacionIT.Entidades
{
    [Table("Plan")]
    public class Plan
    {
        [Key]
        public int IDPlan { get; set; }
        public int IDCarrera { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Nombre { get; set; }
        [ForeignKey("IDCarrera")]
        public Carrera Carrera { get; set; }
    }
}
