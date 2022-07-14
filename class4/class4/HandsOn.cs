using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class4
{
    internal class HandsOn
    {
        //ハンズオン01
        public static void HandsOn01()
        {
            int a = 12;
            int b = Functions.Square(a);
            Console.WriteLine(b);

            long c = 3; long d = 20;
            long e = Functions.Power(c, d);
            Console.WriteLine(e);
            long f = Functions.Power(c, 5);
            Console.WriteLine(f);
        }

        //ハンズオン02
        public static void HandsOn02()
        {
            Console.WriteLine("体重を入力してください(kg)");
            double weight = Functions.WaitInputAndParseToDouble();
            Console.WriteLine("体重は" + weight.ToString("F2") + "です。");

            Console.WriteLine("身長を入力してください(m)");
            double height = Functions.WaitInputAndParseToDouble();
            Console.WriteLine("身長は" + height.ToString("F2") + "です。");

            double bmi = weight / (height * height);
            Console.WriteLine("BMIは" + bmi.ToString("F4") + "です。");
        }

        //ハンズオン04
        public static void HandsOn04(string[] args)
        {
            //argsに身長・体重が入っていたら入力受付をスキップする
            double weight = Functions.ParseArgsAndWaitInputIfParseFailed
                (args, 0, "体重を入力してください(kg)");
            Console.WriteLine("体重は" + weight.ToString("F2") + "です。");

            double height = Functions.ParseArgsAndWaitInputIfParseFailed
                (args, 1, "身長を入力してください(m)");
            Console.WriteLine("身長は" + height.ToString("F2") + "です。");

            double bmi = weight / (height * height);
            Console.WriteLine("BMIは" + bmi.ToString("F4") + "です。");
        }

        //ハンズオン05
        public static void HandsOn05()
        {
            int value05 = 10;
            Console.WriteLine("normal before:" + value05);
            Functions.NormalSample(value05);
            Console.WriteLine("normal after:" + value05);

            value05 = 10;
            Console.WriteLine("ref before:" + value05);
            Functions.RefSample(ref value05);
            Console.WriteLine("ref after:" + value05);
        }

        //ハンズオン06
        public static void HandsOn06()
        {
            double x = 1.65;
            double y = 5.786;

            (double magnitude, double normalizedX, double normalizedY)
                = Functions.GetVectorMagnitudeAndNormalized(x, y);

            Console.WriteLine("絶対値:" + magnitude);
            Console.WriteLine("正規化ベクトル x:" + normalizedX);
            Console.WriteLine("正規化ベクトル y:" + normalizedY);
        }

        //ハンズオン07
        public static void HandsOn07()
        {
            string output = "";
            long temp1 = 1;
            long temp2 = 1;
            output += "1:" + temp1 + "\r\n";
            output += "2:" + temp2 + "\r\n";
            for (int i = 3; i <= 50; i++)
            {
                long next = temp1 + temp2;
                output += i.ToString() + ":" + next + "\r\n";
                //1つづつ変数の値をずらす
                temp1 = temp2;
                temp2 = next;
            }
            System.IO.File.WriteAllText
                (@"C:\Users\student\Desktop\CSharp\output.txt", output);
        }

        public static void HandsOn08()
        {
            System.Net.WebClient wc = new System.Net.WebClient();

            for (int i = 1; i <= 16; i++)
            {
                string numberText = i.ToString("D3");

                wc.DownloadFile(
                    "http://com-extra.jp/web_extra/2018/manga/0201/" + numberText + ".jpg",
                    @"C:\Users\student\Desktop\CSharp\" + numberText + ".jpg");
            }

            wc.Dispose();
            Console.WriteLine("ダウンロード完了");
        }

        public static void HandsOn09()
        {
            Console.WriteLine("ハンズオン09を実行します");

            uint seed = 0;

            uint next = Functions.GetRandomValue(seed);
            Console.WriteLine(next);

            for (int i = 0; i < 100; i++)
            {
                next = Functions.GetRandomValue(next);
                uint dice = next % 6 + 1;

                Console.WriteLine("サイコロ:" + dice);

                Console.ReadLine();
            }
        }

        public static void HandsOn10()
        {
            Console.WriteLine("ハンズオン10を実行します");
            var rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                //rand.Next(6) で0～5までの値がランダムに選ばれる
                int dice = rand.Next(6) + 1;
                Console.WriteLine("サイコロ:" + dice);
                Console.ReadLine();
            }

        }
    }
}