using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace DeeperDeeper_CS
{
    public interface IEntity
    {
        public Vector3 Position { get; set; }
        public void Draw();
    }
}
