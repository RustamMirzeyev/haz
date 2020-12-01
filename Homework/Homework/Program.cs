using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder word = new StringBuilder("Dark in da House ");
            Console.WriteLine(word);

        }

        static StringBuilder dark(string word)
        {
            StringBuilder result = new StringBuilder();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                //Console.WriteLine(word[i]);
                //result.Append(word[i]);


            }

            return result;
        }
    }
}
