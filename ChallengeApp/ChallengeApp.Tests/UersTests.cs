
namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectPoints_ShouldReturnSumOfPoints()
        {
            //arrange
            var user = new User("Witek", "123");
            user.AddScore(5);
            user.AddScore(6);

            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(11, result);
        }

        [Test]
        public void WhenUserLosePoints_ShouldReturnSumOfPoints()
        {
            //arrange
            var user = new User("Witek", "123");
            user.AddScore(5);
            user.AddScore(6);
            user.SubtractScore(3);
            user.SubtractScore(2);

            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(6, result);
        }
    }
}