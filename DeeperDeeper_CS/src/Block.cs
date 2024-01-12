using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace DeeperDeeper_CS
{
    /// <summary>
    /// Handles everything related to blocks, except block spawning
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

        /// <summary>
        /// Make block fall upwards
        /// </summary>
        public void Fall()
        {
            this.position.Y -= this.speed * GetFrameTime();
        }

        /// <summary>
        /// Get random block color
        /// </summary>
        /// <returns>Random block color</returns>
        public Color GetRandomColor()
        {
            return (Color)blockColors[rand.Next(0, blockColors.Length)];
        }

        /// <summary>
        /// Overwritten 'Draw()' function, draws a long block
        /// </summary>
        public override void Draw()
        {
            DrawRectangle((int)this.position.X, (int)this.position.Y, this.length, 20, this.color);
        }
    }
}
