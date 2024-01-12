using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace DeeperDeeper_CS
{
    /// <summary>
    /// Handles everything related to the player; movement, drawing, and player-specific properties
    /// </summary>
    class Player : Entity
    {
        // Player-specific properties
        public float radius = 40.0f;
        public float moveSpeed;

        // Constructor, initialize values
        public Player(Vector2 pos, float radius, float moveSpeed, Color color)
        {
            this.position = pos;
            this.radius = radius;
            this.moveSpeed = moveSpeed;
            this.color = color;
        }

        /// <summary>
        /// Player movement
        /// </summary>
        public void Move()
        {
            if (IsKeyDown(KeyboardKey.KEY_A)) { this.position.X -= this.moveSpeed * GetFrameTime(); }
            if (IsKeyDown(KeyboardKey.KEY_D)) { this.position.X += this.moveSpeed * GetFrameTime(); }
        }

        /// <summary>
        /// Overwritten 'Draw()' class, draws a circle
        /// </summary>
        public override void Draw()
        {
            DrawCircle((int)this.position.X, (int)this.position.Y, this.radius, this.color);
        }
    }
}
