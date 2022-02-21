using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures.Stack1
{
    public class Stack1
    {
        static readonly int Max = 1000;
        public int SizeOfTheStack=0;
        public int Top;
        public int[] NewStack = new int[Max];
        List<int> ReversedStack = new List<int>();
        

        public Stack1(int Size)
        {
            Top = -1;
        }
        bool IsEmpty()
        {
            return (Top < 0);
        }
        
        //PUSH OPERATION
        public void PushData(int Data)
        {
            try
            {
                if (Top >= Max)
                {
                    Console.WriteLine("Stack Is Already Full");
                    return;
                }
                else
                {
                    NewStack[++Top] = Data;
                    Console.WriteLine($"Sucesfully Inserted {Data} at the Top");
                    SizeOfTheStack += 1;

                }
                Console.WriteLine("\n");
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        //POP OPERATION
        public void PopData()
        {
            try
            {
                if (Top < 0)
                {
                    Console.WriteLine("The Stack is Already Empty");
                    return;
                }
                else
                {
                    int Popedvalue = NewStack[Top--];
                    Console.WriteLine($"The Data {Popedvalue} is removed from the Top");
                    SizeOfTheStack -= 1;

                }
                Console.WriteLine("\n");
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        //PEEK OPERATION
        public void Peek()
        {
            try
            {
                if (Top < 0)
                {
                    Console.WriteLine("Stack is Already Empty");
                    return;
                }
                else
                {
                    Console.WriteLine($"The Top most Element of the Stack is : {NewStack[Top]}");
                }
                Console.WriteLine("\n");
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        //PRINT ALL THE ELEMENTS IN STACK
        public void PrintStack()
        {
            try
            {
                if (Top < 0)
                {
                    Console.WriteLine("Stack is Already Empty");
                    return;
                }
                else
                {
                    Console.WriteLine("Items in the stack are such:- ");
                    for (int i = Top; i >= 0; i--)
                    {
                        Console.Write(NewStack[i] + " ");
                    }
                }
                Console.WriteLine("\n");
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        //CONTAINS OPERATION
        public void ContainsData(int Data)
        {
            try
            {
                bool DoesContains = false;
                if (Top < 0)
                {
                    Console.WriteLine("Stack is Already Empty");
                    return;
                }
                else
                {
                    for (int index = 0; index <= Top; index++)
                    {
                        if (NewStack[index] == Data)
                        {
                            Console.WriteLine($"The Data {Data} is Present at Position {index} in the stack");
                            DoesContains = true;
                        }
                    }
                    if (!DoesContains)
                    {
                        Console.WriteLine($"The Data {Data} is not present in the stack");

                    }
                    Console.WriteLine("\n");
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            
           

        }
       

        //REVERSING THE STACK
        public void PrintReversedStack()
        {
            try
            {
                for (int i = Top; i >= 0; i--)
                {
                    ReversedStack.Add(NewStack[i]);
                }

                Console.WriteLine("The Reversed Stack is: ");
                for (int i = ReversedStack.Count - 1; i >= 0; i--)
                {

                    Console.Write(ReversedStack[i] + " ");
                }
                Console.WriteLine("\n");
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        //SIZE OF STACK
        public void SizeOfStack()
        {
            try
            {
                Console.WriteLine($"The Size is: {SizeOfTheStack}");
            }
            catch(Exception e)
            {
                throw e;
            }
        }


        /*static void Main(string[] args)
        /*{
            Stack1 MyStack = new Stack1(10);
            MyStack.PushData(1);
            MyStack.PushData(2);
            MyStack.PushData(3);
            MyStack.PushData(4);
            MyStack.PushData(5);
            MyStack.PushData(6);
            MyStack.PopData();
            MyStack.PopData();
            MyStack.ContainsData(10);
            MyStack.Peek();
            MyStack.SizeOfStack();
            MyStack.PrintStack();
            MyStack.PrintReversedStack();
          


            Console.ReadKey();

        }*/

    }
}
