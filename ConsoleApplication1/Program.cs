using System;
using DesignPatternLibrary;

namespace ConsoleApplication1
{
    /// <summary>
    /// http://www.dofactory.com/net/design-patterns
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            RunBuilder();
            Console.ReadKey();

        }
        static void RunBuilder()
        {
            Console.WriteLine("RunBuilder");
            Director d = new Director();
            Builder b1 = new ConcreteBuilder1();
            d.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            Builder b2 = new ConcreteBuilder2();
            d.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();
        }
        static void RunAbstractFactory()
        {
            Console.WriteLine("RunAbstractFactory");
            AbstractFactory f1 = new ConcreteFactory1();
            Client c1 = new Client(f1);
            c1.Run();

            AbstractFactory f2 = new ConcreteFactory2();
            Client c2 = new Client(f2);
            c2.Run();

        }
    }
}
