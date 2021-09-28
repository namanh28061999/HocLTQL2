using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTQLBT.Models
{
    public class Employee : person
    {
        public string Company { get; set; }
        [AllowHtml]
        public string Address { get; set; }
    }
}