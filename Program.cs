using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.Distinct
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Distinct(); -> getting unique elements from collection ! //gets every unique element !
            // we take every unique, element and put it in a new collection ! //

            string[] array = new string[] {"John", "Mary", "George", "Ivan", "Dragon", "John", "Mary", "George"};
            Console.WriteLine("Old: {0} ", string.Join(" ", array));
           // array.Distinct();
            Console.WriteLine();
            Console.WriteLine("this prints only the unique numbers of the array: {0}", string.Join(" ", array.Distinct()));
            // Every duplicate will be omitted, it will be printed only one time
            // if there are duplivcate elementes, it will take onluy one copy of the element  not all duplicates !
            // example, if we have  5 times  "a" , it will take only one "a" ;

            int[] numbers = new int[] {1, 2, 2, 3 , 4 , 5 , 6 , -2, 2 , 0 , 15, 3 , 1 , 0, 6 };
            Console.WriteLine(string.Join(" ", numbers.Distinct()));
            // distinct() ->  if many elements in  a collection are duplicateing each other, the disctinct() takes only one copy of them !

        }
    }
}
