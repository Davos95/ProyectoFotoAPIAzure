using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProyectoFoto.Models
{
    [Table("SESION_WORKER")]
    public class SESSION_WORKER
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDSESION")]
        public int IdSession { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDWORKER")]
        public int IdWorker { get; set; }
        [Column("IDWORK")]
        public int IdWork { get; set; }
    }
}
