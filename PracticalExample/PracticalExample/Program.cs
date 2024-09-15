using PractialExample.SDK;
using System.Runtime.Loader;

namespace PracticalExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var folder = Path.Combine(Environment.CurrentDirectory, "Animals");
            var files = Directory.GetFiles(folder);
            var animalTypes = new List<Type>();
            foreach (var file in files)
            {
                var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(file);
                var types = assembly.GetTypes();
                foreach (var type in types)
                {
                    if (type.GetInterfaces().Contains(typeof(IAnimal)))
                    {
                        var isUnfinished = type.GetCustomAttributes(false).Any(a => a.GetType() == typeof(UnfinishedAttribute));
                        if (isUnfinished) { continue; }
                        animalTypes.Add(type);
                    }
                }
            }

            while (true)
            {
                for (int i = 0; i < animalTypes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{animalTypes[i].Name}");
                }
                Console.WriteLine("================");
                Console.WriteLine("Please choose animal:");
                int index = int.Parse(Console.ReadLine());
                if (index < 1 || index > animalTypes.Count)
                {
                    Console.WriteLine("No such an animal. Try again!");
                    continue;
                }
                Console.WriteLine("How many times:");
                int times = int.Parse(Console.ReadLine());
                var t = animalTypes[index-1];
                var m = t.GetMethod("Voice");
                var o = Activator.CreateInstance(t);

                var a = o as IAnimal;
                a.Voice(times);
            }
        }
    }
}
