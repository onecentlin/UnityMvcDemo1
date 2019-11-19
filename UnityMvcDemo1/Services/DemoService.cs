using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnityMvcDemo1.Services
{
    public class DemoService : IDemoService
    {
        public string Greetings(string name)
        {
            return $"Hello, {name}!";
        }
    }
}