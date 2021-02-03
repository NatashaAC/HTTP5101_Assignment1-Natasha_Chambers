using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1_Natasha_Chambers.Controllers
{
    public class AddTenController : ApiController
    {
        /*
         * Question 1 Objective:
         * Create a method that returns an amount that is 
         * ten more than the orignal amount entered
         */

        /// <summary>
        /// This method will take in an input for a number  
        /// add ten to it and then output the total
        /// </summary>
        /// <param name="id">input of a random number</param>
        /// <returns>a new number</returns>
        /// <example>
        /// GET api/AddTen/21 -> 31
        /// GET api/AddTen/0 -> 20
        /// GET api/AddTen/-9 -> 10
        /// </example>
        public int Get(int id)
        {
            int total = id + 10;
            return total;
        }
    }
}
