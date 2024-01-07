﻿using System.Numerics;
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
            SetTargetFPS(60);

            // Player
            Player player = new (
                pos: new Vector2((WIDTH / 2) - 20, 80),
                radius: 20.0f,
                moveSpeed: 500.0f,
                color: Color.RED
            );

            while (!WindowShouldClose())
            {
                BeginDrawing();
                ClearBackground(Color.BLACK);

                DrawText("FPS: " + GetFPS().ToString(), 20, 20, 48, Color.WHITE);

                player.Draw();
                player.Move();
                
                EndDrawing();
            }

            CloseWindow();
        }
    }
}
