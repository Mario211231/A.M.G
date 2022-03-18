using A.M.G.Data.Base;
using A.M.G.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.M.G.Data.AMGServices
{
    public class AMGCinemasService : EntityBaseRepository<AMGCinema>, ICinemasService
    {
        public AMGCinemasService(AMGDbContext context) : base(context)
        {


        }
    }
}
