using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class ContactUsModel : PageModel
    {
        private readonly ILogger<ContactUsModel> _logger;

        public ContactUsModel(ILogger<ContactUsModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
