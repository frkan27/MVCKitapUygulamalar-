using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AttributesKullanımı.Models
{

    
    public class Kisi
    {
        public int Id { get; set; }
        [DisplayName("Adınız")]
        public string Ad { get; set; }
        [DisplayName("Soyadınız")]
        public string Soyad { get; set; }
        [Required]
        [DisplayName("TC Kimlik No")]
        [Editable(false)]//İlk kayıttan sonra bidaha hiç güncellenmemesi için.
        public string TCKN { get; set; }

        [DisplayFormat(DataFormatString ="{0:dd.MM.yyyy}")]
        public DateTime DogumTarihi { get; set; }
    }
}