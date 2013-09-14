using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAsync.Models
{
    public class PeopleViewModel
    {
        public List<string> Roles { set; private get; }
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
}