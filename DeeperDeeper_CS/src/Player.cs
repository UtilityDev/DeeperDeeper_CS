using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace DeeperDeeper_CS
{
    class Player : Entity
    {
        public float radius = 40.0f;
        public float moveSpeed;

        public Player(Vector2 pos, float radius, float moveSpeed, Color color)
        {
            this.position = pos;
            this.radius = radius;
            this.moveSpeed = moveSpeed;
            this.color = color;
        }

        public void Move()
        {
            if (IsKeyDown(KeyboardKey.KEY_A)) { this.position.X -= this.moveSpeed * GetFrameTime(); }
            if (IsKeyDown(KeyboardKey.KEY_D)) { this.position.X += this.moveSpeed * GetFrameTime(); }
        }

        public override void Draw()
        {
            DrawCircle((int)this.position.X, (int)this.position.Y, this.radius, this.color);
        }
    }
}
