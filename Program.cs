using System;
using System.Collections; //Added for Sorted Lists

namespace SortedListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorted List Exercise!");

            //Creating
            Console.WriteLine("In Creating");
            SortedList sortedList = new SortedList();
            Console.WriteLine("-----------");

            //Adding
            Console.WriteLine("In Adding");
            sortedList.Add(1, "Jan");
            sortedList.Add(2, "Feb");
            sortedList.Add(3, "Mar");
            sortedList.Add(4, "Apr");
            sortedList.Add(5, "May");
            Console.WriteLine("-----------");

            //Displaying //foreach
            Console.WriteLine("In Displaying foreach");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine("Item = " + item.Key + " : " + item.Value);
            }
            Console.WriteLine("-----------");

            //Displaying for
            Console.WriteLine("In Displaying for");
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine("Item = " + sortedList.GetKey(i) + " : " + sortedList.GetByIndex(i));
            }
            Console.WriteLine("-----------");

            //Index
            Console.WriteLine("In Index Access");
            Console.WriteLine("Sorted List Item #2 = " + sortedList[2]);
            Console.WriteLine("Sorted List Index for Feb = " + sortedList.IndexOfValue("Feb"));
            Console.WriteLine("-----------");

            //Capacity
            Console.WriteLine("In Capacity");
            Console.WriteLine("Current Capacity = " + sortedList.Count);
            Console.WriteLine("-----------");

            //Remove
            Console.WriteLine("In Remove");
            sortedList.Remove(2);
            Console.WriteLine("Removed Key #2");

            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine("Item = " + item.Key + " : " + item.Value);
            }
            Console.WriteLine("-----------");

            //Contains
            Console.WriteLine("In Contains");
            Console.WriteLine("Does sorted list contain value Mar = " + sortedList.ContainsValue("Mar"));
            Console.WriteLine("Does sorted list contain value Jun = " + sortedList.ContainsValue("Jun"));
            Console.WriteLine("-----------");


            //Copy To ArrayList
            Console.WriteLine("In Copy To Array List");
            ArrayList arraylist = new ArrayList(sortedList);

            foreach (DictionaryEntry item in arraylist)
            {
                Console.WriteLine("Item = " + item.Key + " : " + item.Value);
            }
            Console.WriteLine("-----------");
        }
    }
}
