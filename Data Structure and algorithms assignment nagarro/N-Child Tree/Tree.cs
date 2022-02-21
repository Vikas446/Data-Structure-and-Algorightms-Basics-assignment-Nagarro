using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Data_Structures.N_Child_Tree
{
    public class Tree
    {

        public int Value;
        public Tree Child;
        public Tree Siblings;

        public Tree(int Data)
        {
            Value = Data;
        }
        /*static void Main(string[] args)*/
        /*{


            NchildTreeImplementation NarrayTree = new NchildTreeImplementation();
            //1st element in each row is node Value, 2nd - no of child, ,>=3rd....=>value of child
            int sizeOfTree = 0;
            int[][] data = { new int[] { 1, 3, 2, 3, 4 }, new int[] { 2, 3, 1, 6, 50 }, new int[] { 3, 3, 8, 9, 10 }, new int[] { 4, 3, 0, 0, 0, 0 } };


            for (int i = 0; i < data.GetLength(0); i++)
            {

                NarrayTree.CreateNarray(data[i]);
                for (int j = 0; j < data[i].Length; j++)
                {
                    Console.WriteLine($"Inserting Element {data[i][j]} in the Tree\n");
                    sizeOfTree += 1;

                }


            }

            //Printing thorugh DFS and BFS
            NarrayTree.Print();
            //Elements through LEVEL
            NarrayTree.Print(true);
            //CONTAINS
            NarrayTree.Contains(6);
            //Iterating though DFS
            NarrayTree.IteratingThroughDFS();
            for(int i = 0; i < sizeOfTree; i++)
            {
                int ans = NarrayTree.Next();
                if (ans != -1)
                {
                    Console.WriteLine($"Iterating {ans} in the Tree though DFS\n");
                }

            }
           


        }*/

    }
    public class NchildTreeImplementation
    {
        public Tree ROOT;
        Stack<Tree> DFSstack = new Stack<Tree>();
        public Tree Search(Tree root, int data)
        {
            if (root == null)
                return null;

            if (data == root.Value)
                return root;

            Tree t = Search(root.Child, data);
            if (t == null)
                t = Search(root.Siblings, data);

            return t;
        }

        public void CreateNarray(int[] data)
        {
            try
            {
                Tree temp = null;
                if (ROOT != null)
                    temp = Search(ROOT, data[0]);

                if (temp == null)
                {
                    temp = new Tree(data[0]);

                }
                if (this.ROOT == null)
                    ROOT = temp;
                Tree parent = temp;

                for (int Element = 0; Element < data[1]; Element++)
                {

                    if (Element == 0)
                    {
                        parent.Child = new Tree(data[Element + 2]);
                        parent = parent.Child;
                    }

                    else
                    {
                        parent.Siblings = new Tree(data[Element + 2]);
                        parent = parent.Siblings;
                    }

                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        //Printing thorugh DFS and BFS
        public void Print(bool getElementsbyLevel = false)
        {
            try
            {
                if (getElementsbyLevel)
                {
                    //Getting Elements through LEVEL
                    BFSTraversal(getElementsbyLevel);
                }
                else
                {

                    DFSTraversal();
                    BFSTraversal(getElementsbyLevel);
                }
            }
            catch(Exception e)
            {
                throw e;
            }



        }

        //DFS Traversal
        public void DFSTraversal()
        {
            try
            {
                Console.WriteLine("Traversing Through DFS \n");
                Console.Write("PREORDER:- ");
                DFSPreOrder(ROOT);
                Console.WriteLine("\n");
                Console.Write("POSTORDER:- ");
                DFSPostOrder(ROOT);
                Console.WriteLine("\n");
                Console.Write("INORDER:- ");
                DFSInOrder(ROOT);
                Console.WriteLine("\n");
            }
            catch(Exception e)
            {
                throw e;
            }


        }

        //BFS Traversal
        public void BFSTraversal(bool getElementsbyLevel)
        {
            try
            {
                if (getElementsbyLevel)
                {
                    Console.WriteLine("Getting the Elements IN-LEVEL Order \n");
                    PrintBFS(getElementsbyLevel);

                }
                else
                {
                    Console.WriteLine("Traversing Through BFS \n");
                    PrintBFS(getElementsbyLevel);

                }
            }
            catch(Exception e)
            {
                throw e;
            }

        }
        public void DFSPreOrder(Tree p)
        {

            if (p == null)
                return;
            Console.Write("" + p.Value + " ");
            DFSPreOrder(p.Child);

            DFSPreOrder(p.Siblings);


        }
        public void DFSPostOrder(Tree p)
        {
            if (p == null)
                return;
            DFSPostOrder(p.Child);

            DFSPostOrder(p.Siblings);
            Console.Write("" + p.Value + " ");

        }
        public void DFSInOrder(Tree p)
        {
            if (p == null)
                return;
            DFSInOrder(p.Child);

            Console.Write("" + p.Value + " ");

            DFSInOrder(p.Siblings);


        }
        public void PrintBFS(bool getElementsbylevel)
        {
            try
            {
                int height = Height(ROOT);
                int Index;
                for (Index = 1; Index <= height; Index++)
                {
                    if (getElementsbylevel)
                    {
                        printCurrentLevel(ROOT, Index, getElementsbylevel);
                        Console.WriteLine("\n");
                    }
                    else
                        printCurrentLevel(ROOT, Index, getElementsbylevel);
                }
                Console.WriteLine("\n");
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public int Height(Tree p)
        {
            if (p == null)
            {
                return 0;
            }
            else
            {

                int lheight = Height(p.Child);
                int rheight = Height(p.Siblings);


                if (lheight > rheight)
                {
                    return (lheight + 1);
                }
                else
                {
                    return (rheight + 1);
                }
            }
        }
        public void printCurrentLevel(Tree p, int level, bool getElementsbylevel)
        {
            if (p == null)
            {
                return;
            }
            if (level == 1)
            {
                if (!getElementsbylevel)
                    Console.Write(" " + p.Value + " ");
                else
                    Console.Write(" " + p.Value + " ");

            }
            else if (level > 1)
            {
                printCurrentLevel(p.Child, level - 1, getElementsbylevel);
                printCurrentLevel(p.Siblings, level - 1, getElementsbylevel);
            }
        }

        //CONTAINS
        public void Contains(int SearchedItem)
        {
            try
            {
                if (IfNodeExists(ROOT, SearchedItem))
                {
                    Console.WriteLine($"We Found the Element {SearchedItem} in the Tree\n");
                }
                else
                {
                    Console.WriteLine($"we did not Found the Element {SearchedItem} in the Tree\n");
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        static bool IfNodeExists(Tree Node, int key)
        {
            if (Node == null)
                return false;

            if (Node.Value == key)
                return true;

            bool res1 = IfNodeExists(Node.Child, key);

            if (res1)
                return true;

            bool res2 = IfNodeExists(Node.Siblings, key);

            return res2;



        }
        private void ChildNode(Tree root)
        {
            while (root != null)
            {
                DFSstack.Push(root);
                root = root.Child;

            }
        }
        public void DFSTreeIterator(Tree Node)
        {

            ChildNode(Node);
        }
        public int Next()
        {
            bool IsStackNotEmpty = hasNext();
            if (IsStackNotEmpty)
            {
                Tree TopMostNode = DFSstack.Pop();
                if (TopMostNode.Siblings != null)
                {
                    ChildNode(TopMostNode.Siblings);
                }
                return TopMostNode.Value;
            }
            return -1;
            
        }

        public Boolean hasNext()
        {
            return DFSstack.Count > 0;
        }

        //Iterating though DFS
        public void IteratingThroughDFS()
        {
            try
            {
                DFSTreeIterator(ROOT);
            }
            catch(Exception e)
            {
                throw e;
            }
        }



    }
}





        



