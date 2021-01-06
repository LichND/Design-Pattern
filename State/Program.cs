using System;
using Context;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.CircleLoop();
            player.CircleLoop(10, 10);
            player.CircleLoop(10, 0);
            player.CircleLoop(0, 10);
            player.CircleLoop();
        }
    }
}
