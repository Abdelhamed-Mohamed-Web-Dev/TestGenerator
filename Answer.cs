using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Project_02
{
    internal class Answer
    {

        public int[] AnsId { get; set; }
        public string[] AnsText { get; set; }
        public int Size { get; set; }
        public Answer(int size)
        {
            AnsId = new int[size];
            AnsText = new string[size];
            this.Size = size;
        }

        public void AddAnswer(int id , string text)
        {
            AnsId[id] = id;
            AnsText[id] = text;
        }
        // indexer
        public string this[int id]
        {
            get
            {
                return $"{id+1} - {AnsText[id]}";
            }
            
        }
        public override string ToString()
        {
            string ret = "";
            for (int i = 0; i < Size; i++)
            {
                ret += $" {i + 1} - {AnsText[i]}\n";
            }
            return ret;
        }



    }
}
