using FirstMVCApp.Models;
using FirstMVCApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Controllers
{
    public class MyActionFilter : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine($"Executed action {context.ActionDescriptor.DisplayName}");
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ActionDescriptor.DisplayName != "Index")
            {
                context.Result = new StatusCodeResult(403);
            }
        }
    }


    public class RsvpController : Controller
    {
        public class User
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }

        public class CreateUserViewModel
        {
            public string Email { get; set; }
            public string ConfirmEmail { get; set; }
        }

        readonly IRsvpService rsvpService;

        public RsvpController(IRsvpService rsvpService)
        {
            this.rsvpService = rsvpService;
        }

        public ActionResult Index()
        {
            var rsvps = rsvpService.GetRsvps();

            return View(rsvps);
        }

        [HttpGet]
        [Authorize]
        public ActionResult Rsvp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Rsvp(CreateRsvpViewModel model)
        {
            if (ModelState.IsValid)
            {
                var rsvps = rsvpService.GetRsvps();
                return View("Index", rsvps);
            }

            return View(model);
        }
    }
}
