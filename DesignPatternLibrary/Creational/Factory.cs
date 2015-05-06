using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLibrary.Creational
{
    #region Abstracts
    public abstract class Product1
    {
    }

    public abstract class Creator
    {
        public abstract Product1 FactoryMethod();
    }

    #endregion

    public class ConcreteProductA : Product1 { }
    public class ConcreteProductB : Product1 { }

    public class ConcreteCreatorA : Creator
    {
        public override Product1 FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
    public class ConcreteCreatorB : Creator
    {
        public override Product1 FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}

