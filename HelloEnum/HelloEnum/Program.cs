namespace HelloEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.ID = 1;
            person.Name = "Test";
            person.Level = Level.Manager;
            person.Skill = Skill.Love | Skill.Code;

            Console.WriteLine(person.Skill);
            Console.WriteLine((person.Skill&Skill.Love)==Skill.Love);

        }
    }

    enum Level
    {
        Employee,
        Manager,
        Boss,
        BigBoss,
    }

    enum Skill
    {
        Love=1,
        Code=2,
        Cook=4,
        Learn=8,
    }

    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Level Level { get; set; }
        public Skill Skill { get; set; }
    }
}
