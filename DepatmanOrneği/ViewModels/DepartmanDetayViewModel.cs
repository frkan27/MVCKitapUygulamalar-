﻿using DepatmanOrneği.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepatmanOrneği.ViewModels
{
    public class DepartmanDetayViewModel
    {
        public Departman Departman { get; set; }
        public List<Personel> Personeller { get; set; }


    }
}