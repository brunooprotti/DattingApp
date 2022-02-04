using DattingApp.Api.Data;
using DattingApp.Api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DattingApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _ctx;

        public UsersController(DataContext context)
        {
            _ctx = context;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetAll()
        {
            return await _ctx.User.ToListAsync();
        }

        [HttpGet("GetById")]
        public async Task<ActionResult<AppUser>> GetById(int id)
        {
            return await _ctx.User.FindAsync(id);
        }
    }
}
