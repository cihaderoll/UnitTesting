using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetProject
{
    public class Pikachu
    {
        /// <summary>
        /// returns new pikachu string if num is 0 
        /// </summary>
        public string GetPikachuIfZero(int num)
        {
            return num == 0 ? "new pikachu" : "not zero";
        }
    }
}
