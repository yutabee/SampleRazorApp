using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SampleRazorApp.Data;
using SampleRazorApp.Models;

namespace SampleRazorApp.Pages;

public class FindModel : PageModel
{
    private readonly SampleRazorAppContext _context;
    public IList<Person> People { get; set; }

    public FindModel(SampleRazorAppContext context)
    {
        _context = context;
    }

    public async Task OnGetAsync()
    {
        People = await _context.Person.ToListAsync();
    }

    public async Task OnPostAsync(string FindStr)
    {
        People = await _context.Person.Where(m => m.Name == FindStr).ToListAsync();
    }
}
