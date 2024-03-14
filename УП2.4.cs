using System;
using System.Collections.Generic;

class RomanToInteger
{
    public static int RomanToInt(string s)
    {
        Dictionary<char,int> romanList = new Dictionary<char,int>
        {
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };

        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i < s.Length - 1 && romanList[s[i]] < romanList[s[i + 1]])
            {
                result += romanList[s[i + 1]] - romanList[s[i]];
                i++;
            }
            else
            {
                result += romanList[s[i]];
            }
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine("Введите римское число: ");
        string romanNum = Console.ReadLine();
        int integerNum = RomanToInt(romanNum);
        Console.WriteLine($"Преобразование в целое число: {integerNum}");
    }
}