using _21_projekt;

namespace _21_projektTests
{
    public class Tests
    {

        [Test]
        public void WhenEmployee1CollectGrades_ThenCorrectMaxValue()
        {
            //arrange
            EmployeeInMemory employee1 = new EmployeeInMemory("Magda", "Kowalska", "k");
            employee1.AddGrade(2);
            employee1.AddGrade(8);
            employee1.AddGrade(8);

            //act
            var statistics = employee1.GetStatistics();

            //assert
            Assert.AreEqual(8, statistics.Max);
        }

        [Test]
        public void WhenEmployeeCollectGrades_ThenCorrectMinValue()
        {
            //arrange
            EmployeeInMemory employee = new EmployeeInMemory("Ala", "Nowak", "k");
            employee.AddGrade(50);
            employee.AddGrade(5);
            employee.AddGrade(9);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(5, statistics.Min);
        }

        [Test]
        public void WhenEmployeeCollectGrades_ThenCorrectAverageValue()
        {
            //arrange
            EmployeeInMemory employee = new EmployeeInMemory("Ala", "Nowak", "k");
            employee.AddGrade(50);
            employee.AddGrade(30);
            employee.AddGrade(10);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(30, statistics.Average);
        }

        [Test]
        public void WhenEmployeeCollectGrades_ThenCorrectAverageLetterValue()
        {
            //arrange
            EmployeeInMemory employee = new EmployeeInMemory("Ala", "Nowak", "k");
            employee.AddGrade(100);
            employee.AddGrade(90);
            employee.AddGrade(80);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual('A', statistics.AverageLetter);
        }
    }
}
