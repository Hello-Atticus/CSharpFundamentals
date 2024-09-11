namespace DataMemberExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            int stuAge = student.Age = 10;
            Console.WriteLine(stuAge);
        }
    }

    class Student
    {
        public int Age;
        public int Score;

        public Student()
        {
            this.Age = 20;
        }



    }
}
