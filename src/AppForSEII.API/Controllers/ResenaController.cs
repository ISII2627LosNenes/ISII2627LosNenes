using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppForSEII.API.Controllers
{
[   Route("api/[controller]")]
    [ApiController]
    public class ResenaController : ControllerBase
        {
            private readonly ApplicationDbContext _context;
            private readonly ILogger<ApplicationUsersController> _logger;

            public ResenaController(ApplicationDbContext context, ILogger<ApplicationUsersController> logger)
            {   
                _context = context;
                _logger = logger;
            }
        }
}