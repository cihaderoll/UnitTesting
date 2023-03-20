using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetProject;

namespace XUnitTestDemo
{
    public class PikachuTest
    {
        public readonly Pikachu Pikachu;

        public PikachuTest()
        {
            Pikachu = new Pikachu();
        }

        [Fact]
        public void Pikachu_GetPikachuIfZero_ReturnPikachu()
        {
            //arrange - whatever you need
            int num = 0;
            string expected = "new pikachu";

            //act
            var result = Pikachu.GetPikachuIfZero(num);

            //assert
            Assert.Equal(expected, result);
        }

    }
}
