using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NotePad.AppClasses
{
    class Dict
    {
        List<string> pairSet = new List<string>();
        public void AddPair(string stringParam)
        {
            pairSet.Add(stringParam);
        }
        public void AddPair(int intParam)
        {
            pairSet.Add(intParam.ToString());
        }
        public void WriteToFile(string fileNameParam)
        {
            FileStream fStream = new FileStream(fileNameParam, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sWriter = new StreamWriter(fStream);
            foreach (string s in pairSet)
            {
                sWriter.WriteLine(s);
            }
            sWriter.Close();
        }
    }


}
