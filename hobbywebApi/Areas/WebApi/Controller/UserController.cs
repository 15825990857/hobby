using hobby.Core.Model;
using hobby.Data;
using hobby.Service.BLL;
using hobby.Service.IBLL;
using hobbywebApi.Areas.WebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace hobbywebApi.Areas.WebApi.Controller
{
    /// <summary>
    /// 
    /// </summary>
    public class UserController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        public IUserService _userService;
       
        /// <summary>
        /// 
        /// </summary>
        public UserController()
        {
            _userService = new UserService();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userService"></param>
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        
        public ResultView<List<User>> GetUserList()
        {
            return ResultView<User>.InitFromList(_userService.GetList());
        }

        public ResultView<User> GetByID(int id)
        {
            var db = new SqlDataBase();
            return ResultView<User>.InitFromList();
        }
 
    }
}
