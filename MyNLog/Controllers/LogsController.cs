using Microsoft.AspNetCore.Mvc;

namespace MyNLog.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LogsController : ControllerBase
    {


        private readonly ILogger<LogsController> _logger;

        public LogsController(ILogger<LogsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Log")]
        public void Log()
        {
            _logger.Log(LogLevel.Information, "IT IS just Log {0}", "ARGUMENT");
        }

        [HttpGet(Name = "LogWithGenericType")]
        public void LogWithGenericType()
        {
            _logger.Log<SomeState>(
                LogLevel.Trace,
                new EventId(555, "EventIdName"),
                new SomeState() { FirstField = "firstF", SecondField = "secondF" },
                new Exception("MessageFromException"),
                (x, y) => { return "IT IS LogWithGenericType" + x.SecondField + "|" + y.Message; }
                );
        }

        [HttpGet(Name = "LogCritical")]
        public void LogCritical()
        {
            _logger.LogCritical("IT IS LogCritical");
        }

        [HttpGet(Name = "LogDebug")]
        public void LogDebug()
        {
            _logger.LogDebug("IT IS LogDebug");
        }

        [HttpGet(Name = "LogInformation")]
        public void LogInformation()
        {
            _logger.LogInformation("IT IS LogInformation");
        }

        [HttpGet(Name = "LogError")]
        public void LogError()
        {
            _logger.LogError("IT IS LogError");
        }

        [HttpGet(Name = "LogWarning")]
        public void LogWarning()
        {
            _logger.LogWarning("IT IS LogWarning");
        }

        [HttpGet(Name = "LogTrace")]
        public void LogTrace()
        {
            _logger.LogTrace("IT IS LogTrace");
        }

        public class SomeState
        {
            public string FirstField;
            public string SecondField;
            public string ThirdField;
        }
    }
}