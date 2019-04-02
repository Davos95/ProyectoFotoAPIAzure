using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFotoCore.Models
{
    [Table("COMISION")]
    public class COMISION
    {
        [Key]
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Column("NAME")]
        public String Name { get; set; }
        [Column("DESCRIPTION")]
        public String Description { get; set; }
        [Column("ORDERCOMISION")]
        public int OrderComision { get; set; }
        [Column("PRICE")]
        public double Price { get; set; }
        [Column("PHOTO")]
        public String Photo { get; set; }

    }
}
