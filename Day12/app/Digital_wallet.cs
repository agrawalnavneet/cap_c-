using System;

namespace DigitalWalletApp
{
    class Main1
    {
        public static void Show(string[] args)
        {
            Console.WriteLine("Digital Wallet Application");
            Console.WriteLine("Number of arguments: " + args.Length);

            if (args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine("args[" + i + "] = " + args[i]);
                }
            }
            else
            {
                Console.WriteLine("No arguments passed");
            }
        }
    }
}
