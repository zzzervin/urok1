using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; //
using System.Text;
using System.Threading.Tasks;

namespace Uork1
{
    class Program //не трогать
    {
        static void Main(string[] args)//void
        {

            string[] sonad = new string[7] { "aaa", "bbb","ddd", "fff", "ggg", "eee", "rrr" };//cpicok
            foreach (string sona in sonad)//
            {
                Console.WriteLine(sona);
            }
            for (int i = 0; i < sonad.Length; i++)
            {
                Console.WriteLine(sonad[i]);
            }
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Vajuta Escape");
                key = Console.ReadKey();
            } while (key.Key!= ConsoleKey.Escape);


            ////Console.BackgroundColor = ConsoleColor.Gray;//Console.BackgroundColor=цвет фона.
            ////Console.ForegroundColor = ConsoleColor.Blue;//Console.ForegroundColor= цвет букв.
            ////Console.Clear();
            ////Console.WriteLine("Hello world");
            ////Random rnd = new Random();
            ////Console.WriteLine("Jah-random, ei-ise");
            ////string soov = Console.ReadLine();
            ////int num = 0;
            ////if (soov == "Jah")
            ////{
            ////    num = rnd.Next(1, 8);//
            ////}
            ////else
            ////{
            ////    try
            ////    {
            ////        num = Convert.ToInt32(Console.ReadLine());
            ////        Console.WriteLine("Päeva number: {0}", num.ToString());
            ////    }
            ////    catch (SystemException)
            ////    {
            ////    }

            ////}

            ////string nimetus = "";
            ////switch (num)
            ////{
            ////    case 1: nimetus = "Esmaspäev"; break;
            ////    case 2: nimetus = "Teisipaev"; break;
            ////    case 3: nimetus = "kolmapaev"; break;
            ////    case 4: nimetus = "Neljapaev"; break;
            ////    case 5: nimetus = "Reedel"; break;
            ////    case 6: nimetus = "Laupaev"; break;
            ////    case 7: nimetus = "Puhapaev"; break;

            ////    default:
            ////        nimetus = "Viga!";
            ////        break;
            ////}
            ////Console.WriteLine(nimetus);
            ////StreamWriter filesse = new StreamWriter(@"..\..\andmed.txt", true);
            ////filesse.WriteLine("Number oli {0}, päev on {1}", num, nimetus);
            ////filesse.Close();
            ////Console.WriteLine("Failis oli salvestut: Number oli " + num.ToString() + "päev on " + nimetus);

            ////StringReader filest = new StringReader(@"..\..\andmed.txt");
            ////string a = filest.ReadToEnd();
            ////Console.WriteLine("Falis oli seda: \n" + a);



            ////Console.ReadLine();//Ждет enter. завершение кода.


            ////Console.WriteLine("Find the value of the expression with setting arbitrary values ​​of the remaining variables.");

            ////int a=0;
            ////int b=0;
            ////Random rnd = new Random();
            ////Console.WriteLine( a = rnd.Next(1, 10));
            ////Console.WriteLine( b = rnd.Next(1, 10));
            ////Console.Clear();
            ////Console.WriteLine("Find the value of the expression with setting arbitrary values ​​of the remaining variables.");
            ////Console.WriteLine("a= " + a.ToString()  );
            ////Console.WriteLine("b= " + b.ToString()  );
            ////Console.WriteLine ("a=(2*a+b)=" + (2* a + b));
            ////Console.WriteLine("b=(11*a-13*b)=" + (11 * a - 13 * b));
            ////Console.WriteLine("c=(2*a+b) / (11*a-13*b)=" + (2 * a + b) / (11 * a - 13 * b));
            ////StreamWriter filesse = new StreamWriter(@"..\..\expressions.txt", true);
            ////filesse.WriteLine("a=(2*a+b) a=" + (2 * a + b),
            ////    "b=(11*a-13*b)" + (11 * a - 13 * b),
            ////    "c=(2*a+b) / (11*a-13*b)=" + (2 * a + b) / (11 * a - 13 * b)) ;

            ////filesse.Close();


            Console.ReadLine();
        }
    }
}
