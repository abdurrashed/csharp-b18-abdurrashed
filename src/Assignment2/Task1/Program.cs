



string str = Console.ReadLine();
string[] stringarr = str.Split(' ');

for (int j= 0; j < stringarr.Length; j++)
{
    stringarr[j] = stringarr[j].Trim();
}

int numerator = int.Parse(stringarr[0]);
int denominator = int.Parse(stringarr[1]);
int length = int.Parse(stringarr[2]);

int res = numerator / denominator;
int reminder = numerator % denominator;
int i = 0;
string ans = res + ".";
while (i < length)
{
    reminder = reminder * 10;
    res = reminder / denominator;
    reminder = reminder % denominator;

    ans = ans + res;

    i++;
}

Console.WriteLine(ans);
