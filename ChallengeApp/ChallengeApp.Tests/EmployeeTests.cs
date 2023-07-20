namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        
        [Test]
        public void SumAddedGradesOfTheEmployee()
        {
            var employee = new Employee("Franek", "Dzbanek", 45);
            employee.AddGrade(3.5f);
            employee.AddGrade(34.5f);
            employee.AddGrade(43.5f);

            var result = employee.GetStatistics();

            //Assert.AreEqual(81.5f,result.Sum);
            Assert.That(result.Sum, Is.EqualTo(81.5f));
        }

        [Test]
        public void CheckAllTheStatistics()
        {
            var employee = new Employee("Franek", "Dzbanek", 45);
            employee.AddGrade(3.5f);
            employee.AddGrade(34.5f);
            employee.AddGrade(43.5f);

            var result = employee.GetStatistics();

            //Assert.AreEqual(27.17f, float.Round(result.Average, 2));
            Assert.That(float.Round(result.Average, 2), Is.EqualTo(27.17f));

            //Assert.AreEqual(3.5f, float.Round(result.Min, 2));
            Assert.That(float.Round(result.Min, 2), Is.EqualTo(3.5f));

            //Assert.AreEqual(43.5f, float.Round(result.Max, 2));
            Assert.That(float.Round(result.Max, 2), Is.EqualTo(43.5f));
        }
    }
}
