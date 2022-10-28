using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Webapi2.Controllers
{
    public class EmployeesDataController : ApiController
    {
        public string[] myemployees = { "Adil", "faraz", "waqas" };
        [HttpGet]
        public string[] GetEmployess()
        {
            return myemployees;
        }

        [HttpGet]
        // perameter must bhi id other its not working 
        // Id mai to jo value aye gay index num equal hogay or index num ke hisaab se data fatch kri gay
        public string GetEmployessByIndex(int id)
        {
            return myemployees[id];
        }
    }
}
