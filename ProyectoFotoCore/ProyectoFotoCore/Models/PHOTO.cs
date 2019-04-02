using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFotoCore.Models
{
    [Table("PHOTO")]
    public class PHOTO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID")]
        public int Id { get; set; }
        [Column("PICTURE")]
        public String Picture { get; set; }
        [Column("IDSESION")]
        public int IdSession { get; set; }
        [Column("ORDERPHOTO")]
        public int OrderPhoto { get; set; }
        [Column("FAVORITE")]
        public bool Favorite { get; set; }
    }
}
