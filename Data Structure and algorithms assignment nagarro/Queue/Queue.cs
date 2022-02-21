using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structures.Queue
{
    public class Queue
    {
        private int[] QueueImplementation;
        private int front;
        private int rear;
        private int max;
        private int QueueElementCount = 0;
        private int Dequeuecount=0;


        public Queue(int size)
        {
            QueueImplementation = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }
        
        //ENQUEUE
        public void EnQueue(int item)
        {
            try
            {
                if (rear == max - 1)
                {
                    Console.WriteLine("Queue is Already Full");
                    Console.WriteLine("\n");
                    return;
                }
                else
                {
                    Console.WriteLine($"{item} is now being Inserted at Queue");
                    Console.WriteLine("\n");
                    QueueImplementation[++rear] = item;
                    QueueElementCount += 1;
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }
        
        //DEQUEUE
        public int DeQueue()
        {
            try
            {
                if (front == rear + 1)
                {
                    Console.WriteLine("Queue is Already Empty");
                    return -1;
                }
                else
                {
                    Console.WriteLine("Dequeued element is: " + QueueImplementation[front]);
                    Console.WriteLine("\n");
                    QueueElementCount -= 1;
                    Dequeuecount += 1;
                    return QueueImplementation[front++];

                }
            }
            catch(Exception e)
            {
                throw e;
                
            }
           
           
        }
        
        //PEEK
        public void Peek()
        {
            try
            {
                Console.WriteLine($"The Element is the front is: {QueueImplementation[front]}");
                Console.WriteLine("\n");
                return;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        
        //CONTAINS
        public void ElementContains(int Element)
        {
            try
            {
                bool FoundElement = false;
                if (front == rear + 1)
                {
                    Console.WriteLine("Queue is Already Empty");

                }
                else
                {
                    for (int i = Dequeuecount; i < QueueImplementation.Length; i++)
                    {
                        if (QueueImplementation[i] == Element)
                        {
                            Console.WriteLine($"Found Element {Element} at index {i} in the queue");
                            FoundElement = true;
                            Console.WriteLine("\n");
                        }

                    }
                    if (!FoundElement)
                    {
                        Console.WriteLine($"{Element} is not present in the queue");
                        Console.WriteLine("\n");

                    }
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        //SIZE
        public void Size()
        {
            try
            {
                Console.WriteLine($"The Size of the queue is: {QueueElementCount}");
                Console.WriteLine("\n");
                return;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //PRINT
        public void PrintQueue()
        {
            try
            {
                if (front == rear + 1)
                {
                    Console.WriteLine("Queue is Already Empty");
                    Console.WriteLine("\n");
                    return;
                }
                else
                {
                    for (int i = front; i <= rear; i++)
                    {
                        Console.WriteLine("Item[" + (i + 1) + "]: " + QueueImplementation[i]);
                    }
                }
                Console.WriteLine("\n");
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        //REVERSE
        public void ReverseQueue()
        {
            try
            {
                int[] ReverseQueue = Enumerable.Reverse(QueueImplementation).ToArray();
                for (int i = 0; i < QueueElementCount; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + ReverseQueue[i]);

                }
                Console.WriteLine("\n");
            }
            catch(Exception e)
            {
                throw e;
            }
        }


       /* static void Main(string[] args)
        {
            Queue NewQueue = new Queue(5);
            NewQueue.EnQueue(10);
            NewQueue.EnQueue(11);
            NewQueue.EnQueue(12);
            NewQueue.EnQueue(13);
            NewQueue.EnQueue(14);
            NewQueue.EnQueue(15);
            NewQueue.EnQueue(21);
            NewQueue.DeQueue();
            NewQueue.DeQueue();
            NewQueue.PrintQueue();
            NewQueue.Peek();
            NewQueue.ElementContains(12);
            NewQueue.ReverseQueue();
            NewQueue.Size();
            
        }*/

    }
   
}
