using Microsoft.AspNetCore.Mvc;
using WebApi.BusinessControllers;
using WebApi.Model;

namespace WebApi.Controllers
{
    /// <summary>
    /// Version controller
    /// </summary>
    [ApiController]
    [Route("api/v1/[controller]")]
    public class VersionController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<VersionController> logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="logger"></param>
        public VersionController(IConfiguration configuration, ILogger<VersionController> logger)
        {
            this.configuration = configuration;
            this.logger = logger;
        }
        /// <summary>
        /// Returns version of the current api
        /// 
        /// For development purposes it returns version of assembly, for production purposes it returns string build by pipeline which contains project information, pipeline build version, assembly version, and build date
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<Model.Version> Get()
        {
            try
            {
                var ret = VersionDetection.GetVersion(
                    VersionBusinessController.InstanceId.ToString(),
                    VersionBusinessController.StartTime,
                    GetType().Assembly.GetName().Version.ToString());
                return Ok(ret);
            }
            catch (Exception exc)
            {
                logger.LogError("Controller error: " + exc.Message, exc);
                return BadRequest(new ProblemDetails() { Detail = exc.Message + (exc.InnerException != null ? $";\n{exc.InnerException.Message}" : "") + "\n" + exc.StackTrace, Title = exc.Message, Type = exc.GetType().ToString() });
            }
        }
    }
}
