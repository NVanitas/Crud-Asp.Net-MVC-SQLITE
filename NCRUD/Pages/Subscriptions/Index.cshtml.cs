using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NCRUD.Data;
using NCRUD.Models;

namespace NCRUD.Pages_Subscriptions
{
    public class IndexModel : PageModel
    {
        private readonly NCRUD.Data.ApplicationDbContext _context;

        public IndexModel(NCRUD.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Subscription> Subscription { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Subscription = await _context.Subscriptions
                .Include(s => s.Student).ToListAsync();
        }
    }
}
