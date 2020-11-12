/*
 * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', 
 * determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
 
Example 1:

Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true
Example 3:

Input: s = "(]"
Output: false
Example 4:

Input: s = "([)]"
Output: false
Example 5:

Input: s = "{[]}"
Output: true

Constraints:

1 <= s.length <= 104
s consists of parentheses only '()[]{}'.
 */

using System.Collections;

namespace Playground
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            var map = new System.Collections.Generic.Dictionary<char, char>() {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' }
            };

            var stack = new System.Collections.Generic.Stack<char>();

            foreach (char c in s)
            {
                if (map.ContainsKey(c)) // is opening bracket
                {
                    stack.Push(c);
                }
                else // is closing bracket 
                {
                    if (stack.Count == 0 || // and there was not opening braket
                        map[stack.Pop()] != c) // and opening bracket does not match
                        return false;
                }
            }

            return stack.Count == 0;
        }

        // no maps or generics is the fastest
        public bool IsValidNoMap(string s)
        {
            var stack = new Stack(); // changing from generic to standard Stack reduced the time. 
                                     // It actually had more impact than removing the hash

            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{') // is opening bracket 
                {
                    stack.Push(c);
                }
                else // is closing bracket 
                {
                    if (stack.Count == 0) return false; // and there was not opening braket

                    var last = (char)stack.Pop();

                    if ((c == ')' && last != '(') || // and opening bracket does not match
                        (c == ']' && last != '[') ||
                        (c == '}' && last != '{'))
                        return false;
                }
            }

            return stack.Count == 0;
        }

        public bool IsValidNoGenerics(string s)
        {
            var map = new Hashtable() {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' }
            };

            var stack = new Stack();

            foreach (char c in s)
            {
                if (map.ContainsKey(c)) // is opening bracket
                {
                    stack.Push(c);
                }
                else // is closing bracket 
                {
                    if (stack.Count == 0 || // and there was not opening braket
                        (char)map[stack.Pop()] != c) // and opening bracket does not match
                        return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
