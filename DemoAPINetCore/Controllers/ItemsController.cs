using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DemoAPINetCore.Data;
using DemoAPINetCore.Models;

namespace DemoAPINetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly BookStoreContext _context;

        public ItemsController(BookStoreContext context)
        {
            _context = context;
        }

        // GET: api/items/search?query={query}
        [HttpGet("search")]
        public ActionResult<IEnumerable<Book>> SearchItems(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                return BadRequest("Search query cannot be empty.");
            }

            // Perform search in database (assuming Book is your model and _context is your DbContext)
            var results = _context.Books
                                .Where(book => book.Title.Contains(query))
                                .ToList();

            return Ok(results);
        }
    }
}
