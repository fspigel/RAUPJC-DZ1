using System;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerList listOfIntegers = new IntegerList();
            listOfIntegers.Add(1);          // [1]
            listOfIntegers.Add(2);          // [1 ,2]
            listOfIntegers.Add(3);          // [1 ,2 ,3]
            listOfIntegers.Add(4);          // [1 ,2 ,3 ,4]
            listOfIntegers.Add(5);          // [1 ,2 ,3 ,4 ,5]
            listOfIntegers.RemoveAt(0);     // [2 ,3 ,4 ,5]
            listOfIntegers.Remove(5);       // [2 ,3 ,4]
            Console.WriteLine ( listOfIntegers.Count ) ;            // 3
            Console.WriteLine ( listOfIntegers.Remove(100) ) ;      // false
            Console.WriteLine ( listOfIntegers.RemoveAt(5) ) ;      // false
                                                                    // why would this be false? RemoveAt does not reduce array length dynamically. 
                                                                    // _internalStorage was increased to length 8 in line 18, so RemoveAt(5) should return true.
            listOfIntegers.Clear () ;                               // []
            Console.WriteLine ( listOfIntegers.Count ) ;            // 0
            Console.ReadLine();
        }
    }
}
