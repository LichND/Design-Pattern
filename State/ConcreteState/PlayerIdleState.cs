using System;
using Context;
using State;

namespace ConcreteState
{
    public class PlayerIdleState : PlayerState
    {
        public void Render()
        {
            Console.WriteLine("Render Idle State");
        }

        public void Update(Player player)
        {
            if (player.HP <= 0)
            {
                player.ReplaceState(new PlayerDieState());
                return;
            }
            if (player.MoveSpeed != 0)
            {
                player.ReplaceState(new PlayerRunState());
                return;
            }
        }
    }
}