namespace Exam_Project_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Subject Math = new Subject(1, "Math");
            Math.CreateExam();
            Console.WriteLine("Do You Want To Start Exam (1 => Yes , 2 => No)");
            int s = Help.ReadInt(1, 2);
            Console.Clear();
            DateTime start = new DateTime();
            if (s == 1)
            {
                start = DateTime.Now;
                Math.StartExam();
            }
            TimeSpan duration = DateTime.Now - start;
            Console.WriteLine("*******************************");
            Console.WriteLine($"The Duration = {duration}");
            Console.WriteLine("Thank You...");
        }
    }
}
