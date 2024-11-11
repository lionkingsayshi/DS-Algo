using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDataStructure.Classes
{
    public static class StringChar
    {
        public static string InputStringEncoding(this string input)
        {
            char[] chars = input.ToCharArray();
            string finalOutput = string.Empty;
            Dictionary<string, int> keyValues = new Dictionary<string, int>();
            foreach (var c in chars) 
            {
                if(keyValues.ContainsKey(c.ToString()))
                {
                    keyValues[c.ToString()]++;
                }
                else
                {
                    keyValues.Add(c.ToString(), 1);
                }
            }
            if (keyValues.Count > 0) 
            {
                foreach (var key in keyValues)
                {
                    finalOutput += key.Key+key.Value;
                }
            }
            return finalOutput;
        }
    }
}
