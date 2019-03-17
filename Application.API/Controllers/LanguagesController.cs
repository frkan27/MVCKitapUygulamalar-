using Programing.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Application.API.Controllers
{
    public class LanguagesController : ApiController
    {
        LanguageDal LanguageDal = new LanguageDal();
        public IEnumerable<language> Get()
        {
            return LanguageDal.GetAllLanguage();
        }
        public language Get(int id)
        {
            return LanguageDal.GetLanguageId(id);
        }
        public language Post(language language )
        {
            return LanguageDal.CreateLanguage(language);
        }

        public language Put(int id,language language)
        {
            return LanguageDal.UpdateLanguage(id, language);
        }
        public void Delete(int id)
        {
            LanguageDal.DeleteLanguage(id);
        }
    }
}
