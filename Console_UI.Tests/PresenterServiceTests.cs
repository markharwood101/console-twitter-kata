using System;
using NUnit.Framework;
using Console_UI.Services;

namespace Console_UI.UnitTests
{
    [TestFixture]
    public class PresenterServiceTests
    {

        [Test]
        public void GetElapsedTime_Lessthan1Minute_ShouldShouldContainCorrectOutput()
        {
            var postedTime = DateTime.Now.AddSeconds(-1);

            var result = PresenterService.GetElapsedTime(postedTime);

            Assert.That(result, Is.EqualTo("(1 seconds ago.)"));
        }

        [Test]
        public void GetElapsedTime_Morethan1Minute_ShouldContainCorrectOutput()
        {
            var postedTime = DateTime.Now.AddSeconds(-61);

            var result = PresenterService.GetElapsedTime(postedTime);

            Assert.That(result, Is.EqualTo("(1 minutes and 1 seconds ago.)"));
        }

    }
}
