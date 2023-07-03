using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3B_PracticeProblem
{
    public class AccessModifier
    {
        public int bankAccountNumber = 123456;
        public void GeneralInformation()
        {
            Console.WriteLine("This is Public class Access Modifier");
        }
    }

    public class BankAccount
    {
        private int _balance = 5000;

        public int GetBalance()
        {
            return _balance;
        }

        public void Deposit(int amount)
        {
            _balance += amount;
        }
    }

    public class Shape
    {
        protected int Width { get; set; }
        protected int Height { get; set; }

        public virtual int GetArea()
        {
            return Width * Height;
        }
    }
    public class Rectangle : Shape
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
