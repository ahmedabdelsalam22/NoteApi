using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoteApi.Models;

namespace NoteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public NotesController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
