using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLibrary.Creational
{
    #region Abstracts
    /// <summary>
    /// Structural Code Example using C# and the Abstract Factory Design Pattern.
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }

    public abstract class AbstractProductA
    {
    }

    public abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA b);
    }
    #endregion

    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }


    public class ProductA1 : AbstractProductA
    {

    }

    public class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA b)
        {
            Console.WriteLine(string.Format("{0} interacts with {1}"
                , this.GetType().Name
                , b.GetType().Name)
                );
        }
    }

    public class ProductA2 : AbstractProductA
    {
    }

    public class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA b)
        {
            Console.WriteLine(string.Format("{0} interacts with {1}"
                , this.GetType().Name
                , b.GetType().Name)
                );
        }
    }

    public class Client
    {
        private AbstractProductA _productA;
        private AbstractProductB _productB;

        public Client(AbstractFactory factory)
        {
            this._productB = factory.CreateProductB();
            this._productA = factory.CreateProductA();
        }

        public void Run()
        {
            this._productB.Interact(this._productA);
        }
    }

}
