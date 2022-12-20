using Xunit;
using MyProject1;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Program.Factorial(5)==120);
        }
        [Fact]
        public void Test2()
        {
            Assert.True(Program.Factorial(4) == 24);
        }
        [Fact]
        public void Test3()
        {
            Assert.True(Program.Factorial(3) == 6);
        }
    }
}