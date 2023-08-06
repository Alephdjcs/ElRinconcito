using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace El_Rinconcito.Pages
{
    public class FoodModel : PageModel
    {
        private readonly ILogger<FoodModel> _logger;

        public FoodModel(ILogger<FoodModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}