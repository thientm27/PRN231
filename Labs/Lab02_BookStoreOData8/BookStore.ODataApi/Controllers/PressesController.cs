using BookStore.ODataApi.DAOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace ODataBookStore.Controllers
{
    public class PressesController : ODataController
    {
        private BookStoreContext _context;

        public PressesController(BookStoreContext context)
        {
            _context = context;

            if (context.Books.Count() == 0)
            {
                foreach (var item in DataSource.GetBooks())
                {
                    context.Books.Add(item);
                    context.Presses.Add(item.Press);
                }
                context.SaveChanges();
            }
        }
        
        [EnableQuery]
        public IActionResult Get() { return Ok(_context.Presses); }

        //[EnableQuery]
        //public IActionResult Get(int key, string version) { return Ok(_context.Books.FirstOrDefault(c => c.Id == key)); }

        //[EnableQuery]
        //public IActionResult Post([FromBody] Book book)
        //{
        //    _context.Books.Add(book);
        //    _context.SaveChanges();
        //    return Created(book);
        //}
        //[EnableQuery]
        //public IActionResult Delete([FromBody] int key)
        //{
        //    Book b = _context.Books.FirstOrDefault(c => c.Id == key);            
        //    if (b == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Books.Remove(b);
        //    _context.SaveChanges();
        //    return Ok();
        //}
    }
}
