using SurveyFormsApp.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Concrete
{
    public class DateFormatQuestion : QuestionBase
    {
        public DateFormatQuestion(string name) : base(name, QuestionType.DateFormatQuestion)
        {
        }
        public DateTime Answer { get; set; }

        public void CheckAnswer(DateTime answer) 
        {
            if(answer != default(DateTime))
            {
                Answer = answer;
            }
            else
            {
                throw new Exception("Boş bir tarih değeri girdiniz");
            }
        }
    }
}
