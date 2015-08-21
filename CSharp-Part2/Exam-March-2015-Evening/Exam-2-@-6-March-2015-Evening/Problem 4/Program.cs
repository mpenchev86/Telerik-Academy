using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder lines = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                lines.Append(Console.ReadLine());
            }

            string[] loops = new string[]{
                "(for )",
                "(while)",
                "(foreach)"
            };
            string[] condits = new string[] { 
                "(if )",
                "(else )"
            };
            string[] types = new string[] { 
                "sbyte", 
                "byte", 
                "short", 
                "ushort", 
                "int", 
                "uint", 
                "long", 
                "ulong", 
                "float", 
                "double", 
                "decimal", 
                "bool", 
                "char", 
                "string",
                "sbyte?", 
                "byte?", 
                "short?", 
                "ushort?", 
                "int?", 
                "uint?", 
                "long?", 
                "ulong?", 
                "float?", 
                "double?", 
                "decimal?", 
                "bool?", 
                "char?", 
                "string?"
            
            };

            string[] methods = lines.ToString().Trim().Split(new string[] { "static" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            
            List<int> indexLoops = new List<int>();
            List<int> indexCondits = new List<int>();


            for (int i = 1; i < methods.Length; i++)
            {
                foreach (var condit in condits)
                {
                    int indexCondit = methods[i].IndexOf(condit, 0);
                    while (indexCondit != -1)
                    {
                        indexCondits.Add(indexCondit);
                    }
                }

                foreach (string loop in loops)
                {
                    int indexloop = methods[i].IndexOf(loop, 0);
                    while (indexloop != -1)
                    {
                        indexLoops.Add(indexloop);
                    }
                }

            }
        }
    }
}
