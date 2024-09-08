
string string1 = Console.ReadLine();
string string2 = Console.ReadLine();


if (string2.Length > string1.Length)
{
    string s = string1;
    string1 = string2;
    string2 = s;

}

string2 = string2.PadLeft(string1.Length, '0');
int length = string1.Length-1;
int carry = 0;
string ans ="";
while (length >=0)
{
    int str1cha = string1[length] - '0';
    int str2cha = string2[length] - '0';
    int sum = str1cha + str2cha + carry;
    carry = sum / 10;
    ans = (sum % 10) + ans;

    length--;

}
if (carry > 0)
{
    ans = carry + ans;
}

Console.WriteLine(ans);

