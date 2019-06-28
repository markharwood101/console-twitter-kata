using NUnit.Framework;
using System.Linq;
using Application.UseCases.Query;

namespace Application.UnitTests
{
    [TestFixture]
    public class GetWallUseCaseTests
    {

        [Test]
        public void Execute_WhenCalledWithExistingName_ShouldReturnListOf4Post_DTO()
        {
            var fakeUserRepository = new FakeUserRepository();

            var getWallUseCase = new GetWallUseCase(fakeUserRepository);

            // Data in FakeRepository is setup to model users posts and subscriptions to return 4 posts for "Name 1"
            var posts = getWallUseCase.Execute("Name 1").ToList();

            Assert.That(posts.Count, Is.EqualTo(4));
        }

    }
}