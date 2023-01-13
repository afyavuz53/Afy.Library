using Afy.Library.WebUI.Interfaces.Services;
using Afy.Library.WebUI.Models.Library;
using Microsoft.AspNetCore.Mvc;

namespace Afy.Library.WebUI.Controllers
{
    public class LibraryController : Controller
    {
        private readonly ILibraryItemService _libraryItemService;
        public LibraryController(ILibraryItemService libraryItemService)
        {
            _libraryItemService = libraryItemService;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _libraryItemService.GetsAsync();
            return View(result);
        }

        public async Task<IActionResult> Add()
        {
            return View(await _libraryItemService.GetFoldersAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Add(LibraryItem model)
        {
            try
            {
                await _libraryItemService.Add(model);
                return RedirectToAction("index");
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}
