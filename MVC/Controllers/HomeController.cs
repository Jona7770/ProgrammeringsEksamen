using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public const string API = "https://localhost:44305";
        public static HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(API);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }

        public async Task<IActionResult> NewsHomePage()
        {
            var client = GetClient();
            HttpResponseMessage response = await client.GetAsync($@"api/NewsAPI");

            if (response.IsSuccessStatusCode)
            {
                var Model = await response.Content.ReadAsAsync<List<NewsProxy>>();
                return View(Model);
            }
            else
            {
                return BadRequest();
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
