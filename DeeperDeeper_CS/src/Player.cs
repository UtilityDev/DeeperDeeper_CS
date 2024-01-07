using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;
using DeeperDeeper_CS.Interfaces;

namespace DeeperDeeper_CS
{
    class Player : IEntity
    {
        public Vector2 Position { get; set; }
        public Color color;

        public float radius = 40.0f;

        public Player(Vector2 pos, float radius, Color color)
        {
            this.Position = pos;
            this.radius = radius;
            this.color = color;
        }

        public void Draw()
        {
            DrawCircle((int)this.Position.X, (int)this.Position.Y, this.radius, this.color);
        }
    }
}
