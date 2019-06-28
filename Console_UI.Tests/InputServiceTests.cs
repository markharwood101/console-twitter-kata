using Console_UI.Services;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class InputServiceTests
    {

        [Test]
        [TestCase("Name", "read")]
        [TestCase("Name -> Word1 Word2", "post")]
        [TestCase("Name follows Poster", "follows")]
        [TestCase("Name wall", "wall")]
        public void GetCommand_WhenCalled_ShouldReturn(string input, string ExpectedResult)
        {
            string result = InputService.GetCommand(input);

            Assert.That(result, Is.EqualTo(ExpectedResult));
        }
    }
}

