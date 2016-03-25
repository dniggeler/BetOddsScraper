using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetOddsScraper.Web.Controllers
{
    [Route("api/oddscraper")]
    public class BetOddsScraper : Controller
    {
        private readonly ILogger<BetOddsScraper> _logger;

        public BetOddsScraper(ILogger<BetOddsScraper> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogVerbose("Begin Get()");

            return new string[] { "value1", "value2" };
        }

    }
}
