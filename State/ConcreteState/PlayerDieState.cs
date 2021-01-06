using System;
using Context;
using State;

namespace ConcreteState
{
    public class PlayerDieState : PlayerState
    {
        public void Render()
        {
            Console.WriteLine("Render Die State");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Player Die, game over");
        }
    }
}