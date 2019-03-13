using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace İlkAPIProjem.Controllers
{
    public class SehirController : ApiController
    {
        private string[] sehirler = new string[] { "Antalya", "Bursa", "İstanbul" };
        public string[] Get()
        {
            return sehirler;
        }
        public string Get(int id)
        {
            return sehirler[id];//http://localhost:38312/api/sehir/1 yazınca 1. ındex ieskisehiri getiriryor
        }

    }//incele-network ten ne istek attığımıza bakabiliriz...
}
