using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FammsRazorPages.Data;
using FammsRazorPages.Models;

namespace task1_RazorP_.Pages
{
    public class Products : PageModel
    {
        public List<Product> Product { get; set; }

        public void OnGet()
        {
            Product = ProductData.ListProducts();
        }
    }
}
