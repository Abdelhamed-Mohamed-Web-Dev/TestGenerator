using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Project_02
{
    internal class TrueOrFalse : Question
    {
        public TrueOrFalse()
        {

        }
        public TrueOrFalse(string body, int mark, Answer answerlist, int rightanswer)
        {
            this.Body = body;
            this.Mark = mark;
            this.AnswerList = answerlist;
            this.RightAnswer = rightanswer;

        }
        
        public override Question ReadOneQuestion(int num)
        {
            Console.WriteLine($"Question Number {num}        True Or False Question ");
            Console.WriteLine("Enter Question Body ");
            Body = Console.ReadLine();
            Console.WriteLine("Enter Question Mark ");
            Mark = Help.ReadInt();
            AnswerList = new Answer(2);
            AnswerList.AddAnswer(0, "True");
            AnswerList.AddAnswer(1, "False");

            Console.WriteLine("Enter Right Answer Id (1 => True , 2 => False)");
            RightAnswer = Help.ReadInt(1, 2) - 1;
            Console.Clear();
            return new TrueOrFalse(Body??"---", Mark, AnswerList, RightAnswer);
        }
        public override int ReadAnswerFromUser()
        {
            Console.WriteLine("Enter Your Answer");
            return Help.ReadInt(1, 2)-1;
        }


        public override string ToString()
        {
            return $"{Body}         Mark = {Mark}\n{AnswerList}";
        }
    }
}
