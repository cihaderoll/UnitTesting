using System;
using System.Collections;
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
            Assert.Equal(2, _sut.Add(3));
        }

        [Theory]
        [MemberData(nameof(ProvideTestData))]
        public void TestAddWithManyData(int expected, params int[] valuesToAdd)
        {
            foreach (var value in valuesToAdd)
            {
                _sut.Add(value);
            }

            Assert.Equal(expected, _sut.Value);
        }

        [Theory]
        [ClassData(typeof(DivideTestData))]
        public void TestDivideWithManyData(int expected, params int[] valuesToAdd)
        {
            foreach (var value in valuesToAdd)
            {
                _sut.Divide(value);
            }

            Assert.Equal(expected, _sut.Value);
        }

        public static IEnumerable<object[]> ProvideTestData()
        {
            yield return new object[] { 30, new int[] { 10, 20 } };
            yield return new object[] { 70, new int[] { 3, 67 } };
            yield return new object[] { 25, new int[] { 12, 13 } };
            yield return new object[] { 53, new int[] { 40, -25, 8, 6, 24 } };
        }
    }

    public class DivideTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 2, new int[] { 50, 25 } };
            yield return new object[] { 5, new int[] { 15, 3 } };
            yield return new object[] { 45, new int[] { 15, 35 } };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
