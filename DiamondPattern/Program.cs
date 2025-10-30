using System;
class Diamond
{
    public static void Main()
    {
        int n = 5;

        //upper part
        for(int i = 0; i < n; i++)
        {
           for(int space = i; space < n - 1; space++)
            {
                Console.Write(" ");
            }
           for(int star = 0; star < (2 * i) + 1; star++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        //lower part
        for(int i = n - 2; i >= 0; i--)
        {
            for (int space = n - 1; space > i; space--)
            {
                Console.Write(" ");
            }
            for (int star = 0; star < (2 * i) + 1; star++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

        }
    }
}
