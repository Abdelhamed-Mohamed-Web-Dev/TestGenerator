using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Project_02
{
    internal class Exam : Subject
    {

        //Design a Base class Exam describe
        //the common attributes concerning the exam:
        //a. Time of exam
        //b. Number of Questions
        //c. Show Exam Functionality that its implementations
        //will be different for each exam based on its type.
        
        public int Time { get; set; }
        public int NumOfQuestions { get; set; }
        public int ExamType { get; set; }
        public Exam? exam { get; set; }
        public Question[]? ExamQuestions { get; set; }
        public virtual Question[] ReadExamQuestions(int num) { return new Question[0]; }
        public virtual void PlayResult(Question q, int ua) { }
        public void ReadExam()
        {
            // Read Data Of Exam
            Console.WriteLine("Enter The Type Of Exam (1 => Practical , 2 => Final)");
            ExamType = Help.ReadInt(1, 2);
            Console.WriteLine("Enter The Time For Exam (30 Min => 180 Min)");
            Time = Help.ReadInt(30, 180);
            Console.WriteLine("Enter Number Of Question ");
            NumOfQuestions = Help.ReadInt();
            Console.Clear();
            // Create Object From Exam Type 
            //Exam exam = new Exam();
            for (int i = 0; i < NumOfQuestions; i++)
            {
                if (ExamType == 1)
                    exam = new PracticalExam();
                else
                    exam = new FinalExam();
            }
            // Read Questions And Save It In Array
            // each index of array represent a ques
            ExamQuestions = new Question[NumOfQuestions];
            ExamQuestions = exam?.ReadExamQuestions(NumOfQuestions);
            Console.Clear();

        }
        public void PlayExam()
        {
            Console.Clear();
            int[] UserAnswersList = new int[ExamQuestions?.Length??0];
            int[] RightAnswersList = new int[ExamQuestions?.Length??0];
            int result = 0, final = 0;
            for (int i = 0; i < ExamQuestions?.Length; i++)
            {
                Console.WriteLine(ExamQuestions[i].ToString());
                UserAnswersList[i] = ExamQuestions[i].ReadAnswerFromUser();
                RightAnswersList[i] = ExamQuestions[i].RightAnswer; // Get Right Answer Index
            }
            Console.Clear();
            for (int i = 0; i < ExamQuestions?.Length; i++)
            {
                exam?.PlayResult(ExamQuestions[i], UserAnswersList[i]);
                if (UserAnswersList[i] == RightAnswersList[i])
                {
                    Console.WriteLine($"Right Answer");
                    result += ExamQuestions[i].Mark;
                }
                else
                    Console.WriteLine("Wrong Answer");
                final += ExamQuestions[i].Mark;
            }
            Console.WriteLine($"Your Result Is {result} Of {final}");
            //Console.WriteLine(ExamQuestions[i].AnswerList[ExamQuestions[i].RightAnswer]); // Play Right Answer Text Of One Ques

        }
    }
}
