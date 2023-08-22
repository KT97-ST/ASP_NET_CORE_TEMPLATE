using ASP_NET_CORE_TEMPLATE.Models;
using Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace ASP_NET_CORE_TEMPLATE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        async public Task<IActionResult> Index()
        {
           

            HttpClient client = new HttpClient();
            var data = await client.GetAsync("https://localhost:7120/HocSinh");

            var res = await data.Content.ReadAsStringAsync();

            var dataJson = JsonConvert.DeserializeObject<HocSinhDetail>(res);

            return View(dataJson);
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