using CinemaBot.Answer.Enums;
using System.Collections.Generic;

namespace CinemaBot.Answer
{
    public class AnswerModel
    {
        public List<string> Keywords { get; set; }
        public string Response { get; set; }
        public ActionAnswer Action { get; set; }
    }
}