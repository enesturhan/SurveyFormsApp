using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Abstracts
{
    public interface IQuestion
    {

        /// <summary>
        /// 4 adet class icin kullanılmaya uygundur
        /// </summary>
        public string Name { get; set; }
    }
}
