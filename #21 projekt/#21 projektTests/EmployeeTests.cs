using _21_projekt;

namespace _21_projektTests
{
    public class Tests
    {

        [Test]
        public void WhenEmployee1CollectRates_ThenCorrectResult()
        {
            //arrange
            Employee employee = new Employee("Magda", "Kowalska", 21);
            employee.AddRate(2);
            employee.AddRate(8);
            employee.AddRate(8);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(18, result);
        }

        [Test]
        public void WhenEmployee2CollectRates_ThenCorrectResult()
        {
            //arrange
            Employee employee = new Employee("Janka", "Kowalczyk", 63);
            employee.AddRate(10);
            employee.AddRate(-7);
            employee.AddRate(1);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(4, result);
        }

        [Test]
        public void WhenEmployee3CollectRates_ThenCorrectResult()
        {
            //arrange
            Employee employee = new Employee("Hania", "Makowa", 32);
            employee.AddRate(-9);
            employee.AddRate(-1);
            employee.AddRate(5);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(-5, result);
        }
    }
}
