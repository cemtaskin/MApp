using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MessaginApp.API.Data;
using MessaginApp.API.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MessaginApp.API.Controllers
{
    // localhost:5200:/api/users
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        
        private readonly IMessaggingRepository _repo;
        private readonly IMapper _mapper;
        public UsersController(IMessaggingRepository repo,IMapper mapper){
            _repo=repo;
            _mapper=mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers(){
            var users = await _repo.GetUsers();
            var userToReturn =_mapper.Map<IEnumerable<UserForListDto>>(users);
            return Ok(userToReturn);
        }

         [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id){
            var users = await _repo.GetUser(id);
            return Ok(users);
        }

        
    }
}