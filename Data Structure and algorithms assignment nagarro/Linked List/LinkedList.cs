using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures.Linked_List
{
    public class LinkedList
    {
        
        public int Data;
        public LinkedList Next;

        public LinkedList(int DataToBeInserted)
        {
            Data = DataToBeInserted;
            Next = null;

        }

       

        public class LinkedListNode
        {
            static LinkedList Head;
            public int counter;
            public int CentreNode;
            //public int NextNodePointer = 0;
            public int IteratorPosition = 0;
            /*public LinkedList IteratorPointer = Head;*/

            public LinkedListNode()
            {
                Head = null;
                counter=0;
            }

            //INSERT AT  THE START
            public void InsertAtBeginning(int NewData)
            {
                try
                {
                    Console.WriteLine($"Inserting {NewData} at the Front");
                    LinkedList NewNode = new LinkedList(NewData);
                    NewNode.Next = Head;
                    Head = NewNode;
                    counter++;
                    Console.WriteLine("\n");
                }
                catch(Exception e)
                {
                    throw e;

                }

            }

            //INSERT AT END
            public void InsertAtEnd(int NewData)
            {
                try
                {
                    Console.WriteLine($"Inserting {NewData} at the End");
                    LinkedList NewNode = new LinkedList(NewData);
                    //ITERATOR
                    LinkedList Pointer = Head;
                    while (Pointer != null)
                    {

                        if (Pointer.Next == null)
                        {
                            Pointer.Next = NewNode;
                            NewNode.Next = null;
                            counter++;
                            break;
                        }
                        Pointer = Pointer.Next;
                    }
                    Console.WriteLine("\n");
                }
                catch(Exception e)
                {
                    throw e;
                }


            }

            //DELETE FROM START
            public void  DeleteFromBeginning()
            {
                try
                {
                    Console.WriteLine("Deleting From The Beginning");
                    //ITERATOR
                    LinkedList Pointer = Head;
                    Head = Pointer.Next;
                    Pointer = null;
                    counter--;

                    Console.WriteLine("\n");
                }
                catch(Exception e)
                {
                    throw e;
                }


            }

            //DELETE FROM THE END
            public void DeleteFromEnd()
            {
                try
                {
                    Console.WriteLine("Deleting From the Last");
                    //ITERATOR
                    LinkedList Pointer = Head;
                    Pointer = Pointer.Next;
                    while (Pointer != null)
                    {
                        if (Pointer.Next.Next == null)
                        {
                            Pointer.Next = null;
                            counter--;
                            break;
                        }
                        Pointer = Pointer.Next;
                    }
                    Console.WriteLine("\n");
                }
                catch(Exception e)
                {
                    throw e;
                }


            }

            //INSERTING AT GIVEN POSITION(INDEX)
            public void InsertAtPosition(int Index,int NewData)
            {
                try
                {
                    Console.WriteLine($"Inserting {NewData} at the Position {Index}");
                    LinkedList NewNode = new LinkedList(NewData);
                    //ITERATOR
                    LinkedList Pointer = Head;
                    int PositionCount = 0;
                    while (Pointer.Next != null)
                    {
                        if (PositionCount == Index - 1)
                        {
                            NewNode.Next = Pointer.Next;
                            Pointer.Next = NewNode;
                            counter++;
                            break;


                        }
                        else if (Index == 0)
                        {
                            NewNode.Next = Head;
                            Head = NewNode;
                            counter++;
                            break;

                        }
                        else
                        {

                            Pointer = Pointer.Next;
                            PositionCount += 1;
                        }
                    }
                    PositionCount += 1;
                    if (Pointer.Next == null && PositionCount == Index)
                    {
                        Pointer.Next = NewNode;
                        NewNode.Next = null;
                        counter++;

                    }

                    Console.WriteLine("\n");
                }
                catch(Exception e)
                {
                    throw e;
                }



            }

            //DELETING FROM THE GIVEN POSITION(INDEX)
            public void DeleteAtPosition(int Index)
            {
                try
                {
                    Console.WriteLine($"Deleting Node from the Position {Index}");
                    //ITERATOR
                    LinkedList Pointer = Head;
                    int PositionCount = 0;
                    while (Pointer.Next != null)
                    {
                        if (Index == 0)
                        {
                            Head = Pointer.Next;
                            Pointer = null;
                            counter--;
                            break;

                        }
                        else if (PositionCount == Index - 1)
                        {

                            Pointer.Next = Pointer.Next.Next;
                            counter--;
                            break;

                        }
                        else
                        {
                            Pointer = Pointer.Next;
                            PositionCount += 1;
                        }
                    }
                    Console.WriteLine("\n");
                }
                catch(Exception e)
                {
                    throw e;
                }
              


            }

           //TRAVERSING THE LINKED LIST
            public void PrintLinkedList()
            {
                try
                {
                    
                    LinkedList Pointer = Head;
                    int PositionCount = 0;
                    Console.WriteLine($"The Elements in the Linked List are as: ");
                    while (Pointer != null)
                    {

                        Console.Write(Pointer.Data + "  ");
                        Pointer = Pointer.Next;
                        PositionCount += 1;
                    }
                    Console.WriteLine("\n");
                }
                catch(Exception e)
                {
                    throw e;
                }
            }
           
            //REVERSE OF A LINKED LIST
            public LinkedList ReverseLinkedList(LinkedList Head)
            {
                LinkedList CurrentNode = Head;
                LinkedList PreviousNode = null;
                LinkedList TempNext;
                while (CurrentNode != null)
                {
                    TempNext = CurrentNode.Next;
                    CurrentNode.Next = PreviousNode;
                    PreviousNode = CurrentNode;
                    CurrentNode = TempNext;
                }
                //PreviousNode = CurrentNode;
                return PreviousNode;
            }

            //PRINTING THE REVERSE OF A LINKED LIST
            public void PrintReversedList()
            {
                try
                {
                    LinkedList CurrentNode = ReverseLinkedList(Head);
                    Console.WriteLine("The Reversed Linked List is: ");
                    while (CurrentNode != null)
                    {
                        Console.Write(CurrentNode.Data + "  ");
                        CurrentNode = CurrentNode.Next;
                    }
                    Console.WriteLine("\n");
                }
                catch(Exception e)
                {
                    throw e;
                }

            }
            


            //SIZE OF THE LINKED LIST
            public void SizeofLinkedList()
            {
                try
                {
                    Console.WriteLine($"The Size of the Linked List is: {counter}");
                    Console.WriteLine("\n");
                }
                catch(Exception e)
                {
                    throw e;
                }

            }
            

            //PRINTING THE CENTRE NODE OF THE LINKED LIST
            public void PrintCentreNode()
            {
                try
                {
                    
                    LinkedList Pointer = Head;
                    int PositionCount = 0;
                    int MidIndex = counter / 2;
                    while (Pointer.Next != null)
                    {
                        if (PositionCount == MidIndex)
                        {
                            CentreNode = Pointer.Data;
                            Console.WriteLine($"The Centre Node in the Linked List is {CentreNode}");
                            break;

                        }

                        PositionCount += 1;
                        Pointer = Pointer.Next;

                    }

                    Console.WriteLine("\n");
                }
                catch(Exception e)
                {
                    throw e;
                }
            }
        }
        /*static void Main(string[] args)
        {
            LinkedListNode MyLinkedList = new LinkedListNode();
            MyLinkedList.InsertAtBeginning(10);
            MyLinkedList.PrintLinkedList();
            MyLinkedList.InsertAtBeginning(11);
            MyLinkedList.PrintLinkedList();
            MyLinkedList.InsertAtBeginning(20);
            MyLinkedList.PrintLinkedList();
            MyLinkedList.InsertAtEnd(30);
            MyLinkedList.PrintLinkedList();
            MyLinkedList.InsertAtEnd(40);
            MyLinkedList.PrintLinkedList();
            MyLinkedList.InsertAtEnd(50);
            MyLinkedList.PrintLinkedList();
            MyLinkedList.InsertAtPosition(3, 100);
            MyLinkedList.PrintLinkedList();
            MyLinkedList.InsertAtPosition(5, 200);
            MyLinkedList.PrintLinkedList();
            MyLinkedList.DeleteFromBeginning();
            MyLinkedList.PrintLinkedList();
            MyLinkedList.DeleteFromEnd();
            MyLinkedList.PrintLinkedList();
            MyLinkedList.DeleteAtPosition(1);
            MyLinkedList.PrintLinkedList();
            MyLinkedList.PrintCentreNode();
            MyLinkedList.PrintReversedList();
            MyLinkedList.SizeofLinkedList();
            
           
            
            

            
        }*/

    }
}
