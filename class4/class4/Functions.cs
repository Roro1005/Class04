using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class4
{
    internal class Functions
    {
        public static int Square(int value)
        {
            int result = value * value;

            return result;
        }

        //valueのn乗
        public static long Power(long value, long power)
        {
            long result = 1;
            for (int i = 0; i < power; i++)
            {
                result = result * value;
            }

            return result;
        }

        //ハンズオン02の関数
        //ユーザー入力を待機して、double型にパースして返す関数
        //ユーザーがdouble型にパースできない文字列を入力したらリトライさせる
        public static double WaitInputAndParseToDouble()
        {
            double result = 0;
            bool parseSuccess = false;
            while (!parseSuccess)
            {
                string userWeight = Console.ReadLine() ?? "";
                parseSuccess = double.TryParse(userWeight, out result);

                if (!parseSuccess)
                    Console.WriteLine("数値を入力してください");
            }

            return result;
        }

        //ハンズオン04の関数
        //string[] argsの中身を検知してパースを試みる
        //パースに失敗した場合、ハンズオン02の関数を呼ぶ
        public static double ParseArgsAndWaitInputIfParseFailed
            (string[] arguments, int argumetIndex, string askText)
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
        public static (double, double, double) GetVectorMagnitudeAndNormalized
            (double x, double y)
        {
            //ルートをとる
            double magnitude = Math.Sqrt(x * x + y * y);

            //正規化ベクトル
            return (magnitude, x / magnitude, y / magnitude);
        }

        //ハンズオン09の関数
        public static uint GetRandomValue(uint seed)
        {
            return 1103515245 * seed + 12345;
        }

    }
}

