using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NameApi.Models;

namespace NameApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : Controller
    {
        
        private readonly NameContext _context;

        public NameController(NameContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<NameItem>> Get()
        {
            return  _context.NameItems;
        }

        [HttpGet("{id}")]
        public ActionResult<NameItem> Get(int id)
        {
            return _context.NameItems.Where(x => x.Id == id).FirstOrDefault();
        }

        [HttpPost("{id}/{password}")]
        public void Post(int id, String password)
        {
            var name = _context.NameItems.Where(x => x.Id == id).FirstOrDefault();            
            name.isPasswordMatch(password);
            _context.SaveChanges();
        }

        [HttpPost]
        public void Post([FromBody] NameItem value)
        {
            _context.Add(value);
            _context.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] NameItem value)
        {
            var item = _context.NameItems.Find(id);
            if( item == null) return;
            _context.Entry(item).CurrentValues.SetValues(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
