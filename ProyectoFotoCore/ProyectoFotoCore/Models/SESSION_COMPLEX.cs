using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFotoCore.Models
{
    public class SESSION_COMPLEX
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID")]
        public int Id { get; set; }
        [Column("NAME")]
        public String Name { get; set; }
        [Column("DESCRIPTION")]
        public String Description { get; set; }
        [Column("IDPHOTO")]
        public int? IdPhoto { get; set; }
        [Column("DATESESION")]
        public DateTime DateSesion { get; set; }
        [Column("IDCOMISION")]
        public int IdComision { get; set; }
        [Column("PICTURE")]
        public String Picture { get; set; }
    }
}
