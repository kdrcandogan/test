using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myblog.BussinesLayer
{
    public class test
    {
        public test()
        {
            DAL.myblogContext db = new DAL.myblogContext();
            db.Database.CreateIfNotExists();
        }
    }
}
