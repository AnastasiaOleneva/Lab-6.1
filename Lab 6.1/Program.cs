using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string[] arrayString = startString.Split(' ', '.', ',', ';', ':', '-', '!', '?');
            int max = 0;
            foreach (string word in arrayString)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                }
            }
            Console.WriteLine("Самое длинное слово в предложении имеет {0} символов", max);
            Console.ReadKey();


        }
    }
}
