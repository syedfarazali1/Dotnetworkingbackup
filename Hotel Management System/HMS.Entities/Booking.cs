using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Entities
{
    class Booking
    {
        public int ID { get; set; }
        public int AccomodationID { get; set; }
        public Accomodation Accomodation { get; set; }

        public DateTime FromDate { get; set; }
            
        /// <summary>
        /// No Of Stay Night
        /// </summary>
        public int Duration { get; set; }
    }
}
