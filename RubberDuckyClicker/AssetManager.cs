using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;

namespace RubberDuckyClicker
{
    public static class AssetManager
    {
        /* SpriteFonts */
        public static SpriteFont TheFont;
        public static SpriteFont Score;
        public static SpriteFont StatsFont;
        public static SpriteFont AchieveFont;

        /* Texture2Ds */
        public static Texture2D DuckyLarge;
        public static Texture2D StatIcon;
        public static Texture2D AwardIcon;

        /*AchievementIcons*/
        public static Texture2D Achieve00;
        public static Texture2D Achieve01;
        public static Texture2D Achieve02;
        public static Texture2D Achieve03;
        public static Texture2D Achieve04;

        /* Sounds */
        public static SoundEffect Quack_1;
        public static SoundEffect Click_1;
        public static SoundEffect Click_2;
        public static SoundEffect AchieveUnlock;

        internal static void LoadAssets()
        {
            LoadSpriteFonts();
            LoadTexture2Ds();
            LoadSounds();
        }

        #region Quick-call methods

        /// <summary>
        /// Loads a <see cref="SpriteFont"/> from the <c>Content</c> folder.
        /// </summary>
        public static SpriteFont LoadSpriteFont(string assetPath, bool autoPath = true)
        {
            if (autoPath)
                assetPath = "" + assetPath;

            return Load<SpriteFont>(assetPath);
        }

        /// <summary>
        /// Loads a <see cref="Texture2D"/> from the <c>Content</c> folder.
        /// </summary>
        public static Texture2D LoadTexture2D(string assetPath, bool autoPath = true)
        {
            if (autoPath)
                assetPath = "" + assetPath;

            return Load<Texture2D>(assetPath);
        }

        /// <summary>
        /// Loads a <see cref="SoundEffect"/> from the <c>Content</c> folder.
        /// </summary>

        public static SoundEffect LoadSounds(string assetPath, bool autoPath = true)
        {
            if (autoPath)
                assetPath = "" + assetPath;

            return Load<SoundEffect>(assetPath);
        }

        /// <summary>
        /// Shorthand for <see cref="Microsoft.Xna.Framework.Content.ContentManager.Load{T}(string)"/>.
        /// </summary>
        public static T Load<T>(string assetPath) => Game1.Instance.Content.Load<T>(assetPath);

        #endregion Quick-call methods

        #region Texture initialization methods

        private static void LoadSpriteFonts()
        {
            TheFont = LoadSpriteFont("TheFont");
            Score = LoadSpriteFont("Score");
            StatsFont = LoadSpriteFont("StatFont");
            AchieveFont = LoadSpriteFont("Achievements");
        }

        private static void LoadTexture2Ds()
        {
            DuckyLarge = LoadTexture2D("basic-ducky");
            StatIcon = LoadTexture2D("StatsIcon");
            AwardIcon = LoadTexture2D("AchieveIcons/Awards");

            Achieve00 = LoadTexture2D("AchieveIcons/(00)locked");
            Achieve01 = LoadTexture2D("AchieveIcons/(03)familiar");
            Achieve02 = LoadTexture2D("AchieveIcons/(01)1quack");
            Achieve03 = LoadTexture2D("AchieveIcons/(02)quack");
            Achieve04 = LoadTexture2D("AchieveIcons/(04)2quack");
        }

        private static void LoadSounds()
        {
            Quack_1 = LoadSounds("quack");
            Click_1 = LoadSounds("SFX/Click_1");
            Click_2 = LoadSounds("SFX/Click_2");
            AchieveUnlock = LoadSounds("SFX/AchieveUnlocked");
        }

        #endregion Texture initialization methods
    }
}
