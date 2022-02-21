using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Data_Structures.HashTable
{
    public class HashTable1
    {
        static void Main(string[] args)
        {
            Hashtable My_HashTable = new Hashtable();

            //INSERT
            My_HashTable.Add("1", "Vikas");
            My_HashTable.Add("2", "Sharma");
            My_HashTable.Add("3", "is");
            My_HashTable.Add("4", "a");
            My_HashTable.Add("5", ".dot");
            My_HashTable.Add("6", "net");
            My_HashTable.Add("7", "trainee");
            My_HashTable.Add("8", "in");
            My_HashTable.Add("9", "Nagarro");
            //My_HashTable.Add("9", "Nagarro");


            //TRAVERSE
            Console.WriteLine("The Key Vlaue Pairs that the hashtable consists of are:- ");
            foreach (DictionaryEntry KeyValues in My_HashTable)
            {
                Console.WriteLine("{0} and {1} ", KeyValues.Key, KeyValues.Value);
            }
            Console.WriteLine("\n");

            //DELETE
            My_HashTable.Remove("7");
            My_HashTable.Remove("4");
            My_HashTable.Remove("9");


            //TRAVERSE
            Console.WriteLine("The Key Vlaue Pairs that the hashtable consists of are:- ");
            foreach (DictionaryEntry KeyValues in My_HashTable)
            {
                Console.WriteLine("{0} and {1} ", KeyValues.Key, KeyValues.Value);
            }
            Console.WriteLine("\n");

            //CONTAINS
            Console.WriteLine(My_HashTable.Contains("8"));
            Console.WriteLine(My_HashTable.Contains("3"));

            Console.WriteLine("\n");

            string HashTableContents1 = (string)My_HashTable["8"];
            string HashTableContents2 = (string)My_HashTable["3"];
            string HashTableContents3 = (string)My_HashTable["2"];
            Console.WriteLine("By getting Elelments value by key we get");
            Console.WriteLine($"{ HashTableContents1}, { HashTableContents2}, { HashTableContents3}");
            Console.WriteLine("\n");

            //SIZE
            Console.WriteLine("The Size of The HashTable is {0}", My_HashTable.Count);
            Console.WriteLine("\n");


            //ITERATOR
            IDictionaryEnumerator IteratorEnum = My_HashTable.GetEnumerator();
            while (IteratorEnum.MoveNext())
                Console.WriteLine("Key = " + IteratorEnum.Key + ", Value = " + IteratorEnum.Value);





        }
    }

    
}
