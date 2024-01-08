using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace DeeperDeeper_CS
{
    public sealed class Game
    {
        const int       WIDTH   = 1280;
        const int       HEIGHT  = 720;
        const string    TITLE   = "Deeper & Deeper!";

        List<Block> blocks = new List<Block>();

        Random rand = new Random(DateTime.Now.Millisecond);

        public void Run()
        {
            InitWindow(WIDTH, HEIGHT, TITLE);
            SetTargetFPS(60);

            // Player
            Player player = new (
                pos: new Vector2((WIDTH / 2) - 20, 80),
                radius: 20.0f,
                moveSpeed: 500.0f,
                color: Color.RED
            );

            for (int i = 0; i < 22; i++)
            {
                blocks.Add(new Block(new Vector2(rand.Next(50, WIDTH - 50), HEIGHT + rand.Next(3, 750)), 100, 300, Color.BLUE));
            }

            while (!WindowShouldClose())
            {
                BeginDrawing();
                ClearBackground(Color.BLACK);

                player.Draw();
                player.Move();

                foreach (Block block in blocks)
                {
                    block.Draw();
                    block.Fall();

                    if (block.position.Y < -200)
                        block.position.Y = HEIGHT;
                }

                EndDrawing();
            }

            CloseWindow();
        }
    }
}
