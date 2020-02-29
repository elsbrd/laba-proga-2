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
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");

            Console.WriteLine("Hello World!");
            string[] names = ReadText();
            string[] bud = Budjetniki(names);
        }
        public static int n, c = 0;
        static string[] ReadText()
        {
            string str = File.ReadAllText("students1.csv");
            string[] wordSplit = str.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string[] num = new string[40];
            int k = 0;
            for (int i = 0; i < 40; i++)
            n = Int32.Parse(wordSplit[0]); 
            string[] num = new string[n];
            int k = 1;
            for (int i = 0; i < n; i++)
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
                if (num[i].EndsWith("FALSE"))
                {
                    c++;
                }
            }
            return num;
        }
        static string[] Budjetniki(string[] sp_vseh)
        {
            string[] sp_budj = new string[c];

            Console.WriteLine("Список бюджетников: ");
            int m = 0;
            for (int i = 0; i < n; i++)
            {
                if (sp_vseh[i].EndsWith("FALSE"))
                {
                    sp_budj[m] = sp_vseh[i];
                    Console.WriteLine(sp_budj[m]);
                    m++;
                }
            }
            return sp_budj;
        }
    }
}
