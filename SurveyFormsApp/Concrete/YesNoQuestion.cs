
using SurveyFormsApp.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Concrete
{
    public enum YesNoQuestionType
    {
        Yes,
        No
    }
    public class YesNoQuestion : QuestionBase
    {

        public YesNoQuestion(string name) : base(name, QuestionType.YesNoQuestion)
        {


        }
        public string Answer { get; set; }
        public void CheckAnswer(YesNoQuestionType yesNoQuestionType)
        {
            if (yesNoQuestionType.Equals(YesNoQuestionType.Yes))
            {
                Answer = YesNoQuestionType.Yes.ToString();
            }
            else
            {
                Answer = YesNoQuestionType.No.ToString();
            }
           
        }
    }
}
