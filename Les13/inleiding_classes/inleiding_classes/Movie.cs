using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inleiding_classes
{
    internal class Movie
    {
        public string Director { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Producer { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double ImdbRating { get; set; }
        public double RTRating { get; set; }
        public int RunTime { get; set; }
        public bool Is3D { get; set; }
        public List<string> Cast { get; set; }

        // constructor --> welke properties MOETEN ingevuld worden bij aanmaak
        public Movie(string title, string director)
        {
            Title = title;
            Director = director;
        }
    }
}
