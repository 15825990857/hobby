using hobby.Core.Model;
using hobby.Data.DataHelp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hobby.Service.IBLL
{
   public interface IUserService: IBaseRepertory<User>
    {
        User Login(string name, string pwd);
    }
}
