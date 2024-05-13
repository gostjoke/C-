using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 命名空間
namespace ConsoleApp1
{
    //類 
    internal class Program
    {
        // main 
        static void Main(string[] args)
        {
            Console.WriteLine("Hellow World");

            //int numb = 10;
            //bool te = 5 > 3;

            //int nunmber3 = 13 % 5;
            //Console.WriteLine(te);
            //Console.WriteLine(numb);
            //Console.WriteLine(nunmber3);

            // = input()
            //string text1 = Console.ReadLine();

            // 隱式轉換
            //int num2 = 10;
            //float num3;
            //num3 = num2;


            // 顯式轉換
            //float a = 3.14f;
            //int b;
            //b = (int)a;

            // convert 轉換
            //string a= "10";
            //int b = Convert.ToInt32(a);

            // switch
            //int text = Convert.ToInt16(Console.ReadLine());

            //switch (text)
            //{ 
            //    case 10: // if
            //            Console.WriteLine(10);
            //            break;
            //    case 20: // else if
            //            Console.WriteLine(20);
            //            break;
            //    default: // else
            //            Console.WriteLine("no");
            //            break;
            //};

            //  
            MyDate myDate = MyDate.Mon;
            int a = (int)myDate;

            //Console.WriteLine(b);
            //Console.ReadKey();
        }
        // 枚舉
        enum MyDate { Mon = 0, Sunday = 1 };
    }
}
