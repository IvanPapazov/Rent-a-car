using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_a_car.Models
{
    public class AppUsers: IdentityUser
    {
        public string fName { get; set; }
        public string sName { get; set; }
        public string lName { get; set; }
        public string EGN { get; set; }
    }
}
