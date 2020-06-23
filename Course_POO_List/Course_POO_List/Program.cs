using System;
using System.Collections.Generic;

namespace Course_POO_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            //List<string> list2 = new List<string> { "Maria", "Alex" };

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');//esse predicado é uma forma resumida da função Test, é uma expressão lambda/função anonima
            Console.WriteLine("First 'A': " + s1 );

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-----------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            /*list.RemoveAt(3);
            Console.WriteLine("-----------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }*/

            list.RemoveRange(2, 2);
            Console.WriteLine("-----------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-----------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            /*list.Remove("Alex");
            Console.WriteLine("-----------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }*/

        }

        /*static bool Test(string s)
        {
            return s[0] == 'A';
        }*/
    }
}
