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
        //<summary>
        //Returns the square of the integer input (id)
        //</summary>
        //
        //Examples/Tests
        //GET api/square/2
        //GET api/square/-2
        //GET api/square/10
        public int Get(int id)
        {
            return id * id;
        }
    }
}
