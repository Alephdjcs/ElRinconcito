using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace El_Rinconcito.Pages
{
    public class UbicacionModel : PageModel
    {
        private readonly ILogger<UbicacionModel> _logger;

        public UbicacionModel(ILogger<UbicacionModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}