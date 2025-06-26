using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam_Project_02
{
    internal class Subject
    {
        public int SubId { get; set; }
        public string SubName { get; set; }
        public Exam SubjectExam { get; set; }
        public Subject(int subId, string subName)
        {
            SubId = subId;
            SubName = subName;
            SubjectExam = new Exam();
        }
        public Subject()
        {
        }
        public Exam CreateExam()
        {
            Exam ex = new Exam();
            ex.ReadExam();
            Console.Clear();
            SubjectExam = ex;
            return ex;
        }
        public void StartExam()
        {
            if (SubjectExam is not null)
                SubjectExam.PlayExam();

        }





    }
}
