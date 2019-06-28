using NUnit.Framework;
using Application.UseCases.Query;

namespace Application.UnitTests
{
    [TestFixture]
    public class ReadUseCaseTests
    {

        [Test]
        public void Execute_WhenCalledWithExistingName_ShouldReturnUserDTO()
        {
            var fakeUserRepository = new FakeUserRepository();

            var readUseCase = new ReadUseCase(fakeUserRepository);

            var user = readUseCase.Execute("Name 1");

            Assert.That(user.Name, Is.EqualTo("Name 1"));
        }

    }
}

