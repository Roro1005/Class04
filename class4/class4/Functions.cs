using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class4
{
    internal class Functions
    {
        //ハンズオン01
        
        public static int Square(int value)
        {
            int result = value*value;

            return result;
        }

        public static int Cube(int value)
        {
            int result = value*value*value;
            return result;
        }

        public static int Sum(int value,int value2)
        {
            int result = value+value2;
            return result;
        }

        public static int Sub(int value,int value2)
        {
            int result = value-value2;
            return result;
        }

        public static int Division(int value,int value2)
        {
            int result = value/value2;
            return result;
        }

        public static int Mul(int value,int value2)
        {
            int result=value*value2;
            return result;
        }

       public static long Power(long value,long power)
        {
            long result = 1;
            for(int i=0;i<power;i++)
            {
                result=result*value;
            }
            return result;
        }

        //ハンズオン02の関数
        //ユーザー入力を待機して、double型にバースして返す関数
        //ユーザーがdouble型にバースできない文字列を入力したらリトライさせる
        public static double WaitInputAndParseToDouble()
        {
            double resust = 0;
            bool parseSuccess = false;
            while (!parseSuccess)
            {
                string userWeight = Console.ReadLine();

                parseSuccess=double.TryParse(userWeight, out resust);
                if (!parseSuccess)
                {
                    Console.WriteLine("数値を入力してください。");
                }
            }
            return resust;
        }

       

        
    }
}
