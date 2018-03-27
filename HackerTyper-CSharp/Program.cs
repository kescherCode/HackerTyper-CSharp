using System;

namespace HackerTyper_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int strokeLength = 4; // advance 4 chars on every keypress
            while (true)
            {
                Console.ReadKey(true);
                for (int c = 0; c < strokeLength; c++)
                {
                    Console.Write(Resources.groups[c]);
                    i = i < Resources.groups.MaxIndex() ? i + 1 : 0;
                }
            }
        }
    }
}
