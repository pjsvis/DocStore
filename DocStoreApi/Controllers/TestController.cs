using System.Collections.Generic;
using System.Web.Http;

namespace DocStoreApi.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public List<int> Get()
        {

            return new List<int>() { 1, 2, 3 };
        }
    }
}
