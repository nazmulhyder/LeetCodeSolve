using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_solve
{
    internal class Es_ValidParentheses
    {
        public static void Main(string[] args)
        {
            string setOfBrackets = "(])";
            Console.WriteLine("is it valid parentheses: {0}", IsValid(setOfBrackets));
        }

        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            if (s.Length == 1) return false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    stack.Push(s[i]);
                }

                else if (s[i] == ')' && (stack.Count == 0 || stack.Peek().Equals('{') || stack.Peek().Equals('[')))
                {
                    return false;
                }
                else if (s[i] == ')' && stack.Peek().Equals('('))
                {
                    stack.Pop();
                }

                else if (s[i] == '}' && (stack.Count == 0 || stack.Peek().Equals('(') || stack.Peek().Equals('[')))
                {
                    return false;
                }

                else if (s[i] == '}' && stack.Peek().Equals('{'))
                {
                    stack.Pop();
                }

                else if (s[i] == ']' && (stack.Count == 0 || stack.Peek().Equals('(') || stack.Peek().Equals('{')))
                {
                    return false;
                }

                else if (s[i] == ']' && stack.Peek().Equals('['))
                {
                    stack.Pop();
                }
            
            }
            if(stack.Count == 0)
            return true;
            return false;
        }
    }
}
