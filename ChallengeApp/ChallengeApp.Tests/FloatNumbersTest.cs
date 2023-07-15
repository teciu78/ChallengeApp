namespace ChallengeApp.Tests
{
    public class FloatNumbersTest
    {
        [Test]
        public void AreTheFloatNumbersNotEqual()
        {
            //arrange
            float number1 = 0.22333f;
            float number2 = 2.4749f;

            //act

            //assert
            Assert.AreNotEqual(number1, number2);
        }
    }
}
