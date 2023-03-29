using zajecia1.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zajecia1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private int? Number;

        [BindProperty]
        public FizzBuzzForm FizzBuzz { set; get; }
        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }
        public string Result { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";
            }
        }
        public IActionResult OnPost()
        {
            Result = FizzBuzz.CheckValue(FizzBuzz.Number);
            /*if (ModelState.IsValid)
            {*/
                return Page();
            /*}
            return RedirectToPage("./Privacy");*/
        }
    }
}