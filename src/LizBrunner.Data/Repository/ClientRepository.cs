using LizBrunner.Business.Models;
using LizBrunner.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LizBrunner.Data.Context;

namespace LizBrunner.Data.Repository
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {

        public ClientRepository(LizDbContext context) : base(context){ }

       
       

    }
}
