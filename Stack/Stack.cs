using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms.Stack
{
    public class Stack
    {
        /// <summary>
        /// The stack
        /// </summary>
        private int[] stack;

        /// <summary>
        /// Initializes a new instance of the <see cref="Stack"/> class.
        /// </summary>
        /// <param name="size">The size.</param>
        public Stack(int size)
        {
            this.stack = new int[size];
            this.Count = 0;
        }

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public int Count { get; private set; }

        /// <summary>
        /// Pushes the specified n.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>return integer value</returns>
        public int Push(char n)
        {
            if (this.Count == this.stack.Length)
            {
                Console.WriteLine("Stack is Overflow");
            }
            else
            {
                this.stack[this.Count++] = n;
            }

            return 0;
        }

        /// <summary>
        /// Pops this instance.
        /// </summary>
        /// <returns>return integer value</returns>
        public int Pop()
        {
            int result = -1;
            if (this.Count == 0)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                result = this.stack[--this.Count];
            }

            return result;
        }

        /// <summary>
        /// Prints the stack.
        /// </summary>
        public void PrintStack()
        {
            if (this.IsStackEmpty())
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine("Stack data");
                for (int i = this.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(this.stack[i]);
                }
            }
        }

        /// <summary>
        /// Determines whether [is stack empty].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is stack empty]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsStackEmpty()
        {
            if (this.Count == 0)
            {
                
                return true;
            }
            else
            {
                
                return false;
            }
        }
       
    }


}
