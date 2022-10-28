using Apiwithrelationship.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Apiwithrelationship.Controllers
{

    public class ValuesController : ApiController
    {
        Syed_companyEntities db = new Syed_companyEntities();

        public IQueryable <salary> getsalary()
        {

            return db.salaries;

        }
    }
}
