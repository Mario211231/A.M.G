using A.M.G.Data.Base;
using A.M.G.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.M.G.Data.AMGServices
{
   
    
   public class AMGActorsService :EntityBaseRepository<AMGActor>, IAMGActorsService
    {
        public AMGActorsService(AMGDbContext context) : base(context) { }
    }
}
