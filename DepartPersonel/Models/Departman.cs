using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DepartPersonel.Models
{
    [Table("Departmanlar")]
    public class Departman
    {
        public int Id { get; set; }
        [StringLength(25)]
        [Required]
        public string Ad { get; set; }

        public virtual ICollection<Personel> Personeller { get; set; }

    }
}