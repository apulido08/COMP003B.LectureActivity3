using Microsoft.AspNetCore.Mvc;

namespace COMP003B.LectureActivity3.Controllers
{
    // The StoreController class is a controller that handles requests for the store section of the website.
    // The [Route("storage")] attribute specifies that the controller will handle requests that start with "/store".
    [Route("store")]

    public class StoreController : Controller
    {
        // Get: store/product/5
        [Route("product/{id:int}")]

        public IActionResult ViewProduct(int id)
        {
            // The View() method returns a view result that renders a view to the response.
            // The id parameter is passed to the view.
            return View();
        }

        // Get : store/product/search?category=electronics
        [HttpGet("product/search")]

        public IActionResult Search([FromQuery] string category)
        {
            return View("Search", category);
        }
    }
}
