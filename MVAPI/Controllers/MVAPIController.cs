using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MVAPI.API;
using MVAPI.Models;

namespace MVAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class MVAPIController : Controller
    {
      public IActionResult Index([FromServices]APIMarvelClient client)
        {
            return View(client.ObterDadosPersonagem());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true )]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestID = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}