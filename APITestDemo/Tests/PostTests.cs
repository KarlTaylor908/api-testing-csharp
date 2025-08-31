using APITestDemo.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestDemo.Tests
{
    public class PostTests : TestBase
    {
        [Test]
        public async Task CreatePostTest()
        {
            var json = "{\"title\":\"fool\", \"body\": \"bar\", \"userid\":1}";
            var content =new StringContent (json, Encoding.UTF8,"application/json");

            var response = await Client.PostAsync("posts",content);
            var body = await response.Content.ReadAsStringAsync();

            Assert.IsTrue(response.IsSuccessStatusCode, "Was not a success");
            Assert.That(body.Contains("\"title\": \"fool\""), "Title is wrong");
            Assert.That(body.Contains("\"body\": \"bar\""),"Body is wrong");
            Assert.That(body.Contains("\"userid\": 1"),"UserId is wrong");


        }

    }
}
