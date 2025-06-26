using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Project_02
{
    internal class PracticalExam : Exam
    {
       
        public override Question[] ReadExamQuestions(int num) // num of ques as a parameter
        {
            Question[] ret = new MCQ[num]; // return ques array
            for (int i = 0; i < ret.Length; i++) // loop for num of ques times & save each ques in return array
            {
                ret[i] = new MCQ();
                ret[i] = ret[i].ReadOneQuestion(i + 1);                
            }
            return ret;
        }
        public override void PlayResult(Question q, int ua)
        {
            //8 - Practical Exam Shows the right answer after finishing the Exam.
            Console.WriteLine($"Right Answer => {q?.AnswerList?[q?.RightAnswer??0]??"---"}");
            Console.WriteLine($"Your Answer  => {q?.AnswerList?[ua] ?? "---"}");

        }


    }
}
