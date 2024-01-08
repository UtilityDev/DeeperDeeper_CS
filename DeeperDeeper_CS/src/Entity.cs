using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace DeeperDeeper_CS
{
    /// <summary>
    /// Base entity class. All objects that need to be drawn, needs a position, color, and possibly requires movement should inherit from this class.
    /// </summary>
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
