using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace DeeperDeeper_CS
{
    /// <summary>
    /// The block class handles everything related to blocks, except block spawning
    /// </summary>
    public class Block : Entity
    {
        // Block-specific properties
        public int length;
        public float speed;
        public Color[] blockColors =
        {
            Color.BLUE,
            Color.RED,
            Color.GREEN,
            Color.ORANGE,
            Color.MAGENTA,
            Color.LIME
        };


        // Random object
        Random rand = new Random();


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

        // Get random Block Color
        public Color GetRandomColor()
        {
            return (Color)blockColors[rand.Next(0, blockColors.Length)];
        }

        // Overwritten 'Draw()' method, draws a long block
        public override void Draw()
        {
            DrawRectangle((int)this.position.X, (int)this.position.Y, this.length, 20, this.color);
        }
    }
}
