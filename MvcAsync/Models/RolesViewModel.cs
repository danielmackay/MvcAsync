using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAsync.Models
{
    public class RolesViewModel
    {
        public List<string> Roles { set; get; }

        public string RolesJson
        {
            get
            {
                return JsonConvert.SerializeObject(Roles);
            }
        }

        public string SelectedRole { get; set; }

        public string JsonDataUrl { get; set; }
    }

    public class PeopleViewModel
    {
        public IEnumerable<Person> People { get; set; }
        public List<string> Roles { set; get; }

        public string PeopleJson { get { return JsonConvert.SerializeObject(People); } }
    }
}