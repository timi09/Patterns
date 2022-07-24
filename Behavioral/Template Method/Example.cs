namespace Patterns.Behavioral.Template_Method
{
    class Example
    {
        public void Example1()
        {
            List<Student> students = new List<Student>()
            {
                new GoodStudent(),
                new BadStudent()
            };

            foreach (var student in students)
            {
                student.Study();
            }
        }
    }
}
