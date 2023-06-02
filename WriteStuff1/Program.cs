using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace WriteStuff1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cycle = true;
            List<string> strings = new List<string>();
            int index = 0;
            do
            {
                strings.Add(Console.ReadLine());

                if(strings[index] == "")
                    cycle = false;
                else
                    index++;
                
            }
            while(cycle);

            File.WriteAllLines(args[0], strings);
        }
    }
}
