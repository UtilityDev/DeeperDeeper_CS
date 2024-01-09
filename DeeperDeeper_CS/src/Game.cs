using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace DeeperDeeper_CS
{
    /// <summary>
    /// The game class holds all game logic
    /// </summary>
    public sealed class Game
    {
        // Window properties
        const int       WIDTH   = 1280;
        const int       HEIGHT  = 720;
        const string    TITLE   = "Deeper & Deeper!";

        // List of blocks
        List<Block> blocks = new List<Block>();

        // Random object
        Random rand = new Random(DateTime.Now.Millisecond);

        // Player
        Player player = new (
            pos: new Vector2((WIDTH / 2) - 20, 80),
            radius: 20.0f,
            moveSpeed: 500.0f,
            color: Color.RED
        );

        // Restart game
        public void Restart()
        {
            player.position.X = (WIDTH / 2) - player.radius / 2;
            foreach (Block block in blocks)
            {
                block.position.Y = HEIGHT + rand.Next(0, 800);
                block.position.X = rand.Next(50, WIDTH - 50);
            }
        }

        // Run game
        public void Run()
        {
            // Setup window
            InitWindow(WIDTH, HEIGHT, TITLE);
            SetTargetFPS(60);


            // Player collision box
            Rectangle playerCol = new Rectangle(player.position.X - player.radius / 2, player.position.Y - player.radius / 2, 40, 40);

            // Spawn 22 blocks
            for (int i = 0; i < 22; i++)
            {
                blocks.Add(new Block(new Vector2(rand.Next(50, WIDTH - 50), HEIGHT + rand.Next(3, 750)), 100, 300, Color.BLUE));
            }

            // Game loop
            while (!WindowShouldClose())
            {
                BeginDrawing();
                ClearBackground(Color.BLACK);

                // Draw player and allow movement
                player.Draw();
                player.Move();

                // Player collision box
                playerCol.X = player.position.X - player.radius;
                playerCol.Y = player.position.Y - player.radius;
                DrawRectangleRec(playerCol, Color.BLANK);

                // Loop through every block in 'Blocks' List
                foreach (Block block in blocks)
                {
                    // Draw each block and make them fall
                    block.Draw();
                    block.Fall();

                    // If out of bounds, reset position back down
                    if (block.position.Y < -200)
                    {
                        block.position.Y = HEIGHT;
                        block.position.X = rand.Next(50, WIDTH - 50);
                    }

                    // Check collision between Block rect and player collision box
                    if (CheckCollisionRecs(playerCol, new Rectangle(block.position.X, block.position.Y, block.length, 20)))
                    {
                        Restart();
                    }
                }

                // End loop
                EndDrawing();
            }

            // De-initialize window
            CloseWindow();
        }
    }
}
