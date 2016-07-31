using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class TestController : ApiController
    {
        public int get()
        {
            return 1;
            //Console.WriteLine(num.ToString() + " " + (num + 2).ToString());
        }
        //public void put()
        //{

        //}
        //public void post()
        //{

        //}  
        //public void delete()
        //{

        //}
    }
}
