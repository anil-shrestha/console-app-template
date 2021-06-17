using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTemplate
{
    public class GreetingService : IGreetingService
    {
        private readonly ILogger _log;
        private readonly IConfiguration _config;

        public GreetingService(ILogger<GreetingService> log, IConfiguration config)
        {
            _log = log;
            _config = config;
        }
        public void Greet(string name)
        {
            _log.LogInformation("Hello {name}", name);
        }
    }
}
