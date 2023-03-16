using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TargetProject;

namespace XUnitTestDemo
{
    public class CalculatorTest
    {
        private readonly Calculator _sut;

        public CalculatorTest()
        {
            _sut = new Calculator();
        }

        [Fact]
        public void TestAdd()
        {
            Assert.Equal(2, _sut.Add(3, 3));
        }

        [Theory]
        [MemberData(nameof(ProvideTestData))]
        public void TestAddWithManyData(int expected, params int[] valuesToAdd)
        {
            Assert.Equal(expected, _sut.Add(valuesToAdd[0], valuesToAdd[1]));
        }

        public static IEnumerable<object[]> ProvideTestData()
        {
            yield return new object[] { 30, new int[] { 10, 20 } };
            yield return new object[] { 12, new int[] { 3, 67 } };
            yield return new object[] { 25, new int[] { 12, 13 } };
            yield return new object[] { 15, new int[] { 40, -25 } };
        }
    }
}
