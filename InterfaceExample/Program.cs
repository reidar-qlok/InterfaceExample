using System;
namespace InterfaceExample
{
    interface IAddInterface
    {
        void Add(int num1, int num2);
    }
    interface IAddSubInterface : IAddInterface
    {
        //void Add(int num1, int num2);
        void Sub(int num1, int num2);
    }
    public class ImplementAdd : IAddInterface
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine($"Summan av {num1} och {num2} är {num1 + num2}");
        }
    }
    public class ImplementAddSub : IAddSubInterface
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine($"Summan av {num1} och {num2} är {num1 + num2}");
        }

        public void Sub(int num1, int num2)
        {
            Console.WriteLine($"Vid subtrahering av {num1} med {num2} blir svaret {num1 - num2}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ImplementAdd objAdd = new ImplementAdd();
            // med add objektet kommer vi bara åt add metoden
            objAdd.Add(22, 78);
            ImplementAddSub objAddSub = new ImplementAddSub();
            objAddSub.Add(23, 79);
            objAddSub.Sub(5, 3);
        }
    }
}
