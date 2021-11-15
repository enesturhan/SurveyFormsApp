using SurveyFormsApp.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Concrete
{
    public class ShortAnswerQuestion :QuestionBase
    {
        public ShortAnswerQuestion(string name) : base(name, QuestionType.ShortAnswerQuestion)
        {
        }

        public string Answer { get; set; }

        public void CheckAnswer(string answer)
        {
            if (answer.Length < 30)
            {
                Answer = answer;
            }
            else
            {
                throw new Exception("Karakter sayısından fazla bir cevap değeri girdiniz");
            }

        }
    }
}
