using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLibrary.Structural
{
    #region Abstracts

    public abstract class Builder
    {
        public Builder()
        {
            baseProduct = new Product();
        }
        public Product baseProduct = null;
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public virtual Product GetResult()
        {
            return this.baseProduct;
        }
    }

    #endregion

    #region Types

    public class Product
    {
        private List<string> _parts = new List<string>();
        public void Add(string part)
        {
            if (!string.IsNullOrEmpty(part))
            {
                _parts.Add(part);
            }
        }
        public void Show()
        {
            Console.WriteLine("\nProduct Parts ----------");
            foreach (string p in _parts)
            {
                Console.WriteLine(p);
            }
        }
    }
    public class Director
    {
        public void Construct(Builder b)
        {
            b.BuildPartA();
            b.BuildPartB();
        }

    }

    #endregion

    public class ConcreteBuilder1 : Builder
    {
        public override void BuildPartA()
        {
            base.baseProduct.Add("PartA");
        }

        public override void BuildPartB()
        {
            base.baseProduct.Add("PartB");
        }

    }
    public class ConcreteBuilder2 : Builder
    {
        public override void BuildPartA()
        {
            base.baseProduct.Add("PartX");
        }

        public override void BuildPartB()
        {
            base.baseProduct.Add("PartY");
        }
    }

}
