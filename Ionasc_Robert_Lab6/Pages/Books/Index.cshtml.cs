using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ionasc_Robert_Lab6.Data;
using Ionasc_Robert_Lab6.Models;

namespace Ionasc_Robert_Lab6.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Ionasc_Robert_Lab6.Data.Ionasc_Robert_Lab6Context _context;

        public IndexModel(Ionasc_Robert_Lab6.Data.Ionasc_Robert_Lab6Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
