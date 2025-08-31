using APITestDemo.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestDemo.Tests
{
    public class PutTests : TestBase
    {

        [Test]
        public async Task CreatePostTest()
        {
            var json = "{\"title\":\"updated title\", \"body\": \"updated bar\", \"userid\":1}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Client.PutAsync("posts/1", content);
            var body = await response.Content.ReadAsStringAsync();

            Assert.IsTrue(response.IsSuccessStatusCode, "Was not a success");
            Assert.That(body.Contains("\"title\": \"updated title\""), "Title is wrong");
            Assert.That(body.Contains("\"body\": \"updated bar\""), "Body is wrong");
            Assert.That(body.Contains("\"userid\": 1"), "UserId is wrong");


        }

    }
}

