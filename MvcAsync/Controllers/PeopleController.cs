using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MvcAsync.Models;

namespace MvcAsync.Controllers
{
    public class PeopleController : Controller
    {
        private readonly PersonRepository repository = new PersonRepository();

        #region Synchronous
        public ActionResult Synchronous(string selectedRole = "All")
        {
            return View(GetPeople(selectedRole));
        }
        #endregion

        #region Unobtrusive AJAX
        public PartialViewResult Partial(string selectedRole = "All")
        {
            return PartialView(GetPeople(selectedRole));
        }

        public ActionResult AjaxHtml(string selectedRole = "All")
        {
            return View((object)selectedRole);
        }
        #endregion

        public JsonResult Json(string selectedRole = "All")
        {
            return Json(GetPeople(selectedRole), JsonRequestBehavior.AllowGet);
        }

        public ViewResult jQuery()
        {
            return View();
        }

        public ViewResult Handlebars()
        {
            return View();
        }

        public ActionResult Knockout()
        {
            return View(GetVm());
        }

        public ActionResult Angular()
        {
            return View();
        }

        private IEnumerable<Person> GetPeople(string selectedRole)
        {
            IEnumerable<Person> data = repository.GetAll();
            if (selectedRole != "All")
            {
                var selected = (Role)Enum.Parse(typeof(Role), selectedRole);
                data = data.Where(p => p.Role == selected);
            }
            return data;
        }

        private PeopleViewModel GetVm()
        {
            var roles = Enum.GetNames(typeof(Role)).ToList();
            return new PeopleViewModel
            {
                Roles = roles,
                SelectedRole = roles[0],
                JsonDataUrl =  Url.Action("json")
            };
        }
    }
}


