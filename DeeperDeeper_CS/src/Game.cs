using Raylib_cs;
using static Raylib_cs.Raylib;

namespace DeeperDeeper_CS
{
    public sealed class Game
    {
        const int       WIDTH   = 1280;
        const int       HEIGHT  = 720;
        const string    TITLE   = "Deeper & Deeper!";

        public void Run()
        {
            InitWindow(WIDTH, HEIGHT, TITLE);
            while (!WindowShouldClose())
            {
                BeginDrawing();

                EndDrawing();
            }

            CloseWindow();
        }
    }
}
