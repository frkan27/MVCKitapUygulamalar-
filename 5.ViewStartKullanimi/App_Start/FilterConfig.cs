﻿using System.Web;
using System.Web.Mvc;

namespace _5.ViewStartKullanimi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
