using System;

namespace dz1_zad3
{
    //testing VS2015 git integration
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<string> gList = new GenericList<string>();
            gList.Add("hello");
            gList.Add("world");
            gList.Add(":)");
            Console.WriteLine("with a for-loop:");
            for (int i = 0; i < gList.Count; i++) Console.WriteLine(gList.GetElement(i));

            Console.WriteLine("\nWith a foreach loop:");
            foreach (string word in gList) Console.WriteLine(word);
            Console.ReadLine();
        }
    }
}
