

using SurveyFormsApp.Abstracts;
using SurveyFormsApp.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models
{
    public class Survey
    {
     
      
        public string Name { get;private set; }
        public string Title { get;private set; }
        public string Description { get;private set; }
        public DateTime CreationDate { get;private set; }
        public int TotalQuestion { get; set; }
        public User user { get; set; }

        private List<QuestionBase> questions = new List<QuestionBase>();

        public IReadOnlyList<QuestionBase> Questions => questions;

        public Survey(string name, string title, string description, DateTime creationDate,int totalQuestion)
        {
            SurveyInformationControl(name, creationDate);
            this.Name = name;
            this.Title = title;
            this.Description = description;
            this.CreationDate = creationDate;
            this.TotalQuestion = totalQuestion;
            
        }
            
        
        public void AddQuestion(QuestionBase question)
        {
           
            
            if (questions.Count < TotalQuestion)
            {
                bool isSame = questions.Any(x => x.Name == question.Name);
                if (!isSame)
                {
                    questions.Add(question);
                }
                else
                {
                    throw new Exception("bir soru bir kez girilebilir");
                }

            }
            else
            {
                throw new Exception ("Belirlenmiş olan soru değerinden fazla bir soru girdiniz");
            }
           

        }
        public void CheckQuestionNumber(User user)
        {
            if (user.QuestionNumber >= TotalQuestion)
            {
                Console.WriteLine("enes");
            }
            else
            {
                throw new Exception("Fazla bir soru değeri girdiniz");

            }
        }
        private void SurveyInformationControl(string name, DateTime date)
        {
            if (name == "")
            {
                throw new Exception("Anket ismi doldurulmalıdır");

            }
            if (date == default(DateTime))
            {
                throw new Exception("Gecerli bir tarih giriniz");
            }
          
        }
     

       
  
       
       
       
      
    }
}
