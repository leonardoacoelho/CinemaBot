using System.Collections.Generic;

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
                    Genre = "Romance",
                    Session  = new List<string>
                    {
                        "10:30 às 12:15",
                        "14:00 às 15:45",
                        "16:30 às 18:15",
                        "21:00 às 22:45"
                    }
                },

                new MovieModel
                {
                    Name = "500 dias com ela",
                    Genre = "Romance",
                    Session  = new List<string>
                    {
                        "10:00 às 12:45",
                        "14:30 às 16:15",
                        "16:00 às 17:45",
                        "21:30 às 23:15"
                    }
                },

                new MovieModel
                {
                    Name = "Kingsman: The Golden Circle",
                    Genre = "Aventura",
                    Session  = new List<string>
                    {
                        "10:30 às 12:15",
                        "14:00 às 15:45",
                        "16:30 às 18:15",
                        "21:00 às 22:45"
                    }
                },

                new MovieModel
                {
                    Name = "Jogos Vorazes",
                    Genre = "Aventura",
                    Session  = new List<string>
                    {
                        "10:00 às 12:45",
                        "14:30 às 16:15",
                        "16:00 às 17:45",
                        "21:30 às 23:15"
                    }
                },

                new MovieModel
                {
                    Name = "O Batman",
                    Genre = "Acao",
                    Session  = new List<string>
                    {
                        "10:30 às 12:15",
                        "14:00 às 15:45",
                        "16:30 às 18:15",
                        "21:00 às 22:45"
                    }
                },

                new MovieModel
                {
                    Name = "Logan",
                    Genre = "Acao",
                    Session  = new List<string>
                    {
                        "10:00 às 12:45",
                        "14:30 às 16:15",
                        "16:00 às 17:45",
                        "21:30 às 23:15"
                    }
                },

                new MovieModel
                {
                    Name = "As Branquelas",
                    Genre = "Comedia",
                    Session  = new List<string>
                    {
                        "10:30 às 12:15",
                        "14:00 às 15:45",
                        "16:30 às 18:15",
                        "21:00 às 22:45"
                    }
                },

                new MovieModel
                {
                    Name = "Gente Grande",
                    Genre = "Comedia",
                    Session  = new List<string>
                    {
                        "10:00 às 12:45",
                        "14:30 às 16:15",
                        "16:00 às 17:45",
                        "21:30 às 23:15"
                    }
                }
            };
        }
    }
}