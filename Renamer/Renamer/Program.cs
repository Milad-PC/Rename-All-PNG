using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Renamer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Welcome **");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("By Light Company");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("PNG File List : ");
            foreach (string arg in Directory.GetFiles(Directory.GetCurrentDirectory(), "*.png"))
            {
                try
                {
                    //Find Just File Name
                    string x = arg;
                    x = x.Substring(x.LastIndexOf("\\") + 1);
                    //Rename Pattern
                    x = x.Replace("icons8_", "");
                    x = x.Replace("_256px", "");
                    //Write All New File Name
                    Console.WriteLine(x);
                    //Rename
                    Directory.Move(arg, x);
                }
                catch { }
            }
            //Stop For Close CMD
            Console.ReadKey();
        }
    }
}
