using System;
using System.Collections;
using System.IO;



namespace laba_proga_2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Hello World!");
            string[] names = ReadText();
        }
        static string[] ReadText()
        {
            string str = File.ReadAllText("students1.csv");
            string[] wordSplit = str.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string[] num = new string[40];
            int k = 0;
            for (int i = 0; i < 40; i++)
            {
                try
                {
                    num[i] = wordSplit[k];
                    Console.WriteLine(num[i]);
                    k++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return num;
        }
    }
}
