using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraverseStackArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temperatures ={73, 74, 75, 71, 69, 72, 76, 73};
            int[] days = new int[temperatures.Length];
            // we are using a stack to remeber all the temps we saw until now,
            // the next time we see one which is higher we pop all the temps which are lower
            Stack<int> stack = new Stack<int>();
            for (int i = temperatures.Length - 1; i >= 0; i--)
            {
                //if the current temp is greater or equals to the top of the stack
                // pop all until found one which is higher temp then T[i]
                while (stack.Count > 0 && temperatures[i] >= temperatures[stack.Peek()])
                {
                    stack.Pop();
                }

                if (stack.Count == 0)
                {
                    days[i] = 0;
                }
                else
                {
                    days[i] = stack.Peek() - i; // number of days between higher temp to i
                }
                stack.Push(i);// we push current temp to the Top of the stack.
            }

        }
    }
}
