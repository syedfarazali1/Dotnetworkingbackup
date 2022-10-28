using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Entities
{
    class Accomodation
    {
        public int Id { get; set; }
        public int AccomodationPackageID { get; set; }
        public AccomodationPackage AccomodationPackage { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
    }
}
