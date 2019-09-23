using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interview.Api.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public string FullName { get { return Name + " " + LastName; } }
        public string Address { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

    }
}