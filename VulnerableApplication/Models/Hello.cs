using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VulnerableApplication.Models
{
    public class Hello
    {
        public void Say()
        {
            Console.WriteLine("Hello!");
        }
    public string Hi() {
    return "this is against the rules.";
    }
        
    }
}
