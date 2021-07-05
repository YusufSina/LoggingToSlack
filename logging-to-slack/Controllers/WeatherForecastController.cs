using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SlackLogger;

namespace logging_to_slack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ISLogger _sLogger;

        public WeatherForecastController(ISLogger sLogger)
        {
            _sLogger = sLogger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _sLogger.Slack("Hello World!");
            _sLogger.Slack("You got an error!", SlackDto.SlackType.Error);
            return Ok();
        }
    }
}
