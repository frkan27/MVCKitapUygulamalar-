using NorthwindKullan.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindKullan.ViewModels
{
    public class UrunViewModel//viewmodel yapmamnın tek nedeni liste seklinde katgori istemem.
    {
        public IEnumerable<Category> Categories { get; set; }
        public Product Product { get; set; }
    }
}