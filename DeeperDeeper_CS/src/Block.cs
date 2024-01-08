using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace DeeperDeeper_CS
{
    public class Block : Entity
    {
        // Block-specific properties
        public int length;
        public float speed;

        // Constructor, initalize values
        public Block(Vector2 pos, int length, float speed, Color color)
        {
            this.position   = pos;
            this.length     = length;
            this.speed      = speed;
            this.color      = color;
        }

        // Make block fall upwards
        public void Fall()
        {
            this.position.Y -= this.speed * GetFrameTime();
        }

        // Overwritten 'Draw()' method, draws a long block
        public override void Draw()
        {
            DrawRectangle((int)this.position.X, (int)this.position.Y, this.length, 20, this.color);
        }
    }
}
