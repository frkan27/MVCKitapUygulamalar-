using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AttributesKullanımı.Models
{
    public class UyeGiris
    {
        [DisplayName("Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
        [DisplayName("Şifre")]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }
        [DisplayName("Şifre Tekrarı")]
        [DataType(DataType.Password)]
        public string Sifre2 { get; set; }

    }
}