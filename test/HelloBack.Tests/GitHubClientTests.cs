using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace HelloBack.Tests
{
    public class GitHubClientTests
    {
        [Fact]
        public async Task Foo()
        {
            //Arrange
            var gitHubClient = new GitHubClient(new HttpClient());
            var expected = HttpStatusCode.OK;

            //Act
            var actual = await gitHubClient.GetData();
            var content = await actual.Content.ReadAsStringAsync();

            //Assert
            Assert.Equal(expected, actual.StatusCode);
            Assert.NotEmpty(content);
        }
    }
}
