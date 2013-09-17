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
            return View(GetPeopleVm(selectedRole));
        }
        #endregion

        #region Unobtrusive AJAX
        public PartialViewResult Partial(string selectedRole = "All")
        {
            return PartialView(GetPeople(selectedRole));
        }

        public ActionResult AjaxHtml(string selectedRole = "All")
        {
            return View(GetRolesVm());
        }
        #endregion

        public ViewResult jQueryUnobtrusive(string selectedRole = "All")
        {
            return View(GetPeopleVm(selectedRole));
        }

        public ViewResult jQuery(string selectedRole = "All")
        {
            return View(GetPeopleVm(selectedRole));
        }

        public ActionResult Knockout(string selectedRole = "All")
        {
            return View(GetPeopleVm(selectedRole));
        }

        public ViewResult Handlebars(string selectedRole = "All")
        {
            return View(GetPeopleVm(selectedRole));
        }

        public ActionResult Angular(string selectedRole = "All")
        {
            return View(GetPeopleVm(selectedRole));
        }

        public JsonResult Json(string selectedRole = "All")
        {
            return Json(GetPeople(selectedRole), JsonRequestBehavior.AllowGet);
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

        private RolesViewModel GetRolesVm()
        {
            var roles = new RolesRepository().GetAll();
            return new RolesViewModel
            {
                Roles = roles,
                SelectedRole = roles[0],
                JsonDataUrl = Url.Action("json")
            };
        }

        private PeopleViewModel GetPeopleVm(string selectedRole)
        {
            return new PeopleViewModel
            {
                Roles = new RolesRepository().GetAll(),
                People = GetPeople(selectedRole),
                JsonDataUrl = Url.Action("json")
            };
        }
    }
}


