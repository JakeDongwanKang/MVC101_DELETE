using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mvc101.Controllers
{
    public class ProcessController : Controller
    {
        public ActionResult Index()
    {
        return View(Process.GetProcesses());
    }

    public ActionResult Display(int id) {
        return View(Process.GetProcessById(id));
    }
    }
}
