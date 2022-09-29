using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //호출되는 메서드 /HelloWorld index출력
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/ name과 num 출력
        //helloworld/welcome?name=이름&numtimes=숫자
        public IActionResult Welcome(string name="seo0", int numTimes = 1)

        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}