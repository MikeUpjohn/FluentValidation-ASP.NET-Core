using System.Collections.Generic;
using fluent_validation_trial.Models;
using Microsoft.AspNetCore.Mvc;

namespace fluent_validation_trial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetCustomerData(Applicant applicant)
        {
            return Ok(applicant);
        }
    }
}
