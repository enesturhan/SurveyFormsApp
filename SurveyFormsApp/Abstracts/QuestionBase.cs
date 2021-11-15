using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Abstracts
{
    public enum QuestionType
    {
        YesNoQuestion=1,
        ShortAnswerQuestion=2,
        ParagraphQuestion=3,
        DateFormatQuestion=4,
        MultipleChoice=5,
        CheckBoxQuestion=6

    }
    public abstract class QuestionBase
    {
        protected QuestionBase(string name,QuestionType questionType)
        {
            CheckQuestion(name);
            Name = name;
           
        }

        public QuestionType questionType { get;protected set; }

        public string Name { get;protected set; }

        public string Answers { get;protected set; }

        protected void CheckQuestion(string name)
        {
            if (name =="")
            {
                throw new Exception("bos bir soru girdiniz");
            }
        }

    }
    
}
