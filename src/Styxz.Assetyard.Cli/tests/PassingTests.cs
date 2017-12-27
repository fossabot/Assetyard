using Xunit;

namespace Styxz.Assetyard.Cli.Tests
{
    public class PassingTests
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, 2 + 2);
        }
    }
}