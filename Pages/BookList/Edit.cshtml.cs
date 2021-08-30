using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class EditModel : PageModel
    {
        private ApplicationDbContext _db;
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Book Book { get; set; }
        public async Task OnGet(int id)
        {
            Book = await _db.Book.FindAsync(id);
        }

        public async Task<IActionResult> OnPost(int id)
        {
            if(ModelState.IsValid)
            {
               var BookfromDb = await _db.Book.FindAsync(id);
                BookfromDb.Name = Book.Name;
                BookfromDb.Auther = Book.Auther;
                BookfromDb.ISBN = Book.ISBN;
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}
