using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationcoreMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ValuesController : ControllerBase
    {
        //Get api/values
        public IEnumerable<string> Get()
        {
            return new[] { "value1", "value2" };
        }

        //GET values/5
        public string Get(int id)
        {
            return "value";
        }

       
    }
}
