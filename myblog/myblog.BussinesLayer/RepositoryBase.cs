using myblog.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myblog.BussinesLayer
{
    // singleton pattern
    public class RepositoryBase
    {

        protected static myblogContext db;
        private static object _lock = new object();

        protected RepositoryBase()
        {
           db =  CreateContext();       //db yi burada oluşturuyoruz protected olarak türetilmesi için
        }
        // bir kere database context new oluşturulacak eğer varsa hep aynı db yi kullanacaktır.
        private static myblogContext CreateContext() 
        {
            // multi-thread uygulamarda if 'e iki kez girip 2 kez new işlemni yapılıyor.
            //Bunu aşmak için lock içine alıyoruz.
            if (db == null)
            {
                
                lock (_lock)   
                {
                    if(db == null)
                    {
                        db = new myblogContext();
                    }
                    
                }
               
            }
            return db;
        }
    }
}
