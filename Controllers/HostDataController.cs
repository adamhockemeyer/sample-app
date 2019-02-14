using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sample_app.Controllers
{
    [Route("api/[controller]")]
    public class HostDataController : Controller
    {
        [HttpGet("[action]")]
        public Host Host()
        {
            var name = $"{System.Environment.GetEnvironmentVariable("WEBSITE_SITE_NAME") ?? Dns.GetHostName()}";

            return new Host{ HostName = name};
        }

    }

    public class Host{
        public string HostName {get;set;}
    }
}
