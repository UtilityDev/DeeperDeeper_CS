using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace DeeperDeeper_CS
{
    class Player : Entity
    {
        public float radius = 40.0f;
        public float moveSpeed = 0.07f;

        public Player(Vector2 pos, float radius, Color color)
        {
            this.position = pos;
            this.radius = radius;
            this.color = color;
        }

        public void Move()
        {
            if (IsKeyDown(KeyboardKey.KEY_A)) { this.position.X -= this.moveSpeed; }
            if (IsKeyDown(KeyboardKey.KEY_D)) { this.position.X += this.moveSpeed; }
        }

        public override void Draw()
        {
            DrawCircle((int)this.position.X, (int)this.position.Y, this.radius, this.color);
        }
    }
}
