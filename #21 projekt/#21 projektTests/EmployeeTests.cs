using _21_projekt;

namespace _21_projektTests
{
    public class Tests
    {

        [Test]
        public void WhenEmployee1CollectGrades_ThenCorrectStatistics()
        {
            //arrange
            Employee employee1 = new Employee("Magda", "Kowalska");
            employee1.AddGrade(2);
            employee1.AddGrade(8);
            employee1.AddGrade(8);

            //act
            var statistics = employee1.GetStatistics();

            //assert
            Assert.AreEqual(8, statistics.Max);
            Assert.AreEqual(2, statistics.Min);
            Assert.AreEqual(6, statistics.Average);
        }

        [Test]
        public void WhenEmployee2CollectGrades_ThenCorrectStatistics()
        {
            //arrange
            Employee employee2 = new Employee("Ala", "Nowak");
            employee2.AddGrade(-5);
            employee2.AddGrade(5);
            employee2.AddGrade(9);

            //act
            var statistics = employee2.GetStatistics();

            //assert
            Assert.AreEqual(9, statistics.Max);
            Assert.AreEqual(-5, statistics.Min);
            Assert.AreEqual(3, statistics.Average);
        }
    }
}
