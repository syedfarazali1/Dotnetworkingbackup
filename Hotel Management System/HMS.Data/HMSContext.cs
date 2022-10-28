using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Text;

namespace HMS.Data
{
    public class HMSContext : DbContext
    {
        protected HMSContext() : base("name=HotelManagementSystemConnectionString")
        {

        }
    }
}
