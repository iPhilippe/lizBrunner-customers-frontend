using LizBrunner.Business.Interfaces;
using LizBrunner.Business.Models;
using LizBrunner.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizBrunner.Data.Repository
{
    public class AdressRepository : Repository<Adress>, IAdressRepository
    {

        public AdressRepository(LizDbContext context) : base(context) { }

    }
}
