using System;

namespace CST150W5A10
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            //make some sets
            Set A = new();
            Set B = new();

            //put some stuff in the sets
            Random r = new();
            for (int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A union B: " + A.union(B));

            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);


        }
    }
}
