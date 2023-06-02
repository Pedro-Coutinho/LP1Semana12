using System;
using System.IO;

namespace WriteStuff2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cycle = true;
            string text;
            StreamWriter sw = new StreamWriter(args[0]);
            do
            {
                text = Console.ReadLine();

                if(text == "")
                    cycle = false;
                else
                    sw.WriteLine(text);;
                
            }
            while(cycle);

            sw.Close();
        }
    }
}
