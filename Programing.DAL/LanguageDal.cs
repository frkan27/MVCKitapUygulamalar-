using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing.DAL
{
   public class LanguageDal
    {
        languageEntities db = new languageEntities();
        //tüm languageleri döndürelim

        public IEnumerable<language> GetAllLanguage()
        {
            return db.languages;
        }
        //Id ile language döndren metod
        public language GetLanguageId(int id)
        {
            return db.languages.Find(id);
        }
        //language kullanıyoruz. eklediğimiz dili tekrardan döndürsün. çünküAPİ kısmınd kullanabiliriz.
        public language CreateLanguage(language lang)
        {
            db.languages.Add(lang);//dısardan gelen languagelerı ekle.
            db.SaveChanges();//kaudet
            return lang;//ve bu lang ı geri döndür
        }
        //dısardan ıd alıcak çünkü hangi ıd li language ları güncellemek istiyorusun.ve eklediğimiz yeni bi language olduğundan languageden nesne alıyoruz.
        public language UpdateLanguage(int id,language lang)
        {
            db.Entry(lang).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return lang;
        }

        public void DeleteLanguage(int id)
        {
           var SilincekId = db.languages.Find(id);
            db.languages.Remove(SilincekId);
            db.SaveChanges();
        }
        
    }
}
