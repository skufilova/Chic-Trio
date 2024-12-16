using ChicTrio;
using NUnit.Framework;
namespace TestProject1
{
    [TestFixture]
    public class ProgramTests
    {

        [Test]
        public void CheckFermat_WhenInvalidCondition_ReturnsNoSolutionMessage()
        {
            // Arrange
            var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            Program.CheckFermat(1, 2, 3, 3);

            // Assert
            var result = sw.ToString().Trim();
            Assert.AreEqual("Нет целого решения для 1^3 + 2^3 = 3^3", result);
        }

        [Test]
        public void CheckFermat_WhenNIsLessThanOrEqualTo2_DoesNotOutput()
        {
            // Arrange
            var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            Program.CheckFermat(1, 2, 3, 2); // n = 2

            // Assert
            var result = sw.ToString().Trim();
            Assert.IsEmpty(result); // Ожидаем, что ничего не будет выведено
        }
    }
}