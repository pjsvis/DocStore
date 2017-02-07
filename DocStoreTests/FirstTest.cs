using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Web.Http;
using DocStoreApi.Controllers;
using MoreLinq;
using NUnit.Framework;
using ServiceStack;
using ServiceStack.Text;

namespace DocStoreTests
{
    [TestFixture]
    public class FirstTest
    {
        [Test]
        public void DocIdPath()
        {
            var docId = 9223372036854775;
            var docIdStr = docId.ToString();
            var docIdPath = docIdStr.Batch(2).InList();
            var lstBits = new List<string>();
            foreach (var bit in docIdPath)
            {
                var bitLst = bit.ToList();
                var firstBit = bitLst.First().ToString();
                var secondBit = bitLst.LastOrDefault()?.ToString() == "" ? "0" :"";
                Console.WriteLine($@"{firstBit}/{secondBit}".Dump());
            }
           
        }

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