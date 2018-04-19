using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hobby.Data.DataHelp
{
   public class BaseRepertory<TEntity> where TEntity:class
    {
        public DbContext context;
        public  DbSet<TEntity> dbset;
        public BaseRepertory()
        {
            context = DefaultHobbyContext.GetCurrentDbContext();
            dbset = context.Set<TEntity>();
        }

        public BaseRepertory(DbContext db)
        {
            context = db;
            dbset = context.Set<TEntity>();
        }
        public List<TEntity> GetList()
        {
            return dbset.ToList();
        }
        public TEntity GetByid(object id)
        {
            return dbset.Find(id);
        }
    }
}
