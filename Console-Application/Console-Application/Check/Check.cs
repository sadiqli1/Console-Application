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
                if (resault1 == false)
                {
                    Console.WriteLine("Please enter correct groupno");
                    groupno = Console.ReadLine();
                }
            } while (resault1 == false);
        }

        public static void CheckFullname(string fullname)
        {
            bool resault = false;
            bool length = false;
            bool hasupper = false;
            bool haslower = false;
            bool hasdigit = false;
            do
            {
                string[] fulnamestr = fullname.Split(" ");
                foreach (string item in fulnamestr)
                {
                    if (item.Length >= 3)
                    {
                        length=true;
                        if (char.IsUpper(item[0]))
                        {
                            hasupper = true;
                        }
                        else
                        {
                            hasupper = false;
                            break;
                        }
                        for (int i = 1; i < item.Length; i++)
                        {
                            if (char.IsLower(item[i]) && !char.IsDigit(item[i]))
                            {
                                haslower = true;
                                hasdigit = true;
                            }
                            else
                            {
                                haslower = false;
                                hasdigit = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        length = false;
                        break;
                    }
                }
                resault = hasupper && haslower && hasdigit&&length;
                if (resault==false)
                {
                    Console.WriteLine("Please enter correct name and surname(Example:Barack Obama)");
                    fullname = Console.ReadLine();
                }
            } while (resault == false);
        }
    }
}
