using _21_projekt;

namespace _21_projektTests
{
    public class TypeTests
    {
        [Test]
        public void WhenDifferentAgeThenReturnSameResult()
        {
            //arrange
            int age1 = 6;
            int age2 = 6;

            //act


            //assert
            Assert.AreEqual(age1, age2);
        }

        [Test]
        public void WhenDifferentNameThenReturnNotEqualResult()
        {
            //arrange
            string name1 = "Ania";
            string name2 = "Beata";

            //act


            //assert
            Assert.AreNotEqual(name1, name2);
        }
    }
}
