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
        static List<string> strings = new List<string>()
        {
           "value0", "value1", "value2"
        };
        //Get api/values
        public IEnumerable<string> Get()
        {
            return strings;
        }

        //GET values/5
        public string Get(int id)
        {
            return strings[id];
        }

        //POST api/values
        public void Post([FromBody] string value)
        {
            strings.Add(value);
        }

        //PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            strings[id] = value;
        }

        //DELETE api/values/5
        public void Delete(int id)
        {
            strings.RemoveAt(id);
        }
    }
}
