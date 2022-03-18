using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.M.G.Models
{
    public class AMGActor_Movie
    {

        public int MovieId { get; set; }
        public AMGMovie Movie { get; set; }

        public int ActorId { get; set; }
        public AMGActor Actor { get; set; }

    }
}
