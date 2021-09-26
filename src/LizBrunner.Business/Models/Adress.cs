using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LizBrunner.Business.Models.Util.Enums;

namespace LizBrunner.Business.Models
{
    public class Adress: Entity
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Zipcode { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public State State { get; set; }
       
        /* RF Relation */
        public Client Client { get; set; }
    }
}
