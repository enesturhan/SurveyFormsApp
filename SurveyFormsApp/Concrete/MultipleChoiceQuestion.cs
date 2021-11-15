using SurveyFormsApp.Abstracts;
using SurveyFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Concrete
{
    public class MultipleChoiceQuestion : QuestionBase
    {
        public MultipleChoiceQuestion(string name) : base(name, QuestionType.MultipleChoice)
        {

        }
        public bool isChecked { get; set; }
        public Choice choice { get; set; }

        protected HashSet<Choice> choices = new();
        public IReadOnlySet<Choice> Choices => choices;
        public void CheckAnswer(Choice secenek)
        {

            if (secenek == null)
            {
                throw new Exception("Bos bir secenek değeri girdiniz");
            }
            if (choice == null)
            {
                throw new Exception("bos bir değer girilmiştir");
            }

            isChecked = false;
            choice = secenek;
        }

        public void CheckOption(Choice choice)
        {
            if (choices.Count < 4)
            {
                choices.Add(choice);

            }
            else
            {
                throw new Exception("4 ADET SECENEK GİRMENİZ GEREKMEKTEDİR");

            }

        }
        
    }
}
