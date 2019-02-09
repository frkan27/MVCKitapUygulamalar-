using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DepartPersonel.Models
{
    [Table("Personeller")]
    public class Personel
    {
        public int Id { get; set; }
       
        [StringLength(25)]
        [Required]
        public string Ad { get; set; }
        [StringLength(25)]
        [Required]
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public decimal  Maas { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool Cinsiyet { get; set; }
        public bool EvliMi { get; set; }

       
        public int DepartmanId { get; set; }

        public virtual Departman Departman { get; set; }


    }
}