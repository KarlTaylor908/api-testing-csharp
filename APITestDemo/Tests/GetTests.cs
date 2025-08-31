using APITestDemo.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestDemo.Tests
{
    public class GetTests : TestBase
    {
        [Test]
        public async Task GetPostByIdTest()
        {
            var response = await Client.GetAsync("posts/1");
            var body = await response.Content.ReadAsStringAsync();


            Assert.IsTrue(response.IsSuccessStatusCode);
            Assert.IsTrue(body.Contains("\"id\": 1"));
        }
    }
}
