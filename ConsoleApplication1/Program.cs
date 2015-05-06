using System;
using s = DesignPatternLibrary.Structural;

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
            s.Director d = new s.Director();
            s.Builder b1 = new s.ConcreteBuilder1();
            d.Construct(b1);
            s.Product p1 = b1.GetResult();
            p1.Show();

            s.Builder b2 = new s.ConcreteBuilder2();
            d.Construct(b2);
            s.Product p2 = b2.GetResult();
            p2.Show();
        }
        static void RunAbstractFactory()
        {
            Console.WriteLine("RunAbstractFactory");
            s.AbstractFactory f1 = new s.ConcreteFactory1();
            s.Client c1 = new s.Client(f1);
            c1.Run();

            s.AbstractFactory f2 = new s.ConcreteFactory2();
            s.Client c2 = new s.Client(f2);
            c2.Run();

        }
    }
}
