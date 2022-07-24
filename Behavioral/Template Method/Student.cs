namespace Patterns.Behavioral.Template_Method
{
    abstract class Student
    {
        public void Study() 
        {
            DoLabWorks();
            WriteReports();
            DoCourseWork();
            PassExams();
        }

        public abstract void DoLabWorks();
        public abstract void WriteReports();
        public abstract void DoCourseWork();
        public abstract void PassExams();
    }

    class GoodStudent : Student
    {
        public override void DoLabWorks()
        {
            Console.WriteLine("Do labworks step by step");
        }

        public override void WriteReports()
        {
            Console.WriteLine("Write all reports");
        }

        public override void DoCourseWork()
        {
            Console.WriteLine("Do coursework");
        }

        public override void PassExams()
        {
            Console.WriteLine("Pass exams well\n");
        }
    }

    class BadStudent : Student
    {
        public override void DoLabWorks()
        {
            Console.WriteLine("- Later...");
        }

        public override void WriteReports()
        {
            Console.WriteLine("Playing computer");
        }

        public override void DoCourseWork()
        {
            Console.WriteLine("- Hmm... later");
        }

        public override void PassExams()
        {
            Console.WriteLine("- Oh god!\n" +
                "Quickly write off labworks\n" +
                "Write half of reports\n" +
                "Quickly do a coursework\n" +
                "Pass exams bad\n");
        }
    }
}
