using System;
using System.Text;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Hello everyone!");
            sb.Append("\nI hope your day is going great.");
            sb.Append("\nLet's all have a wonderful week!");
            sb.Append("\nThank you for coming to my ted talk");

            Console.WriteLine(sb);

            string s1 = ("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nHello ");
            string s2 = ("there ");
            string s3 = ("mate!");
            

            Console.WriteLine(s1 + s2 + s3.ToUpper());



            Console.Read();


        }
    }
}
