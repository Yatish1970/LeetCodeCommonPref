using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "carrier", "caro", "carry" };
            Console.WriteLine(LongestCommonPrefix(strs));
            Console.ReadLine();
    }
        public static string LongestCommonPrefix(string[] strs)
        {
            string pref = strs[0];            
            for(int i=1;i<strs.Length;i++)
            {
                while (strs[i].IndexOf(pref)!=0)
                {
                    if(strs[i].IndexOf(pref)!=0)
                    {
                        if (pref.Length != 1)
                            pref = pref.Substring(0,pref.Length-1);
                        else
                            pref ="";
                    }
                }
            }
            return pref;
        }
    }
}
