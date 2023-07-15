namespace ChallengeApp.Tests
{
    public class IntNumbersTest
    {
        [Test]
        public void AreTheIntNumbersEqual()
        {
            //arrange
            int number1 = 16524;
            int number2 = 16524;

            //act

            //assert
            Assert.AreEqual(number1, number2);
        }
    }
}
