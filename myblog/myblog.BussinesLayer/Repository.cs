using myblog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myblog.DAL;
using System.Data.Entity;
using System.Linq.Expressions;

namespace myblog.BussinesLayer
{
    public class Repository<T> where T : class
    {
        private myblogContext db = new myblogContext();
        private DbSet<T> _objectSet;
        
        public Repository()
        {
            _objectSet = db.Set<T>();
        }
        public List<T> List()
        {
            return _objectSet.ToList();
        }
        public List<T> List(Expression<Func<T,bool>> where) // Burada yapılan sorguda örn: order by ,ilk 10 kayıdı atla sonraki kayıtaları ver veya ne zaman tamamlanırsa o zaman çaışsın sıtersen listeyi IQueryable<T> yazmalıyız list olmadan
        {
            return _objectSet.Where(where).ToList();
        }
        public int Insert(T obj)
        {
            _objectSet.Add(obj);
            return Save();
        }
        public int Update(T obj)
        {
            return Save();
        }
        public int Delete(T obj)
        {
            _objectSet.Remove(obj);
            return Save();

        }    
        public int Save()
        {
            return db.SaveChanges();
        }
        public T Find(Expression<Func<T, bool>> where)
        {
            return _objectSet.FirstOrDefault(where);
        }
    }
}
