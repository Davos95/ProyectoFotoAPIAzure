using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFotoCore.Models
{
    public class Worker_Session_Complex
    {
        [Key]
        [Column("IDPARTNER")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPartner { get; set; }
        [Column("PARTNER")]
        public String Partner { get; set; }
        [Column("IDWORK")]
        public int IdWork { get; set; }
        [Column("WORK")]
        public String Work { get; set; }

    }
}
