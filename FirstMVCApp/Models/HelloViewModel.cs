using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Models
{
    public class HelloViewModel
    {
        public string Name { get; set; }
        public string GreetingSuffix { get; set; }

        public IEnumerable<string> Names { get; set; }
    }

    public class View
    {
        public dynamic Model { get; set; }
    }
}
