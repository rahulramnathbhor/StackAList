using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StackAList
    {
    public class Program
    {

        static void Main(string[] args)
        {
            Stack<string> stack= new Stack<string>();
            stack.Push("Sham");
            stack.Push("Ram");
            stack.Push("Shivam");
            stack.Push("Amol");
            stack.Pop();
            stack.Pop();

            stack.Pop();
            stack.Peek();
            stack.Push("Rani");

            foreach (var l in stack)
            {
                Console.WriteLine(l);
            }
            string[] names = new string[1];

            



        }

    }


}
