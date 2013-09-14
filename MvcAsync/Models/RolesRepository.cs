using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAsync.Models
{
    public class RolesRepository
    {
        public List<string> GetAll()
        {
            var roles = Enum.GetNames(typeof(Role)).ToList();
            roles.Insert(0, "All");
            return roles;
        }
    }
}