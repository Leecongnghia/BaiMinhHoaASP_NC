using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PersonModel : Controller
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string BirthDay { get; set; }
        public string Picture { get; set; }

    }
}
