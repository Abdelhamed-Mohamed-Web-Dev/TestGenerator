using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Project_02
{
    internal class MCQ : Question
    {
        public MCQ()
        {

        }
        public MCQ(string body, int mark, Answer answerlist, int rightanswer)
        {
            this.Body = body;
            this.Mark = mark;
            this.AnswerList = answerlist;
            this.RightAnswer = rightanswer;
        }
        public override Question ReadOneQuestion(int num)
        {
            Console.WriteLine($"Question Number {num}    MCQ Question");
            Console.WriteLine("Enter Question Body ");
            Body = Console.ReadLine();
            Console.WriteLine("Enter Question Mark ");
            Mark = Help.ReadInt();
            Console.WriteLine("Enter Choices");
            AnswerList = new Answer(3);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter Answer Number {i + 1}");

                AnswerList.AddAnswer(i, Console.ReadLine()??"---");

            }
            Console.WriteLine("Enter Right Answer Id ");
            RightAnswer = Help.ReadInt(1, 3) - 1;
            Console.Clear();
            return new MCQ(Body ?? "---", Mark, AnswerList, RightAnswer);
        }
        public override int ReadAnswerFromUser()
        {
            Console.WriteLine("Enter Your Answer");
            return Help.ReadInt(1, 3) - 1;
        }

        public override string ToString() { return $"{Body}         Mark = {Mark}\n{AnswerList}"; }
    }
}
