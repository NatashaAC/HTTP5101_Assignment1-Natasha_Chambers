using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1_Natasha_Chambers.Controllers
{
    public class GreetingController : ApiController
    {
        /*
         * Question 3 Objective:
         * Create a method that uses the greeting "Hello World!"
         */

        /// <summary>
        /// This method will produce a string that says "Hello World!"
        /// </summary>
        /// <returns>a string</returns>
        /// <example>
        /// curl -d "" "localhost:hostnumber/api/Greeting"
        /// </example>
        public string Post()
        {
            return "Hello World!";
        }

        /*
         * Question 4 Objective:
         * Create a method that will produce a string based on the 
         * amount of people you would like to greet
         */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Get(int id)
        {
            // The value of people to greet
            int people = id;
            string greeting = "Greetings to " + people.ToString() + "people!";
            return greeting;
        }
    }
}
