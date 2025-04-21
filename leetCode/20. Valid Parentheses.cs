using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





//20.Valid Parentheses
//Easy
//Topics
//Companies
//Hint
//Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

//An input string is valid if:

//Open brackets must be closed by the same type of brackets.
//Open brackets must be closed in the correct order.
//Every close bracket has a corresponding open bracket of the same type.
 

//Example 1:

//Input: s = "()"

//Output: true

//Example 2:

//Input: s = "()[]{}"

//Output: true

//Example 3:

//Input: s = "(]"

//Output: false

//Example 4:

//Input: s = "([])"

//Output: true




//Constraints:

//1 <= s.length <= 104
//s consists of parentheses only '()[]{}'.


namespace leetCode
{
    public class _20
    {
        public bool IsValid(string s)
        {
            if (s.Length % 2 != 0) return false;
            if (s[0] == ')' || s[0] == '}' || s[0] == ']') return false;
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if ((c == ')' && stack.Count != 0 && stack.Peek() == '(') ||
                        (c == '}' && stack.Count != 0 && stack.Peek() == '{') ||
                        (c == ']' && stack.Count != 0 && stack.Peek() == '['))
                    {
                        stack.Pop();
                    }
                }
            }
            return stack.Count==0;
        }
    }
}
