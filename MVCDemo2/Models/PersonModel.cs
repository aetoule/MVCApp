using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo2.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; } = 0;
        public bool IsAlive { get; set; } = true;
    }
}