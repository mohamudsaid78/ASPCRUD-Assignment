using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPCRUD.Pages.Orders
{
    public class IndexModel : PageModel
    {
        // connect database 
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context=context;
        }

        // property

        public List<Order> arday {get; set;}

        public void OnGet()
        {
            arday=_context.Orders.ToList();
        }
    }
}