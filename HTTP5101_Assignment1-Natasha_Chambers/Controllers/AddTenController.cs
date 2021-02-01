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
        //<summary>
        //Returns the integer input (id) plus 10
        //</summary>
        //
        //Examples/Tests
        //GET api/addten/21
        //GET api/addten/0
        //GET api/addten/-9
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
