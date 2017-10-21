using CinemaBot.Answer.Enums;
using CinemaBot.Movie;
using CinemaBot.Tools;
using System.Linq;
using System.Text;

namespace CinemaBot.Answer
{
    public class AnswerLogic
    {
        public static string GetAnswer(string text)
        {
            var words = text.Split(' ').ToList();

            var answers = AnswerRepository.List();

            var maxOccurrences = 0;

            AnswerModel model = null;

            foreach (var word in words)
            {
                foreach (var answer in answers)
                {
                    var occurrences = answer.Keywords.Where(x => word.NormalizeText().ToLower().Contains(x.NormalizeText().ToLower())).Count();
                    if (occurrences > maxOccurrences)
                    {
                        model = answer;
                        maxOccurrences = occurrences;
                    }
                }
            }

            if (model != null)
            {
                var sb = new StringBuilder();
                sb.Append(model.Response);

                switch (model.Action)
                {
                    case ActionAnswer.Nenhuma:
                        break;
                    case ActionAnswer.ListarFilmes:
                        var filmes = MovieRepository.List();
                        foreach (var filme in filmes)
                        {
                            sb.Append($"<br /> -{filme.Name}");
                        }
                        break;
                    case ActionAnswer.ListarComedias:
                        var filmesComedias = MovieRepository.List().Where(x => x.Genre == "Comedia");
                        foreach (var filme in filmesComedias)
                        {
                            sb.Append($"<br /> -{filme.Name}");
                        }
                        break;
                    case ActionAnswer.ListarRomances:
                        var filmesRomanticos = MovieRepository.List().Where(x => x.Genre == "Romance");
                        foreach (var filme in filmesRomanticos)
                        {
                            sb.Append($"<br /> -{filme.Name}");
                        }
                        break;
                    case ActionAnswer.ListarAcao:
                        var filmesAcao = MovieRepository.List().Where(x => x.Genre == "Acao");
                        foreach (var filme in filmesAcao)
                        {
                            sb.Append($"<br /> -{filme.Name}");
                        }
                        break;
                    case ActionAnswer.ListarAventuras:
                        var filmesAventura = MovieRepository.List().Where(x => x.Genre == "Aventura");
                        foreach (var filme in filmesAventura)
                        {
                            sb.Append($"<br /> -{filme.Name}");
                        }
                        break;
                }
                return sb.ToString();
            }
            else
                return "Não consegui entender. Tente me perguntar de uma forma diferente!";
        }
    }
}