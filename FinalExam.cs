using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Project_02
{
    internal class FinalExam : Exam
    {
        public int QuesType { get; set; }
        public override Question[] ReadExamQuestions(int num)
        {
            Question[] ret = new Question[num];
            for (int i = 0; i < ret.Length; i++)
            {
                Console.WriteLine("Enter Question Type (1 => MCQ , 2 => True | False)");
                QuesType = Help.ReadInt(1, 2);
                if (QuesType == 1)
                {
                    ret[i] = new MCQ();
                    ret[i] = ret[i].ReadOneQuestion(i + 1);
                }
                else
                {
                    ret[i] = new TrueOrFalse();
                    ret[i] = ret[i].ReadOneQuestion(i + 1);
                }
            }
            return ret;
        }
        public override void PlayResult(Question q, int ua)
        {
            //9 - Final Exam Shows the Questions, Answers and Grade.
            Console.WriteLine(q.ToString());
            Console.WriteLine($"Right Answer => {q?.AnswerList?[q?.RightAnswer??0]??"---"}");
            Console.WriteLine($"Your Answer  => {q?.AnswerList?[ua] ?? "---"}");
        }

    }
}
