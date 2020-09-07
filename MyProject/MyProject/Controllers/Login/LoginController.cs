using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProject.Data;
using MyProject.Data.Login;
using MyProject.Models.Login;

namespace MyProject.Controllers.Login
{
    public class LoginController : Controller
    {
        readonly LoginQueryCommand queryCommand = new LoginQueryCommand();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ActionName("insert")]
        public IActionResult Insert([FromBody] LoginEntities loginEntities)
        {
            queryCommand.Insert(loginEntities);
            return Ok(HttpStatusCode.OK);
        }
    }
}
