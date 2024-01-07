﻿using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace DeeperDeeper_CS.Interfaces
{
    public interface IEntity
    {
        public Vector2 Position { get; set; }

        public void Draw();
    }
}
