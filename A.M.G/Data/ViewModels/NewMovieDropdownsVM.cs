using A.M.G.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.M.G.Data.ViewModels
{
    public class NewMovieDropdownsVM
    {
        public NewMovieDropdownsVM()
        {
            Producers = new List<AMGProducer>();
            Cinemas = new List<AMGCinema>();
            Actors = new List<AMGActor>();
        }

        public List<AMGProducer> Producers { get; set; }
        public List<AMGCinema> Cinemas { get; set; }
        public List<AMGActor> Actors { get; set; }
    }

}


