using Microsoft.AspNetCore.Mvc;
using System;

namespace DojoSurvey.Controllers
{

    public class SurveyController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost("processform")]
        public RedirectToActionResult ProcessForm(string Name, string Location, string Language, string Comment)
        {
            var FormData = new {Name = Name, Location = Location, Language = Language, Comment = Comment};

            return RedirectToAction("Result", FormData);
        }

        [HttpGet("result")]
        public ViewResult Result(string Name, string Location, string Language, string Comment)
        {
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comment = Comment;
            return View("Result");
        }
    }

}