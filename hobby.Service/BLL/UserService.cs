﻿using hobby.Core.Model;
using hobby.Data;
using hobby.Data.DataHelp;
using hobby.Service.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hobby.Service.BLL
{
    public class UserService : BaseRepertory<User>, IUserService
    {
        public User Login(string name, string pwd)
        {
            return dbset.FirstOrDefault(p => p.Name.Equals(name) & p.Pwd.Equals(pwd));
        }

        public List<User> GetList()
        {
            return dbset.ToList();
        }
    }
}
