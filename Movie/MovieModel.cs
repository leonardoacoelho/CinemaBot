using System.Collections.Generic;

namespace CinemaBot.Movie
{
    public class MovieModel
    {
        public string Genre { get; set; }
        public string Name { get; set; }
        public List<string> Session { get; set; }
    }
}