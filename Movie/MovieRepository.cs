using System.Collections.Generic;
using System.Linq;

namespace CinemaBot.Movie
{
    public class MovieRepository
    {
        public static List<MovieModel> List()
        {
            return new List<MovieModel>
            {
                new MovieModel
                {
                    Name = "De repente é Amor",
                    Genre = "Romance"
                },

                new MovieModel
                {
                    Name = "300 dias com ela",
                    Genre = "Romance"
                },

                new MovieModel
                {
                    Name = "Kingsman: The Golden Circle",
                    Genre = "Aventura"
                },

                new MovieModel
                {
                    Name = "Jogos Vorazes",
                    Genre = "Aventura"
                },

                new MovieModel
                {
                    Name = "O Batman",
                    Genre = "Acao"
                },

                new MovieModel
                {
                    Name = "Logan",
                    Genre = "Acao"
                },

                new MovieModel
                {
                    Name = "As Branquelas",
                    Genre = "Comedia"
                },

                new MovieModel
                {
                    Name = "Gente Grande",
                    Genre = "Comedia"
                }
            };
        }
    }
}