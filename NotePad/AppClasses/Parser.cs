using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NotePad.AppClasses
{
    class Parser
    {
        List<string> lPairs = new List<string>();
        Dictionary<string, Int32> finalDict = new Dictionary<string, Int32>();
        private Parser()
        {}
        public Parser(string Path)
        {
            FileStream fs = new FileStream(Path, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            lPairs = sr.ReadToEnd().Split(new[] { '\r', '\n' }).ToList();
            foreach (string s in lPairs)
            {
                string[] str = s.Split(new[] { ' ' });
                if (str.Length > 1)
                    finalDict.Add(str[0].ToString(), Convert.ToInt32(str[1]));
            }
            sr.Close();
        }
        public void getResults(string find)
        {
            var mDict = finalDict.Where(s => s.Key.Contains(find)).OrderByDescending(s => s.Value).Take(5).ToDictionary(s => s.Key, s => s.Value);
            foreach (KeyValuePair<string, int> kvp in mDict)
            {
                Console.WriteLine(kvp.Key);
            }
        }
    }
}
