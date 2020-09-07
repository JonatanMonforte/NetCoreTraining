using System.Linq;
using System.Collections.Generic;
using AT.IDataAccess.IRepository;
using AT.Model.Common;
using AT.Model.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AT.WebApi.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UserController : ControllerBase
    {
        private readonly IRepository<User> userReporsitory;
        private readonly IMapper mapper;

        public UserController(IRepository<User> userReporsitory, IMapper mapper)
        {
            this.mapper = mapper;
            this.userReporsitory = userReporsitory;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserList>> GetAll()
        {
            return Ok(userReporsitory.GetAll().ToList().Select(mapper.Map<User, UserList>));
        }

        [HttpGet("Id")]
        public ActionResult<User> GetById(int Id)
        {
            return Ok(mapper.Map<User, UserList>(userReporsitory.GetById(Id)));
        }

        [HttpPost]
        public ActionResult<User> Create(RegisterUser RegisterUser)
        {
            return Ok(userReporsitory.Create(mapper.Map<RegisterUser, User>(RegisterUser)));
        }

        [HttpDelete]
        public ActionResult DeleteUser(User User)
        {
            userReporsitory.Delete(User);
            return Ok();
        }
    }
}