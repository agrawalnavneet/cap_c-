using System;
class Game
{
    public static void Gaming()
    {
        for(int i = 0; i <= 10; i++)
        {
            if (i == 4)
            {
                Console.WriteLine("E4 is skiped");
                continue;
            }
Console.WriteLine($"Player Killed E {i}");
        }
Console.WriteLine("Game End");
    }
}