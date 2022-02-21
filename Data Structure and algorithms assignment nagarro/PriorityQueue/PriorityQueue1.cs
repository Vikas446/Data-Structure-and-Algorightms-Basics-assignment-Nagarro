using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structures.PriorityQueue
{
    public class PriorityQueue1
    {
        private int[] PriorityQueueImplementation;
        private int front;
        private int rear;
        private int max;
        private int PriorityQueueSize;

        public PriorityQueue1(int size)
        {
            PriorityQueueImplementation = new int[size];
            front = -1;
            rear = -1;
            max = size;
        }
        
        //ENQUEUE
        public void Enqueue(int Data)
        {
            try
            {
                if (rear >= max - 1)
                {
                    Console.WriteLine("Queue is already full, no more elements can be inserted");
                    return;
                }
                else if ((front == -1) && (rear == -1))
                {
                    Console.WriteLine($"The Element {Data} is being inserted in the Queue");
                    front++;
                    rear++;
                    PriorityQueueImplementation[rear] = Data;
                    PriorityQueueSize += 1;
                    Console.WriteLine("\n");
                    return;
                }
                else
                    CheckPriority(Data);

                rear++;
                Console.WriteLine("\n");
            }
            catch(Exception e)
            {
                throw e;
            }

        }

        //FIND PRIORITY 
        public void CheckPriority(int Data)
        {
            try
            {
                int i, j;
                PriorityQueueSize += 1;
                Console.WriteLine($"The Element {Data} is being inserted in the Queue");
                for (i = 0; i <= rear; i++)
                {
                    if (Data >= PriorityQueueImplementation[i])
                    {
                        for (j = rear + 1; j > i; j--)
                        {
                            PriorityQueueImplementation[j] = PriorityQueueImplementation[j - 1];
                        }
                        PriorityQueueImplementation[i] = Data;
                        return;
                    }
                }

                PriorityQueueImplementation[i] = Data;
            }
            catch(Exception e)
            {
                throw e;
            }
           
        }

        //DEQUEUE
        public void Dequeue_By_Priority(int Data)
        {
            try
            {
                int i;

                if ((front == -1) && (rear == -1))
                {
                    Console.WriteLine("Queue is Already Empty no elements to be deleted");
                    Console.WriteLine("\n");
                    return;
                }
                else
                {
                    for (i = 0; i <= rear; i++)
                    {
                        if (Data == PriorityQueueImplementation[i])
                        {
                            Console.WriteLine($"The Element {Data} is being deleted from the Queue");
                            PriorityQueueSize -= 1;
                            for (; i < rear; i++)
                            {
                                PriorityQueueImplementation[i] = PriorityQueueImplementation[i + 1];
                            }

                            PriorityQueueImplementation[i] = -99;
                            rear--;


                            if (rear == -1)
                                front = -1;
                            Console.WriteLine("\n");
                            return;
                        }
                    }


                }
                Console.WriteLine($"Did not Not found {Data} in queue to delete");
                Console.WriteLine("\n");
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        //PRINT PRIORITY QUEUE
        public void PrintPriorityQueue()
        {
            try
            {
                if ((front == -1) && (rear == -1))
                {
                    Console.WriteLine("Queue is Already empty");
                    return;
                }

                for (; front <= rear; front++)
                {
                    Console.WriteLine("Item[" + (front + 1) + "]: " + PriorityQueueImplementation[front]);
                }

                front = 0;
                Console.WriteLine("\n");
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        //CONTAINS
        public void Contains(int Data)
        {
            try
            {
                bool FoundElement = false;
                if ((front == -1) && (rear == -1))
                {
                    Console.WriteLine("Queue is Already empty");
                    return;
                }
                else
                {
                    for (; front <= rear; front++)
                    {
                        if (Data == PriorityQueueImplementation[front])
                        {
                            Console.WriteLine($"Found {Data} at index {front + 1}");
                            FoundElement = true;
                        }
                    }
                    if (!FoundElement)
                    {
                        Console.WriteLine($"Element {Data} not found in the Queue");
                    }
                }
                front = 0;
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        
        //REVERSE PRIORITY QUEUE
        public void ReversePriorityQueue()
        {
            try
            {
                int[] ReverseQueue = Enumerable.Reverse(PriorityQueueImplementation).ToArray();
                for (int i = ReverseQueue.Length - PriorityQueueSize; i < ReverseQueue.Length; i++)
                {
                    Console.WriteLine($"Item[{(i + 1) - (ReverseQueue.Length - PriorityQueueSize)}]: " + ReverseQueue[i]);

                }
                Console.WriteLine("\n");
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
                Console.WriteLine($"The Element with the Highest priority is {PriorityQueueImplementation[front]}");
                Console.WriteLine("\n");
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        //SIZE OF PRIORITY QUEUE
        public void SizeofPriorityQueue() 
        {
            try
            {
                Console.WriteLine($"The Size of Priority Queue is {PriorityQueueSize}");
                Console.WriteLine("\n");
            }
            catch(Exception e)
            {
                throw e;
            }
        }
       /* static void Main(string[] args)
        {
            PriorityQueue1 NewPriorityQueue = new PriorityQueue1(6);
            NewPriorityQueue.Enqueue(20);
            NewPriorityQueue.Enqueue(17);
            NewPriorityQueue.Enqueue(12);
            NewPriorityQueue.Enqueue(6);
            NewPriorityQueue.Enqueue(33);
            NewPriorityQueue.Enqueue(11);
            NewPriorityQueue.PrintPriorityQueue();
            NewPriorityQueue.Dequeue_By_Priority(7);
            NewPriorityQueue.SizeofPriorityQueue();
            NewPriorityQueue.PrintPriorityQueue();
            NewPriorityQueue.Dequeue_By_Priority(17);
            NewPriorityQueue.Dequeue_By_Priority(6);
            NewPriorityQueue.Peek();
            NewPriorityQueue.PrintPriorityQueue();
            NewPriorityQueue.SizeofPriorityQueue();
            NewPriorityQueue.ReversePriorityQueue();
            NewPriorityQueue.Contains(33);
        }*/
    }
   
}
