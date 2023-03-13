namespace XUnitTestDemo
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        public void PassingTest(int value)
        {
            Assert.True(IsOdd(value));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(4, Add(3, 2));
        }

        int Add(int a, int b)
        {
            return a + b;
        }

        bool IsOdd(int val)
        {
            return val % 2 == 1;
        }
    }
}