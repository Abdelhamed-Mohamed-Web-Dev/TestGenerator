using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Project_02
{
    internal class Question
    {
        public string? Header { get; set; }
        public string? Body { get; set; }
        public int Mark { get; set; }
        public Answer? AnswerList { get; set; }
        public int RightAnswer { get; set; }
        // Source Funs To Override By Child Classes
        public virtual Question ReadOneQuestion(int num) { return new Question(); }
        public virtual int ReadAnswerFromUser() { return 0; }
        public override string ToString() { return $"Question"; }

    }
}
