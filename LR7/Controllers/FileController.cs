using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace LR_7.Controllers
{
    public class FileController : Controller
    {
        [HttpGet]
        public IActionResult DownloadFile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DownloadFile(string firstName, string lastName, string fileName)
        {
            string content = $"Ім'я: {firstName}\nПрізвище: {lastName}";
            byte[] byteArray = Encoding.UTF8.GetBytes(content);

            return File(byteArray, "text/plain", $"{fileName}.txt");
        }


    }
}
