using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTQLBT.Models
{
    public class Employee : person
    {
        public string Company { get; set; }
        public string Address { get; set; }
    }
}