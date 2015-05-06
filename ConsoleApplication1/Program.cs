using System;
using System.Collections.Generic;
using c = DesignPatternLibrary.Creational;

namespace ConsoleApplication1
{
    /// <summary>
    /// http://www.dofactory.com/net/design-patterns
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //RunBuilder();
            RunFactory();
            Console.ReadKey();

        }
        static void RunBuilder()
        {
            Console.WriteLine("RunBuilder");
            c.Director d = new c.Director();
            c.Builder b1 = new c.ConcreteBuilder1();
            d.Construct(b1);
            c.Product p1 = b1.GetResult();
            p1.Show();

            c.Builder b2 = new c.ConcreteBuilder2();
            d.Construct(b2);
            c.Product p2 = b2.GetResult();
            p2.Show();
        }
        static void RunAbstractFactory()
        {
            Console.WriteLine("RunAbstractFactory");
            c.AbstractFactory f1 = new c.ConcreteFactory1();
            c.Client c1 = new c.Client(f1);
            c1.Run();

            c.AbstractFactory f2 = new c.ConcreteFactory2();
            c.Client c2 = new c.Client(f2);
            c2.Run();

        }
        static void RunFactory()
        {
            Console.WriteLine("RunFactory");
            List<c.Creator> creators = new List<DesignPatternLibrary.Creational.Creator>()
            {
                  new c.ConcreteCreatorA()
                , new c.ConcreteCreatorB()
            };
            foreach (c.Creator item in creators)
            {
                c.Product1 product = item.FactoryMethod();
                Console.WriteLine(string.Format("Created {0}"
                    , product.GetType().Name)
                    );                
            }
        }
    }
}
