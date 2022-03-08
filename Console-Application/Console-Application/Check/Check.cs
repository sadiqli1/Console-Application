using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application.Check
{
    public static class Check
    {
        public static void CheckGroupNo(string groupno)
        {
            bool resault1 = false;
            bool hasupper1 = false;
            bool hasdigit1 = false;
            do
            {
                Console.WriteLine("Please write groupno");
                groupno = Console.ReadLine();
                if (groupno.Length == 4)
                {
                    if (char.IsUpper(groupno[0]))
                    {
                        hasupper1 = true;
                        for (int i = 1; i < groupno.Length; i++)
                        {
                            if (char.IsDigit(groupno[i]))
                            {
                                hasdigit1 = true;
                            }
                            else
                            {
                                hasdigit1 = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        hasupper1 = false;

                    }
                }
                else
                {
                    resault1 = false;
                }
                resault1 = hasupper1 && hasdigit1;
            } while (resault1 == false);
        }
    }
}
