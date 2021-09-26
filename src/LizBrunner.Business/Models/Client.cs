using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LizBrunner.Business.Models.Util.Enums;

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
        public Guid AdressId { get; set; }

        /* RF Relation */
        public Adress Adress { get; set; }
    


    }
}
