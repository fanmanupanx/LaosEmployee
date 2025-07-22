
using Microsoft.AspNetCore.Http;
using LaosEmployee.DBContext;
using LaosEmployee.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LaosEmployee.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PositionController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PositionController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetPosition")]
        public async Task<ActionResult<IEnumerable<Position>>> GetPosition()
        {
            var positions = await _context.Positions.ToListAsync();
            return Ok(positions);
        }
    }
}