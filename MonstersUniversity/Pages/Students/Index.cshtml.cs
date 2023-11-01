using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MonstersUniversity.Data;
using MonstersUniversity.Models;

namespace MonstersUniversity.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly MonstersUniversity.Data.SchoolContext _context;

        public IndexModel(MonstersUniversity.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Student != null)
            {
                Student = await _context.Student.ToListAsync();
            }
        }
    }
}
