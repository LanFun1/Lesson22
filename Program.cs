using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22
{
    class Program
    {
        static void Main(string[] args)
        {
            string codeWord = "";
            while(codeWord != "exit")
            {
                Console.WriteLine("Введите кодовое слово.");
                codeWord = Console.ReadLine();
            }
        }
    }
}
