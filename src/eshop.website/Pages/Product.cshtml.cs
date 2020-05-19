using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eshop.website.Pages
{
    public class ProductModel : PageModel
    {
        [BindProperty]
        public string ProductId { get; set; }

        public void OnGet(string productId)
        {
            ProductId = string.Format("img-{0}.jpg",productId);
        }
    }
}