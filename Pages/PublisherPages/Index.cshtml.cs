using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Maris_Denisa_Madalina_Lab2.Models;

namespace Maris_Denisa_Madalina_Lab2.Pages.PublisherPages;

public class IndexModel : PageModel
{
    private readonly Maris_Denisa_Madalina_Lab2Context _context;

    public IndexModel(Maris_Denisa_Madalina_Lab2Context context)
    {
        _context = context;
    }

    public IList<Publisher> Publisher { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Publisher = await _context.Publisher.ToListAsync();
    }
}
