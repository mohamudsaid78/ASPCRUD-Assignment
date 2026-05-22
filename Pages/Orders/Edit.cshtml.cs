using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPCRUD.Pages.Orders
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }

    [BindProperty]
        public Order Orders {get;set;}

        public void OnGet(int id)
        {
            Orders = _context.Orders.Find(id);
        }

        public IActionResult OnPost()
        {


            _context.Orders.Update(Orders);
            _context.SaveChanges();
            // Redirect to Page
            return RedirectToPage("Order");
        }

    }
}