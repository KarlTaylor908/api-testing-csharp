namespace APITestDemo.Utilities
{
    public class TestBase
    {
        protected HttpClient Client;

        [SetUp]
        public void Setup()
        {
            Client = new HttpClient
            {
                BaseAddress = new System.Uri("https://jsonplaceholder.typicode.com/")
            };
        }
        [TearDown]
        public void TearDown()
        {
            Client.Dispose();
        }
    }
}
