using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerOrder.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
        //To read, route attributes
        public string Phone()
        {
            return "0720 000 000";
        }

        public string Address()
        {
            return "RO";
        }
    }
}
