using CinemaBot.Answer.Enums;
using System.Collections.Generic;

namespace CinemaBot.Answer
{
    public class AnswerRepository
    {
        public static List<AnswerModel> List()
        {
            return new List<AnswerModel>
            {
                new AnswerModel
                {
                    Keywords = new List<string>{
                        "oi",
                        "oie",
                        "ola",
                        "hello",
                        "hey"
                    },
                    Response = "Olá, como posso te ajudar?"
                },

                new AnswerModel
                {
                    Keywords = new List<string>{
                        "cartaz",
                        "passando",
                        "filme",
                        "filmes"
                    },
                    Response = "Estes são os filmes em cartaz: ",
                    Action = ActionAnswer.ListarFilmes
                },

                new AnswerModel
                {
                    Keywords = new List<string>{
                        "filme",
                        "filmes",
                        "cartaz",
                        "passando",
                        "romantico",
                        "romance",
                        "amor",
                        "paixao"
                    },
                    Response = "Estes são os filmes de romance e suas sessões: ",
                    Action = ActionAnswer.ListarRomances
                },

                new AnswerModel
                {
                    Keywords = new List<string>{
                        "filme",
                        "filmes",
                        "cartaz",
                        "passando",
                        "comedia",
                        "engracado",
                        "engracados",
                        "risada"
                    },
                    Response = "Estes são os filmes de comédia e suas sessões: ",
                    Action = ActionAnswer.ListarComedias
                },

                new AnswerModel
                {
                    Keywords = new List<string>{
                        "filme",
                        "filmes",
                        "cartaz",
                        "passando",
                        "acao",
                        "agitado",
                        "agitados"
                    },
                    Response = "Estes são os filmes de Ação e suas sessões: ",
                    Action = ActionAnswer.ListarAcao
                },

                new AnswerModel
                {
                    Keywords = new List<string>{
                        "filme",
                        "filmes",
                        "cartaz",
                        "passando",
                        "aventura",
                        "ventura",
                        "peripecia",
                        "peripecias"
                    },
                    Response = "Estes são os filmes de Aventura e suas sessões: ",
                    Action = ActionAnswer.ListarAventuras
                }
            };
        }
    }
}