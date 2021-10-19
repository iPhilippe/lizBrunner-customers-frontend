using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LizBrunner.Business.Models.Util;

namespace LizBrunner.Business.Models
{
    public class Client : Entity
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public Genders Gender { get; set; }
        public string CPF { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsReceivingInformation { get; set; } = false;
        public bool IsVip { get; set; } = false;
        public DateTime RegisterDate { get; set; }

        #region adress
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Zipcode { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public States State { get; set; }
        #endregion

    }
}
