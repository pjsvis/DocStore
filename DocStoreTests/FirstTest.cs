using System;
using System.Net.Http;
using System.Web.Http;
using NUnit.Framework;
using DocStoreApi.Controllers;
using ServiceStack.Text;


namespace DocStoreTests
{
    [TestFixture]
    public class FirstTest
    {
        [Test]
        public void TestControllerGet()
        {
            // Set up Prerequisites   
            var controller = new TestController
            {
                Request = new HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            // Act on Test  
            var response = controller.Get();
            // Assert the result  
            Console.WriteLine(response.Dump());
        }
    }
}
