using APITestDemo.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestDemo.Tests
{
    public class DeleteTests : TestBase
    {
        [Test]
        public async Task DeletePostTest()
        {
            var response = await Client.DeleteAsync("posts/1");
            var body = await response.Content.ReadAsStringAsync();

            Assert.That((int)response.StatusCode, Is.EqualTo(200));


        }
    }
}
