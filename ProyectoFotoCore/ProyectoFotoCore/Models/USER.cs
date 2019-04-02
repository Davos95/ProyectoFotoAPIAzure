using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFotoCore.Models
{
    [Table("USERS")]
    public class USER
    {
        [Key]
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public String Id { get; set; }
        [Column("NICK")]
        public String Nick { get; set; }
        [Column("PWD")]
        public String Password { get; set; }
        [Column("NAME")]
        public String Name { get; set; }
        [Column("ROLE")]
        public String Role { get; set; }


    }
}
