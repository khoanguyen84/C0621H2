using NUnit.Framework;
using UnitTest;

namespace NUnitTest
{
    public class MyMathTest
    {
        private MyMath myMath;
        [SetUp]
        public void Setup()
        {
            myMath = new MyMath();
        }

        [Test]
        public void Test_Sum_01()
        {
            Assert.AreEqual(10, myMath.Sum(3, 7));
            Assert.AreNotEqual(11, myMath.Sum(5, 5));
        }

        [TestCase(10)]
        [TestCase(-10)]
        [TestCase(0)]
        public void Test_Sum_02(int number)
        {
            Assert.AreEqual(number, myMath.Sum(0, number));
        }
    }
}