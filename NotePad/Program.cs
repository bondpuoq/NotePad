using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotePad.AppClasses;

namespace NotePad
{
    class Program
    {
        static void Main(string[] args)
        {
            Dict wordDict = new Dict();
            int IterNum = Convert.ToInt32(Console.ReadLine());
            wordDict.AddPair(IterNum);
            for (int i=0; i < IterNum-1; i++)
            {
                wordDict.AddPair(Console.ReadLine());
            }
            wordDict.WriteToFile("dict.txt");
            Parser pars = new Parser("dict.txt");
            for (int i=0; i < Convert.ToInt32(Console.ReadLine()); i++)
            {
                pars.getResults(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
