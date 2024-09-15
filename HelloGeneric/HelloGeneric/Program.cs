using System.Drawing;

namespace HelloGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple() { Color = "Red" };
            Book book = new Book() { Name = "Good Book" };
            Box<Apple> box1 = new Box<Apple>() {Cargo = apple};
            Box<Book> box2 = new Box<Book>() {Cargo=book };
            Console.WriteLine(box1.Cargo.Color);
            Console.WriteLine(box2.Cargo.Name);
        }
    }

    class Apple
    {
        public string Color { get; set; }
    }
    class Book
    {
        public string Name { get; set; }
    }

    class Box<TCargo>
    {
        public TCargo Cargo { get; set; }
    }
}