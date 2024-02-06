using Challenge1App;

namespace Challange1App.Tests
{
    public class Tests
    {
        [Test]
        public void WheneEmployeePointsAreCalculated_ShouldReturnedSum()
        {
            var employee2 = new Employee("Adam", "Kowalski", "29");
            employee2.AddScore(7);
            employee2.AddScore(6);
            employee2.AddScore(8);
            employee2.AddScore(3);
            employee2.AddScore(4);
            
            var result = employee2.Result;

            Assert.AreEqual(28, result);
        }
        [Test]
        public void WheneEmployee2PointsAreCalculated_ShouldReturnedSum()
        {
            var employee2 = new Employee("Marek", "Kowalski", "40");
            employee2.AddScore(-5);
            employee2.AddScore(6);
            employee2.AddScore(9);
            employee2.AddScore(-5);
            employee2.AddScore(2);

            var result = employee2.Result;

            Assert.AreEqual(7, result);
        }
        [Test]
        public void WheneEmployee3PointsAreCalculated_ShouldReturnedSum()
        {
            var employee3 = new Employee("Marita", "Kowalska", "35");
            employee3.AddScore(-3);
            employee3.AddScore(-4);
            employee3.AddScore(-10);
            employee3.AddScore(-1);
            employee3.AddScore(-5);

            var result = employee3.Result;

            Assert.AreEqual(-23, result);
        }
    }
}