using System;
using ConcreteState;
using State;

namespace Context
{
    public class Player
    {
        private int hp;
        private int moveSpeed;
        private PlayerState state;
        public int HP { get => hp; }
        public int MoveSpeed { get => moveSpeed; }
        public PlayerState State { get => state; }

        public Player(int hp = 100, int moveSpeed = 100)
        {
            this.hp = hp;
            this.moveSpeed = moveSpeed;
            this.state = new PlayerIdleState();
        }

        public void ReplaceState(PlayerState state)
        {
            this.state = state;
        }

        public void PlayerUpdate(int newHP, int newMoveSpeed)
        {
            this.hp = newHP;
            this.moveSpeed = newMoveSpeed;
            this.State.Update(this);
        }

        public void PlayerRender()
        {
            Console.Write($"HP: {HP}, Move Speed: {MoveSpeed}; ");
            this.State.Render();
        }

        public void CircleLoop(int? newHP = null, int? newMoveSpeed = null)
        {
            if (newHP is null)
            {
                newHP = this.HP;
            }
            if (newMoveSpeed is null)
            {
                newMoveSpeed = this.MoveSpeed;
            }
            this.PlayerUpdate(newHP.Value, newMoveSpeed.Value);
            this.PlayerRender();
        }
    }
}