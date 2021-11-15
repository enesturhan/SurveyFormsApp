using SurveyFormsApp.Abstracts;
using SurveyFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Concrete
{
    public class CheckBoxQuestion : QuestionBase
    {
        public CheckBoxQuestion(string name) : base(name, QuestionType.CheckBoxQuestion)
        {

        }

        private List<Choice> choiceAnswer { get; set; } = new();
        public IReadOnlyList<Choice> ChoiceAnswer => choiceAnswer;


        private HashSet<Choice> choices = new();
        public IReadOnlySet<Choice> Choices => choices;
        public void CheckAnswer(Choice choice)
        {
            if(choices.Any(x=>x.Name == choice.Name))
            {
                if (choiceAnswer.Any(x => x.Name != choice.Name))
                {
                    choices.Clear();
                }
                else 
                {
                    choiceAnswer.Add(choice);
                }

            }
            else
            {
                throw new Exception("Boyle bir secenek yok");
            }

        }

        public void CheckOption(Choice choice)
        {
            if (Choices.Count < 5)
            {
                choices.Add(choice);

            }
            else
            {
                throw new Exception("EN FAZLA 5 ADET SECENEK EKLENEBİLİR");
            }

        }

    }
}
