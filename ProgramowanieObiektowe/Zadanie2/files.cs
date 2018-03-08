using System;
using System.IO;
using System.Linq;

namespace ProgramowanieObiektowe2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj nazwe pliku");
            string name = Console.ReadLine();
            StreamReader sr = new StreamReader(name + ".txt");
            //try if file was opened correctly
            string[] lines = sr.ReadToEnd().Split('\n');
            float max_accuracy=-1;
            //check if line is empty
            foreach (var line in lines)
            {
                Console.WriteLine(line);
                string[] words = line.Split(' ');
                float accuracy = Convert.ToSingle(words[3]); 
                if(accuracy>max_accuracy)
                {
                    max_accuracy = accuracy;
                }
            }
            StreamWriter sw = new StreamWriter(name + "max.txt");
            foreach (var line in lines)
            {
                string[] words = line.Split(' ');
                float accuracy = Convert.ToSingle(words[3]); 
                if(accuracy.Equals(max_accuracy) && words[0].Length>=3 && words[1].EndsWith("ski", StringComparison.Ordinal))
                {
                    //write name
                    sw.Write(words[0][0]);
                    for (int i = 0; i < words[0].Length - 4; i++)
                        sw.Write('*');
                    if(words[0].Length==3)
                        sw.Write(words[0].Substring(words[0].Length - 2) + ' ');
                    else sw.Write(words[0].Substring(words[0].Length-3)+' ');
                    //write surname
                    sw.Write(words[1][0]);
                    for (int i = 0; i < words[1].Length - 4; i++)
                        sw.Write('*');
                    sw.Write(words[1].Substring(words[1].Length - 3)+' ');
                    sw.Write(words[2]);
                }
            }
            sw.Close();

        }
    }
}
