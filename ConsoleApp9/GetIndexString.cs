using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    public class GetIndexString
    {
        public static void GetIndex(string str)
        {
            
            int index = 0;
            int sum = 1;
            for (int i = 0; i < str.Length - 1; i++)
            {
                int TempSum = 1;
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        TempSum++;
                    }
                    else
                    {

                        if (sum < TempSum)
                        {
                            sum = TempSum;
                            index = i;
                          

                        }

                        i = j - 1;
                        break;






                    }

                }

            }
            Console.WriteLine($"индекс - {index}  кол-во символов - {sum}");
        }
    }
}
