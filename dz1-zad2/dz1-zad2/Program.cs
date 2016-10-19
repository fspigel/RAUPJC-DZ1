using System;

namespace dz1_zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<string> gList = new GenericList<string>();
            gList.Add("hello");
            gList.Add(" ");
            gList.Add("world");
            gList.Add(":)");
            for (int i = 0; i < gList.Count; i++) Console.WriteLine(gList.GetElement(i));
            Console.ReadLine();
        }
    }
}
