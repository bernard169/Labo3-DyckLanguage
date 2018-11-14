using System;
using System.Collections.Generic;
using System.Linq;

namespace DyckLanguage
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
             * @pre Receive a string as argument
             * @post The returned value contains true if 's' is a Dyck word
             * given that the alphabet only contains '(' and ')'
             * and false otherwise
             */
        }
            public static bool IsDyckString(string s)
            {
                Stack<string> stackedS = new Stack<string>();
                try
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                   
                         stackedS.Push(s[i].ToString());
                    }
                    int counter = new int();
                    counter = 0;
                    for (int i = 0; i < s.Length; i++)
                    {
                        string p = stackedS.Pop();
                        if (p == ")") //the stack is upside down, it starts by the end of the string (because of Push function)
                        {
                            counter++;
                        }
                        else if (p == "(")
                        {
                            counter--;
                        }
                        if (counter < 0) //if counter is negative, then there is a parenthese that closes before it was opened => not Dyck
                        {
                            return false;
                        }
                    }
                    if (counter == 0)
                    {
                        return true;
                    }
                    return false; //if the counter is not null, then a parenthese was not closed => not Dyck
                }
                catch (InvalidOperationException) 
                {
                    return false;
                }
                
            }
        }
    }
