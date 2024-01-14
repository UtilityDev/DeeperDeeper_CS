using System;
using System.IO;

namespace DeeperDeeper_CS
{
    /// <summary>
    /// Handles storing and fetching of contents from highscore.txt in LOCALAPPDATA
    /// </summary>
    public static class HighScore
    {
        private static string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        
        private static string newFolder = Path.Combine(docFolder, "DeeperDeeper");
        private static string file = "highscore.txt";

        /// <summary>
        /// Initialize save folder and highscore.txt
        /// </summary>
        public static void Init()
        {
            Directory.CreateDirectory(newFolder);
            if (!File.Exists(Path.Combine(newFolder, file)))
            {
                File.Create(Path.Combine(newFolder, file));
            }
        }

        /// <summary>
        /// Overwrite High Score in highscore.txt
        /// </summary>
        /// <param name="score">The score to be overwritten</param>
        public static void OverwriteHighScore(int score)
        {
            try
            {
                File.WriteAllText(Path.Combine(newFolder, file), score.ToString());
            } catch { };
        }

        /// <summary>
        /// Get High Score from highscore.txt
        /// </summary>
        /// <returns>High Score stored in highscore.txt</returns>
        public static int GetHighScore()
        {
            try
            {
                return Convert.ToInt32(File.ReadAllText(Path.Combine(newFolder, file)));
            } catch { return 0; };
        }
    }
}
