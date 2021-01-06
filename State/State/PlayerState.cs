using Context;

namespace State
{
    public interface PlayerState
    {
        void Update(Player player);
        void Render();
    }
}