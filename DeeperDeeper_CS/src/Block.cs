using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace DeeperDeeper_CS
{
    public class Block : Entity
    {
        public int length;
        public float speed;

        public Block(Vector2 pos, int length, float speed, Color color)
        {
            this.position   = pos;
            this.length     = length;
            this.speed      = speed;
            this.color      = color;
        }

        public void Fall()
        {
            this.position.Y -= this.speed * GetFrameTime();
        }

        public override void Draw()
        {
            DrawRectangle((int)this.position.X, (int)this.position.Y, this.length, 20, this.color);
        }
    }
}
