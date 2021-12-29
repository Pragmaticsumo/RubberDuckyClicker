using System;
using System.Collections.Generic;
using System.Text;
using RubberDuckyClicker.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

namespace RubberDuckyClicker
{
    public static class Main
    {
        /*GameStuff*/
        public static readonly Version DuckyVersion = new Version(0, 2, 1);
        public static readonly string VersionText = $"RubberDuckyClicker v{DuckyVersion}";
        public static RubberDucky LargeDucky = new RubberDucky();
        public static Cursor Cursor = new Cursor();
        public static StatIcon StatIcon = new StatIcon();
        public static AwardsIcon AwardIcon = new AwardsIcon();
        public static Achievement Achievements = new Achievement();
        public static SkinsIcon SkinIcon = new SkinsIcon();
        public static Skins Skin = new Skins();
        public static Vector2 WindowMeasurements = Vector2.Zero;
        public static int Score;
        public static int maxScore;
        public static int achievementNumber;

        /*States*/
        public static MouseState DuckyMouse = Mouse.GetState();
        public static MouseState PrevDuckyMouse = DuckyMouse;
        public static KeyboardState DuckyKeyboard = Keyboard.GetState();
        public static KeyboardState PrevDuckyKeyboard = DuckyKeyboard;

        /*Sounds*/
        public static SoundEffect click1 = AssetManager.Click_1;
        public static SoundEffect click2 = AssetManager.Click_2;
        public static SoundEffect achieveUnlock = AssetManager.AchieveUnlock;

        public static void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            GraphicsDeviceManager graphicsDeviceManager = Game1.Instance.DuckyGraphicsDeviceManager;
            GraphicsDevice graphicsDevice = graphicsDeviceManager.GraphicsDevice;

            // Get window measurements
            WindowMeasurements = graphicsDeviceManager.IsFullScreen ? new Vector2(graphicsDevice.DisplayMode.Width, graphicsDevice.DisplayMode.Height) : new Vector2(graphicsDevice.Viewport.Width, graphicsDevice.Viewport.Height);

            // Draw any text that needs to be drawn
            DrawText(spriteBatch, graphicsDeviceManager, graphicsDevice);

            if (Game1.gameState == Game1.GameStates.Playing)
            {
                graphicsDevice.Clear(Color.Black);

                LargeDucky.Draw(gameTime, spriteBatch);
                Cursor.Draw(gameTime, spriteBatch);
                StatIcon.Draw(gameTime, spriteBatch);
                SkinIcon.Draw(gameTime, spriteBatch);
                AwardIcon.Draw(gameTime, spriteBatch);
            }
            else if (Game1.gameState == Game1.GameStates.Stats)
            {
                graphicsDevice.Clear(Color.Black);
            }
            else if (Game1.gameState == Game1.GameStates.Award)
            {
                graphicsDevice.Clear(Color.Black);

                Achievements.Draw01(gameTime, spriteBatch);
                Achievements.Draw02(gameTime, spriteBatch);
                Achievements.Draw03(gameTime, spriteBatch);
                Achievements.Draw04(gameTime, spriteBatch);
            }
            else if (Game1.gameState == Game1.GameStates.Skins)
            {
                graphicsDevice.Clear(Color.Black);

                Skin.Draw01(gameTime, spriteBatch);
                Skin.Draw02(gameTime, spriteBatch);
                Skin.Draw03(gameTime, spriteBatch);
                Skin.Draw04(gameTime, spriteBatch);
                Skin.Draw05(gameTime, spriteBatch);
                Skin.Draw06(gameTime, spriteBatch);
                Skin.Draw07(gameTime, spriteBatch);
            }
        }

        public static void Update(GameTime gameTime)
        {
            PrevDuckyMouse = DuckyMouse;
            DuckyMouse = Mouse.GetState();

            PrevDuckyKeyboard = DuckyKeyboard;
            DuckyKeyboard = Keyboard.GetState();

            if (Game1.gameState == Game1.GameStates.Playing)
            {
                LargeDucky.Update(gameTime);
                StatIcon.Update(gameTime);
                Cursor.Update(gameTime);
                SkinIcon.Update(gameTime);
                AwardIcon.Update(gameTime);

                Achievements.Update02(gameTime);
                Achievements.Update03(gameTime);
                Achievements.Update04(gameTime);
            }
            else if (Game1.gameState == Game1.GameStates.Stats)
            {
                if (DuckyKeyboard.IsKeyDown(Keys.Escape) && PrevDuckyKeyboard.IsKeyUp(Keys.Escape))
                {
                    click2.Play();
                    Game1.gameState = Game1.GameStates.Playing;
                }
                Cursor.Update(gameTime);
            }
            else if (Game1.gameState == Game1.GameStates.Award)
            {
                Cursor.Update(gameTime);
                Achievements.Update01(gameTime);

                if (DuckyKeyboard.IsKeyDown(Keys.Escape) && PrevDuckyKeyboard.IsKeyUp(Keys.Escape))
                {
                    click2.Play();
                    Game1.gameState = Game1.GameStates.Playing;
                }
            }
            else if (Game1.gameState == Game1.GameStates.Skins)
            {
                Cursor.Update(gameTime);
                Skin.Update01(gameTime);
                Skin.Update02(gameTime);
                Skin.Update03(gameTime);
                Skin.Update04(gameTime);
                Skin.Update05(gameTime);
                Skin.Update06(gameTime);
                Skin.Update07(gameTime);
                if (DuckyKeyboard.IsKeyDown(Keys.Escape) && PrevDuckyKeyboard.IsKeyUp(Keys.Escape))
                {
                    click2.Play();
                    Game1.gameState = Game1.GameStates.Playing;
                }
            }
        }

            public static void DrawText(SpriteBatch spriteBatch, GraphicsDeviceManager graphicsDeviceManager, GraphicsDevice graphicsDevice)
            {
            if (Game1.gameState == Game1.GameStates.Playing)
            {
                Vector2 versionTextSize = AssetManager.TheFont.MeasureString(VersionText);
                Vector2 versionPosFullscreen = new Vector2(0, WindowMeasurements.Y - versionTextSize.Y);
                Vector2 versionPosWindowed = new Vector2(0, graphicsDevice.Viewport.Height - versionTextSize.Y);

                Vector2 scoreSize = AssetManager.TheFont.MeasureString("Quacks" + Convert.ToString(Score));

                Vector2 scorePosWindowed = new Vector2(RubberDucky.ScreenMiddle.X - scoreSize.X, 40);

                spriteBatch.DrawString(AssetManager.TheFont, VersionText, graphicsDeviceManager.IsFullScreen ? versionPosFullscreen : versionPosWindowed, Color.White);

                spriteBatch.DrawString(AssetManager.Score, "Quacks: " + Convert.ToString(Score), scorePosWindowed, Color.White);
            }
            else if (Game1.gameState == Game1.GameStates.Stats)
            {
                Vector2 escapeTextSize = AssetManager.StatsFont.MeasureString("Press 'esc' to leave...");

                spriteBatch.DrawString(AssetManager.StatsFont, "Total Number Of Quacks: " + Convert.ToString(maxScore), Vector2.Zero, Color.LimeGreen);
                spriteBatch.DrawString(AssetManager.StatsFont, "Total Number Of Achievements: " + Convert.ToString(achievementNumber)  + "/4", new Vector2(0, 50), Color.LimeGreen);
                spriteBatch.DrawString(AssetManager.AchieveFont, "Press 'esc' to leave...", new Vector2(650, graphicsDevice.Viewport.Height - escapeTextSize.Y), Color.LimeGreen);
            }
            else if (Game1.gameState == Game1.GameStates.Award)
            {
                Vector2 escapeTextSize = AssetManager.StatsFont.MeasureString("Press 'esc' to leave...");
                spriteBatch.DrawString(AssetManager.AchieveFont, "Press 'esc' to leave...", new Vector2(650, graphicsDevice.Viewport.Height - escapeTextSize.Y), Color.LimeGreen);
            }
            else if (Game1.gameState == Game1.GameStates.Skins)
            {
                Vector2 escapeTextSize = AssetManager.StatsFont.MeasureString("Press 'esc' to leave...");
                spriteBatch.DrawString(AssetManager.AchieveFont, "Press 'esc' to leave...", new Vector2(650, graphicsDevice.Viewport.Height - escapeTextSize.Y), Color.LimeGreen);
            }
        }
    }
}
