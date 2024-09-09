while (true)
{
    string s = Console.ReadLine();
    if (s == "")
    {
        break;
    }
    int[] uppercase = new int[26];
    int[] lowercase = new int[26];
    int[] digit = new int[10];
    foreach(char cha in s)
    {
        if (char.IsUpper(cha))
        {

            uppercase[cha - 'A']++;

        }
        else if (char.IsLower(cha))
        {
            lowercase[cha - 'a']++;
        }
        else if(char.IsDigit(cha))
        {
            digit[cha - '0']++; 
        }





    }
    for(int i = 0; i < 26; i++)
    {
        if (uppercase[i] > 0)
        {
            Console.WriteLine($"{(char)(i + 'A')}: {uppercase[i]}");
        }


    }

    for (int i = 0; i < 26; i++)
    {
        if (lowercase[i] > 0)
        {
            Console.WriteLine($"{(char)(i + 'a')}: {lowercase[i]}");
        }


    }

    for (int i = 0; i < 10; i++)
    {
        if (digit[i] > 0)
        {
            Console.WriteLine($"{(char)(i + '0')}: {digit[i]}");
        }


    }

    Console.WriteLine();







}