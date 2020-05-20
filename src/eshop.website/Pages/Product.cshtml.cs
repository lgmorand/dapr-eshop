using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eshop.website.Pages
{
    public class ProductModel : PageModel
    {
        public string ProductId { get; set; }

        public void OnGet(string productId)
        {
            ProductId = productId;
        }
    }
}