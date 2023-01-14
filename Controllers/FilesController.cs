using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mvc101.Controllers
{
    public class FilesController : Controller
    {
        // GET: api/Files
    public ActionResult Index()
    {
        string[] files = Directory.GetFiles("TextFiles").Select(file => Path.GetFileName(file)).ToArray();
        return View(files);
    }

    public ActionResult Content(int id) {
        string[] files = Directory.GetFiles("TextFiles");
        string directory = System.IO.File.ReadAllText(files[id]);
        ViewData["dir"] = directory;
        return View();
    }
    }
}
