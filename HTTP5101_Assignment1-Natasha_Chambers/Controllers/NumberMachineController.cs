using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1_Natasha_Chambers.Controllers
{
    public class NumberMachineController : ApiController
    {
        /*
         * Question 5 Objective:
         * Create a method that returns an amount 
         * that has been multiplied, then squared, minus and then divided
         */

        /// <summary>
        /// This method takes a number multiplies it by 10
        /// squares that number, then minus 6, divided by 2
        /// </summary>
        /// <param name="id">input a number</param>
        /// <returns>a number</returns>
        /// <example> Get api/NumberMachine/10 -> 4997 </example>
        /// <example> Get api/NumberMachine/-5 -> 1247 </example>
        /// <example> Get api/NumberMachine/30 -> 4497 </example>
        public int Get(int id)
        {
            int multiply = id * 10;
            int square = multiply * multiply;
            int total = (square - 6 ) / 2;
            return total;
        }
    }
}
