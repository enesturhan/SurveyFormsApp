using SurveyFormsApp.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Concrete
{
    public class ParagraphQuestion : QuestionBase
    {
        public ParagraphQuestion(string name) : base(name, QuestionType.ParagraphQuestion)
        {

        }
        public string Answer { get;private set; }

        public void CheckAnswer(string answer)
        {
            if (answer.Length < 200)
            {
                Answer = answer;
            }
            else
            {
                throw new Exception("200 KARAKTERDEN FAZLA BİR DEĞER GİRDİNİZ");
            }
        }
    }
}
