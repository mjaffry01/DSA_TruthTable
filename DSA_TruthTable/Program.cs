using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Truth Table for Bitwise Operators\n");
        Console.WriteLine(" A | B | A & B (AND) | A | B (OR) | A ^ B (XOR) | ~A (NOT A) | ~B (NOT B)");
        Console.WriteLine("---------------------------------------------------------------");

        // Define input values (0 and 1)
        int[] inputs = { 0, 1 };

        // Generate truth table
        foreach (int a in inputs)
        {
            foreach (int b in inputs)
            {
                int andResult = a & b;  // AND operation
                int orResult = a | b;   // OR operation
                int xorResult = a ^ b;  // XOR operation
                int notAResult = ~a & 1; // NOT operation for A (limited to 1 bit)
                int notBResult = ~b & 1; // NOT operation for B (limited to 1 bit)

                // Print results
                Console.WriteLine($" {a} | {b} |      {andResult}       |      {orResult}      |      {xorResult}      |      {notAResult}      |      {notBResult}");
            }
        }

        Console.ReadLine();
    }
}
