namespace DelegateExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WrapFactory wrapFactory = new WrapFactory();
            ProductFactory productFactory = new ProductFactory();

            Func<Product> func1 = new Func<Product>(productFactory.MakePizza);
            Func<Product> func2 = new Func<Product>(productFactory.MakeToyCar);
            Box box1 = wrapFactory.WrapProduct(func1);
            Console.WriteLine(box1.Product.Name);

            Box box2 = wrapFactory.WrapProduct(func2);
            Console.WriteLine(box2.Product.Name);
            
        }
    }

    class Product
    {
        public string Name { get; set; }
    }

    class Box
    {
        public Product Product { get; set; }
    }

    class WrapFactory
    {
        public Box WrapProduct(Func<Product> getProduct)
        {
            Box box = new Box();
            Product product = getProduct.Invoke();
            box.Product = product;
            return box;
        }
    }

    class ProductFactory
    {
        public Product MakePizza()
        {
            Product product = new Product();
            product.Name = "Pizza";
            return product;
        }

        public Product MakeToyCar()
        {
            Product product= new Product();
            product.Name = "Toy Car";
            return product ;
        }
    }
}
