using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models
{
    public class Choice
    {


        public string Name { get; set; }
       
        public Choice(string name)
        {
            this.Name = name;
        }
    }
}
