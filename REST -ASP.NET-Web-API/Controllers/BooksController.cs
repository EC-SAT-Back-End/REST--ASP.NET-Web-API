using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace REST__ASP.NET_Web_API.Controllers
{
    public class BooksController : ApiController
    {
        public string GetBook(string title , int nuberrofPage)
        {
            return string.Format("Tite = {0} , Number Of Page = {1}",title , nuberrofPage);
        }
    }
}
