using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms.Queue
{
    public class Queue
    {
        /// <summary>
        /// The front
        /// </summary>
        private Queue front, rear;

        /// <summary>
        /// The data
        /// </summary>
        private int data;

        /// <summary>
        /// The next
        /// </summary>
        private Queue next;

        /// <summary>
        /// Initializes a new instance of the <see cref="Queue"/> class.
        /// </summary>
        /// <param name="d">The d.</param>
        public Queue(int d)
        {
            this.data = d;
            this.next = null;
        }

        /// <summary>
        /// Enqueues the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Enqueue(int data)
        {
            Queue temp = new Queue(data);
            if (this.rear == null)
            {
                this.rear = this.front = temp;
            }

            this.rear.next = temp;
            this.rear = temp;
        }

        /// <summary>
        /// DeQueue this instance.
        /// </summary>
        /// <returns>return delete element</returns>
        public Queue Dequeue()
        {
            if (this.front == null)
            {
                return null;
            }

            Queue temp = this.front;
            this.front = this.front.next;

            if (this.front == null)
            {
                this.rear = null;
            }

            return temp;
        }

        /// <summary>
        /// Queues the display.
        /// </summary>
        public void QueueDisplay()
        {
            Queue temp;
            if (this.front == null)
            {
                Console.WriteLine("Queue is empty ");
            }
            else
            {
                temp = this.front;
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Determines whether [is queue empty].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is queue empty]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsQueueEmpty()
        {
            return this.front == this.rear;
        }
    }


}

