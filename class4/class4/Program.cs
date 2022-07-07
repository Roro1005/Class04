using class4;

//ハンズオン01
/*
long a = 10;
long c = 5;

long b =Functions.Power(a,c);

Console.WriteLine(b);
*/

/*
//ハンズオン02
Console.WriteLine("体重を入力してください(kg)");
double weight = Functions.WaitInputAndParseToDouble();
Console.WriteLine("体重は" + weight.ToString("F2") + "です。");

Console.WriteLine("身長を入力してください(m)");
double height = Functions.WaitInputAndParseToDouble();
Console.WriteLine("身長は" + height.ToString("F2") + "です。");

double BMI = weight / (height * height);
Console.WriteLine("BMIは" + BMI.ToString("F2") + "です。");
*/
for(int i = 0;i<args.Length;i++)
{
    Console.WriteLine("オプション"+i+":"+args[i]);
}

//ハンズオン04
//argsに身長・体重が入っていたら入力受付をスキップする
/*
double weight=Functions.ParseArgsAndWaitInputIfParseFailed(args,0, "体重を入力してください(kg)");
Console.WriteLine("体重は" + weight.ToString("F2") + "です。");

double height = Functions.ParseArgsAndWaitInputIfParseFailed(args,1, "身長を入力してください(m)");
Console.WriteLine("身長は" + height.ToString("F2") + "です。");

double BMI = weight / (height * height);
Console.WriteLine("BMIは" + BMI.ToString("F2") + "です。");
*/

//ハンズオン05
/*
int value05 = 10;
Console.WriteLine("normal before:" + value05);
Functions.NormalSample(value05);
Console.WriteLine("normal after:" + value05);

value05 = 10;
Console.WriteLine("ref before:" + value05);
Functions.RefSample(ref value05);
Console.WriteLine("ref after:"+value05);
*/

//ハンズオン06
/*
double x = 1.65;
double y = 5.786;

(double magnitude, double normalizedX, double normalizedY)
    = Functions.GetvectorMagnitudeAndNormalized(x, y);

Console.WriteLine("絶対値:" + magnitude);
Console.WriteLine("正規化ベクトル x:"+normalizedX);
Console.WriteLine("正規化ベクトル y:" + normalizedY);
*/

//ハンズオン07
/*
string output = "";
long temp1 = 1;
long temp2 = 1;
output += "1:" + temp1+"\r\n";
output += "2:" + temp2+"\r\n";
for(int i=3;i<=50;i++)
{
    long next = temp1 + temp2;
    output += i.ToString() + ":" + next + "\r\n";
    //1つづつ変数の数値をずらす
    temp1 = temp2;
    temp2 = next;
}
System.IO.File.WriteAllText(@"C:\Users\student\Desktop\CSharp\output.txt",output);
*/

//ハンズオン08
System.Net.WebClient wc = new System.Net.WebClient();

for(int i = 1; i <=16; i++)
{
    string numberText = i.ToString("D3");
    wc.DownloadFile("http://com-extra.jp/web_extra/2018/manga/0201/"+ numberText+".jpg", @"C:\Users\student\Desktop\CSharp\"+numberText+".jpg");
}
wc.Dispose();
Console.WriteLine("ダウンロード完了");