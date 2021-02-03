using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1_Natasha_Chambers.Controllers
{
    public class SquareController : ApiController
    {
        /*
         * Question 2 Objective:
         * Create a method that returns an amount that is 
         * the orignal amount squared
         */

        /// <summary>
        /// This method will take in an input for a number  
        /// square it and then output the squared number
        /// </summary>
        /// <param name="id">input of a number</param>
        /// <returns>a new number</returns>
        /// <example>
        /// GET api/AddTen/2 -> 4
        /// GET api/AddTen/-2 -> 4
        /// GET api/AddTen/10 -> 100
        /// </example>
        public int Get(int id)
        {
            return id * id;
        }
    }
}
