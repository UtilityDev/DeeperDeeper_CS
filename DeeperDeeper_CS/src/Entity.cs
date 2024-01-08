using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace DeeperDeeper_CS
{
    public class Entity
    {
        // Entity-specific properties
        public Vector2 position = new Vector2();
        public Color color;

        // Draw basic shape, can be overwritten
        public virtual void Draw()
        {
            DrawRectangle((int)position.X, (int)position.Y, 20, 20, Color.WHITE);
        }
    }
}
