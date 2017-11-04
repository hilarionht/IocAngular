using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Ioc_AngularSPA.Service;
using Ioc_AngularSPA.Repo;
using Ioc_AngularSPA.Core.Data;
using System.Data.Entity;

namespace Ioc_AngularSPA.Api.Controllers
{
    [RoutePrefix("users")]
    public class UserController : ApiController
    {
        //public UserController() { }
        //Repository<User> _repo = new Repository<User>();
        
        private IUserService _service;
        //private readonly IRepository<User> _userRep;
        public UserController(IUserService userService)
        {
            this._service = userService;
            //this._userRep = userRep;
        }
        public UserController()
        {
            _service = new UserService();
           
        }
        // GET: api/User
        public IHttpActionResult Get()
        {
            return Ok(_service.GetUsers());
        }

        //GET: api/User/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {

        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {

        }
    }
}
