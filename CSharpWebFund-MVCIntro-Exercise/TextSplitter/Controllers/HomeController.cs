
namespace TextSplitter.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using TextSplitter.ViewModels;

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(TextSplitViewModel textViewModel)
        {
            return View(textViewModel);
        }

        public IActionResult Split(TextSplitViewModel textViewModel)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", textViewModel);   
            }

            string[] words = textViewModel.TextToSplit
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string splitText  = String.Join(Environment.NewLine, words);    

            textViewModel.SplitText= splitText;

            return RedirectToAction("Index", textViewModel);
        }


    }
}