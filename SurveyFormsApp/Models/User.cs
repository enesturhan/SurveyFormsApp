using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models
{
    public class User
    {
        

        public string Name { get;private set; }
        public string Surname { get;private set; }
        public int QuestionNumber { get; set; }
        public User(string name, string surname, int questionNumber)
        {
            CheckNameAndSurname(name, surname);
            this.Name = name;
            this.Surname = surname;
            this.QuestionNumber = questionNumber;
        }

        private void CheckNameAndSurname(string name, string surname)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new Exception("İsim boş geçilemez.");
            }
            if (String.IsNullOrEmpty(surname))
            {
                throw new Exception("Soyisim boş geçilemez.");
            }
        }

    }
}
