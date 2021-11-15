using SurveyFormsApp.Abstracts;
using SurveyFormsApp.Concrete;
using SurveyFormsApp.Models;
using System;

namespace SurveyFormsApp
{
    class Program
    {
        static void Main(string[] args)
        {


           
            var user = new User("enes", "turhan", 15);
            var survey = new Survey("Anket1", "Baslık", "Bu bir acıklama", DateTime.Now.AddYears(-1), 10);
           


            var multipleQuestion1 = new MultipleChoiceQuestion("TURKİYENİN BASKENTİ NERESİDİR");
            multipleQuestion1.CheckOption(new Choice(name: "İzmir"));
            multipleQuestion1.CheckOption(new Choice(name: "Samsun"));
            multipleQuestion1.CheckOption(new Choice(name: "Hatay"));
            multipleQuestion1.CheckOption(new Choice(name: "Ankara"));

            var multipleQuestion2 = new MultipleChoiceQuestion("Fransanın Baskenti Neresidir");
            multipleQuestion2.CheckOption(new Choice(name: "Paris"));
            multipleQuestion2.CheckOption(new Choice(name: "Samsun"));
            multipleQuestion2.CheckOption(new Choice(name: "Hatay"));
            multipleQuestion2.CheckOption(new Choice(name: "Ankara"));


            var Yesno = new YesNoQuestion("Türkiyenin En kalabalık şehri İstanbul mudur?");
            Yesno.CheckAnswer(YesNoQuestionType.Yes);
            survey.CheckQuestionNumber(user);

            var DateFormatQuestion = new DateFormatQuestion("İstanbul ne zaman Fethedilmiştir");
            DateFormatQuestion.CheckAnswer(DateTime.Now.AddYears(-568));

            var DateFormatQuestion2 = new DateFormatQuestion("Cumhuriyet en zaman kurulmuştur");
            DateFormatQuestion2.CheckAnswer(DateTime.Now.AddYears(-98));

            var ShortAnswerQuestion = new ShortAnswerQuestion("Nerede Doğdunuz");
            ShortAnswerQuestion.CheckAnswer("Samsun");
            Console.WriteLine(ShortAnswerQuestion.Answer);
            var ParagraphQuestion = new ParagraphQuestion("Gecen yıl yaşadıklarınızı anlatınız");
            ParagraphQuestion.CheckAnswer("Asıl adı Muhyiddin Piri Bey olan Piri Reis 1465 yılında Gelibolu'da dünyaya geldi. Osmanlı İmparatorluğunda denizcilik anlamında" );
            var CheckBoxQuestion = new CheckBoxQuestion("Sevdiğiniz müzik türleri hangisidir");
            CheckBoxQuestion.CheckOption(new Choice("Klasik Müzik"));
            CheckBoxQuestion.CheckOption(new Choice("Rock"));
            CheckBoxQuestion.CheckOption(new Choice("POP"));
            CheckBoxQuestion.CheckOption(new Choice("Halk Müziği"));
            Console.WriteLine(CheckBoxQuestion.Name);


            Console.WriteLine(Yesno.Answer);
            
            Console.WriteLine(multipleQuestion1.isChecked);
            //Console.WriteLine(multipleQuestion1.choice.Name);





            survey.AddQuestion(Yesno);
            survey.AddQuestion(multipleQuestion1);
            survey.AddQuestion(multipleQuestion2);
            survey.AddQuestion(DateFormatQuestion);
            survey.AddQuestion(DateFormatQuestion2);
            survey.AddQuestion(ShortAnswerQuestion);
            survey.AddQuestion(ParagraphQuestion);
            survey.AddQuestion(CheckBoxQuestion);
         
        }
    }
}
