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
double weight=0;
bool weightOptionIsValid=false;
if(args.Length>0)
{
    string arg0=args[0];
    weightOptionIsValid=double.TryParse(arg0,out weight);
}
if(!weightOptionIsValid)
{
    Console.WriteLine("体重を入力してください(kg)");
    weight = Functions.WaitInputAndParseToDouble();
}
Console.WriteLine("体重は" + weight.ToString("F2") + "です。");

double height = 0;
bool heightOptionIsValid=false;
if(args.Length > 1)
{
    string arg1=args[1];
    heightOptionIsValid= double.TryParse(arg1, out height);
}
if(!heightOptionIsValid)
{
    Console.WriteLine("身長を入力してください(m)");
    height = Functions.WaitInputAndParseToDouble();
}
Console.WriteLine("身長は" + height.ToString("F2") + "です。");

double BMI = weight / (height * height);
Console.WriteLine("BMIは" + BMI.ToString("F2") + "です。");