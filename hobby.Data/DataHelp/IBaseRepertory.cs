using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hobby.Data.DataHelp
{
   public interface IBaseRepertory<TEntity> where TEntity:class
    {
        List<TEntity> GetList();
        TEntity GetByid(object id);
    }
}
