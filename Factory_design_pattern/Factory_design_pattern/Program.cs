using System;

namespace Factory_design_pattern
{

    // excercise for learn in class


    /*class Program
    {
        static void Main(string[] args)
        {
            Creator c = new Creator();
            IProduct product;

            product = c.factoryMethod(1);
            Console.WriteLine(product.Ship());
            product = c.factoryMethod(2);
            Console.WriteLine(product.Ship());
        }
    }

    public interface IProduct
    {
        string Ship();
    }

    public class ProductA : IProduct
    {
        public string Ship()
        {
            return "ProductA";
        }
    }
    public class ProductB : IProduct
    {
        public string Ship()
        {
            return "ProductB";
        }
    }

    public class Creator
    {
        public IProduct factoryMethod(int month)
        {
            if (month == 1)
            {
                return new ProductA();
            }
            else if (month == 2)
            {
                return new ProductB();
            }
            return null;
        }
    }*/


    // ==========================

    // excercise Avocado

    class Program
    {
        static void Main(string[] args)
        {
            Creator c = new Creator();
            IProduct product;
            try
            {
                for (int i = 1; i <= 12; i++)
                {

                    product = c.factoryMethod(i);
                    Console.WriteLine(product.Ship());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

    public interface IProduct
    {
        string Ship();
    }

    public class ProductA : IProduct
    {
        public string Ship()
        {
            return "Afocado from spain";
        }
    }
    public class ProductB : IProduct
    {
        public string Ship()
        {
            return "Afocado from S.F.";
        }
    }

    public class Creator
    {
        public IProduct factoryMethod(int month)
        {
            if (month >= 1 && month <=4)
            {
                return new ProductA();
            }
            else if (month >= 5 && month <=11)
            {
                return new ProductB();
            }
            if (month == 12)
            {
            throw new Exception("12 not sesonal month");
            }
            throw new ArgumentException("Invalid Argoment");
            
        }
    }
}
