using System;
using System.Threading;

namespace HackerTyper_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.InputEncoding = Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.CursorVisible = true;

            Random random = new Random(DateTime.UtcNow.Year +
                                       DateTime.UtcNow.Month +
                                       DateTime.UtcNow.Day +
                                       DateTime.UtcNow.Hour +
                                       DateTime.UtcNow.Minute +
                                       DateTime.UtcNow.Second +
                                       DateTime.UtcNow.Millisecond);
            int i = 0;
            int strokeLength;
            int height, width;
            var keyPress = Console.ReadKey(true);

            const int MIN_LENGTH = 2, MAX_LENGTH = 7, MIN_SLEEP = 5, MAX_SLEEP = 10;

            Console.BufferHeight = height = Console.WindowHeight;
            Console.BufferWidth = width = Console.WindowWidth;

            while (true)
            {
                Console.WindowHeight = height;
                Console.WindowWidth = width;
                strokeLength = random.Next(MIN_LENGTH, MAX_LENGTH); // 2 to 6. 7 is the non-inclusive upper boundary.

                switch (keyPress.Key)
                {
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    #region case All keys that count as keystroke
                    case ConsoleKey.Tab:
                    case ConsoleKey.Enter:
                    case ConsoleKey.Spacebar:
                    case ConsoleKey.D0:
                    case ConsoleKey.D1:
                    case ConsoleKey.D2:
                    case ConsoleKey.D3:
                    case ConsoleKey.D4:
                    case ConsoleKey.D5:
                    case ConsoleKey.D6:
                    case ConsoleKey.D7:
                    case ConsoleKey.D8:
                    case ConsoleKey.D9:
                    case ConsoleKey.A:
                    case ConsoleKey.B:
                    case ConsoleKey.C:
                    case ConsoleKey.D:
                    case ConsoleKey.E:
                    case ConsoleKey.F:
                    case ConsoleKey.G:
                    case ConsoleKey.H:
                    case ConsoleKey.I:
                    case ConsoleKey.J:
                    case ConsoleKey.K:
                    case ConsoleKey.L:
                    case ConsoleKey.M:
                    case ConsoleKey.N:
                    case ConsoleKey.O:
                    case ConsoleKey.P:
                    case ConsoleKey.Q:
                    case ConsoleKey.R:
                    case ConsoleKey.S:
                    case ConsoleKey.T:
                    case ConsoleKey.U:
                    case ConsoleKey.V:
                    case ConsoleKey.W:
                    case ConsoleKey.X:
                    case ConsoleKey.Y:
                    case ConsoleKey.Z:
                    case ConsoleKey.NumPad0:
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.NumPad5:
                    case ConsoleKey.NumPad6:
                    case ConsoleKey.NumPad7:
                    case ConsoleKey.NumPad8:
                    case ConsoleKey.NumPad9:
                    case ConsoleKey.Multiply:
                    case ConsoleKey.Add:
                    case ConsoleKey.Separator:
                    case ConsoleKey.Subtract:
                    case ConsoleKey.Decimal:
                    case ConsoleKey.Divide:
                    case ConsoleKey.Oem1:
                    case ConsoleKey.OemPlus:
                    case ConsoleKey.OemComma:
                    case ConsoleKey.OemMinus:
                    case ConsoleKey.OemPeriod:
                    case ConsoleKey.Oem2:
                    case ConsoleKey.Oem3:
                    case ConsoleKey.Oem4:
                    case ConsoleKey.Oem5:
                    case ConsoleKey.Oem6:
                    case ConsoleKey.Oem7:
                    case ConsoleKey.Oem8:
                    case ConsoleKey.Oem102:
                        #endregion
                        break;
                    default: // Key that does not count as keystroke
                        continue;
                }

                for (int c = 0; c < strokeLength; c++)
                {
                    Console.Write(Resources.groups[i]);
                    Thread.Sleep(random.Next(MIN_SLEEP, MAX_SLEEP)); // Just to make it look more like actual typing
                    i = i < Resources.groups.Length - 1 ? i + 1 : 0;
                    if (i == 0) Console.Write("\n\n");
                }
                keyPress = Console.ReadKey(true);
            }
        }
    }
}
