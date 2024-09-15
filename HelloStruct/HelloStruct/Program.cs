namespace HelloStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.ID = 1;
            student.Name = "Test";
            student.Report();

            //struct是值类型
            Student student2 = student;
            student2.ID = 2;
            student2.Name = "Test2";
            student2.Report();

        }
    }

    interface IStudent
    {
        void Report();
    }
    //struct可以使用接口
    struct Student : IStudent
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void Report()
        {
            Console.WriteLine($"I'm #{ID} student {Name}");
        }
    }
}
