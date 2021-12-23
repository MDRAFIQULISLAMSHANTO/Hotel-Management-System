using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Guest
    {
        public int GuestId { get; set; }
        public string GuestName { get; set; }
        public string GuestPhone { get; set; }
        public string GuestCountry { get; set; }
        public string GuestPassword { get; set; }
        public string GuestUserName { get; set; }
    }
}
