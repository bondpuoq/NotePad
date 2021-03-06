﻿using System;
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
            int iterNum = Convert.ToInt32(Console.ReadLine());
            wordDict.AddPair(iterNum);
            for (int i=0; i < iterNum; i++)
            {
                string somePhrase = Console.ReadLine();
                wordDict.AddPair(somePhrase);
            }
            string filePath = "../../resources/dict.txt";
            wordDict.WriteToFile(filePath);
            Parser pars = new Parser(filePath);
            int countIter = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i < countIter; i++)
            {
                string someWord = Console.ReadLine();
                pars.getResults(someWord);
            }
            Console.ReadKey();
        }
    }
}
