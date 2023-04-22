using System;
using System.Collections;


namespace oops_concepts{
    public class Program{
        public static void Main(string[] args)
        {
            myfirstclass name = new myfirstclass();
            int value = name.add(10,30);
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}
