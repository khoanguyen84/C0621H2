using System;
using UnitTest;
using Xunit;

namespace xUnitTest
{
    public class xUnitMyMath
    {
        private MyMath myMath;
        public xUnitMyMath()
        {
            myMath = new MyMath();
        }

        [Fact]
        public void xUnit_Sum_01()
        {
            Assert.Equal(10, myMath.Sum(4, 6));
        }

        [Theory]
        [InlineData(10)]
        [InlineData(-10)]
        [InlineData(0)]
        public void xUnit_Sum_02(int number)
        {
            Assert.Equal(number, myMath.Sum(0, number));
        }
    }
}
