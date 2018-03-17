using System;
using System.Collections.Generic;
namespace ProgramowanieObiektowe3
{
    class Stos
    {
        Stack<int> stos= new Stack<int>();
        int MAX_SIZE=10;
        public bool IsEmpty()
        {
            if (stos.Count == 0)
                return true;
            else
                return false;
        }
        public bool IsFull()
        {
            if (stos.Count == MAX_SIZE)
                return true;
            else
                return false;
        }
        public void PushStack(int value)
        {
            stos.Push(value);
        }
        public void PopStack()
        {
            stos.Pop();
        }
        public int TopStack()
        {
            int input = stos.Peek();
            return input;
        }
        public void DestroyStack()
        {
            stos.Clear();
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stos stos1 = new Stos();
            Stos stos2 = new Stos();
            for (int i = 0; i < 10;i++)
            {
                string input = Console.ReadLine();
                int number;
                Int32.TryParse(input, out number);
                stos1.PushStack(number);
            }
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(stos1.TopStack());
                stos2.PushStack(stos1.TopStack());
                stos1.PopStack();
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(stos2.TopStack());
                stos1.PushStack(stos2.TopStack());
                stos2.PopStack();
            }
        }
    }

}
