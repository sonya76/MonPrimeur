using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MonPrimeur.Data;
using MonPrimeur.Models;

namespace MonPrimeur.Areas.Fruits.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext ctx;

        public IndexModel(ApplicationDbContext ctx)
        {
           this.ctx = ctx;
        }

        public IList<Fruit> Fruit { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Fruit = await ctx.Fruits.Include(f => f.Image).ToListAsync();  
        }
    }
}
