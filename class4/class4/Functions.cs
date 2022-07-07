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

        //ハンズオン04
        //string[] argsの中身を検知してバースを試みる
        //バースに失敗した場合、ハンズオン02の関数を呼ぶ
        public static double ParseArgsAndWaitInputIfParseFailed(string[] arguments,int argumetIndex,string askText)
        {
            double result = 0;
            bool weightOptionIsValid = false;
            if (arguments.Length > argumetIndex)
            {
                string arg = arguments[argumetIndex];
                weightOptionIsValid = double.TryParse(arg, out result);
            }
            if (!weightOptionIsValid)
            {
                Console.WriteLine(askText);
                result = WaitInputAndParseToDouble();
            }
            return result;
        }
       //ハンズオン05の関数
       //ノーマル
       public static void NormalSample(int value)
        {
            value += 1;
        }

        public static void RefSample(ref int value)
        {
            value += 1;
        }

        //ハンズオン06
        public static (double,double,double) GetvectorMagnitudeAndNormalized
            (double x, double y)
        {
            //ルートをとる
            double magnitude= Math.Sqrt(x*x+y*y);

            //正規化ベクトル
            return(magnitude,x/magnitude,y/magnitude);
        }
    }
}
