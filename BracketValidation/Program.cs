using System;
using System.Collections.Generic;

namespace Solution.BracketValidation
{
    public class BracketValidator
    {
        private class Stack
        {
            private List<char> items = new List<char>();

            public void Push(char c) => items.Add(c);

            public char Pop()
            {
                if (items.Count == 0) return '\0';
                char c = items[^1];
                items.RemoveAt(items.Count - 1);
                return c;
            }

            public bool IsEmpty() => items.Count == 0;
        }

        public static bool ValidasiEkspresi(string ekspresi)
        {
            Stack stack = new Stack();
            foreach (char c in ekspresi)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    char top = stack.Pop();
                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }
            return stack.IsEmpty();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            string ekspresiValid = "[{}](){}";
            string ekspresiInvalid = "(]";

            Console.WriteLine($"Ekspresi '{ekspresiValid}' valid? {BracketValidator.ValidasiEkspresi(ekspresiValid)}");
            Console.WriteLine($"Ekspresi '{ekspresiInvalid}' valid? {BracketValidator.ValidasiEkspresi(ekspresiInvalid)}");
        }
    }
}
