using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using RubberDuckyClicker.Entities;

namespace RubberDuckyClicker.Entities
{
    public class Achievement
    {
        public Texture2D icon01 = AssetManager.Achieve00;
        public Texture2D icon02 = AssetManager.Achieve00;
        public Texture2D icon03 = AssetManager.Achieve00;
        public Texture2D icon04 = AssetManager.Achieve00;

        public bool isUnlocked01 = false;
        public bool isUnlocked02 = false;
        public bool isUnlocked03 = false;
        public bool isUnlocked04 = false;

        public Rectangle Hitbox01 = new Rectangle(0, 0, AssetManager.Achieve01.Width / 2, AssetManager.Achieve01.Height / 2);
        public Rectangle Hitbox02 = new Rectangle(50, 0, AssetManager.Achieve02.Width / 2, AssetManager.Achieve02.Height / 2);
        public Rectangle Hitbox03 = new Rectangle(100, 0, AssetManager.Achieve03.Width / 2, AssetManager.Achieve03.Height / 2);
        public Rectangle Hitbox04 = new Rectangle(150, 0, AssetManager.Achieve04.Width / 2, AssetManager.Achieve04.Height / 2);

        public Color color01;
        public Color color02;
        public Color color03;
        public Color color04;

        public void Update01(GameTime gameTime)
        {
            if (isUnlocked01 == false)
            {
                icon01 = AssetManager.Achieve00;
                color01 = Color.Gray;
            }
            else if (isUnlocked01 == true)
            {
                icon01 = AssetManager.Achieve01;
                color01 = Color.White;
            }

            if (Main.Cursor.Hitbox.Intersects(Hitbox01))
            {
                if (Main.DuckyMouse.LeftButton == ButtonState.Pressed && Main.PrevDuckyMouse.LeftButton == ButtonState.Released)
                {
                    if (isUnlocked01 == false)
                    {
                        Main.achieveUnlock.Play();
                        isUnlocked01 = true;
                    }
                }
            }
        }

        public void Update02(GameTime gameTime)
        {
            if (isUnlocked02 == false)
            {
                icon02 = AssetManager.Achieve00;
                color02 = Color.Gray;
            }
            else if (isUnlocked02 == true)
            {
                icon02 = AssetManager.Achieve02;
                color02 = Color.White;
            }

            if (isUnlocked02 == false)
            {
                if (Main.maxScore == 1)
                {
                    Main.achieveUnlock.Play();
                    isUnlocked02 = true;
                }
            }
        }

        public void Update03(GameTime gameTime)
        {
            if (isUnlocked03 == false)
            {
                icon03 = AssetManager.Achieve00;
                color03 = Color.Gray;
            }
            else if (isUnlocked03 == true)
            {
                icon03 = AssetManager.Achieve03;
                color03 = Color.White;
            }

            if (isUnlocked03 == false)
            {
                if (Main.maxScore == 10)
                {
                    Main.achieveUnlock.Play();
                    isUnlocked03 = true;
                }
            }
        }

        public void Update04(GameTime gameTime)
        {
            if (isUnlocked04 == false)
            {
                icon04 = AssetManager.Achieve00;
                color04 = Color.Gray;
            }
            else if (isUnlocked04 == true)
            {
                icon04 = AssetManager.Achieve04;
                color04 = Color.White;
            }

            if (isUnlocked04 == false)
            {
                if (Main.maxScore == 100)
                {
                    Main.achieveUnlock.Play();
                    isUnlocked04 = true;
                }
            }
        }

        public void Draw01(GameTime gameTime, SpriteBatch spriteBatch)
        { 
            spriteBatch.Draw(icon01, new Vector2(AssetManager.Achieve00.Width / 2, AssetManager.Achieve00.Height / 2), null, color01, 0f, new Vector2(AssetManager.Achieve00.Width, AssetManager.Achieve00.Height), .50f, SpriteEffects.None, 0f);

            if (Main.Cursor.Hitbox.Intersects(Hitbox01))
            {
                if (isUnlocked01 == false)
                {
                    spriteBatch.DrawString(AssetManager.AchieveFont, "???", new Vector2(0, 400), Color.Red);
                    spriteBatch.DrawString(AssetManager.AchieveFont, "?????", new Vector2(0, 430), Color.Red);
                }
                else if (isUnlocked01 == true)
                {
                    spriteBatch.DrawString(AssetManager.AchieveFont, "'All You Had To Do Is Ask'", new Vector2(0, 400), Color.Red);
                    spriteBatch.DrawString(AssetManager.AchieveFont, "Wait a second, this sounds familiar...", new Vector2(0, 430), Color.Red);
                }
            }
        }

        public void Draw02(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(icon02, new Vector2(50 + AssetManager.Achieve00.Width / 2, AssetManager.Achieve00.Height / 2), null, color02, 0f, new Vector2(AssetManager.Achieve00.Width, AssetManager.Achieve00.Height), .50f, SpriteEffects.None, 0f);

            if (Main.Cursor.Hitbox.Intersects(Hitbox02))
            {
                if (isUnlocked02 == false)
                {
                    spriteBatch.DrawString(AssetManager.AchieveFont, "???", new Vector2(0, 400), Color.Red);
                    spriteBatch.DrawString(AssetManager.AchieveFont, "?????", new Vector2(0, 430), Color.Red);
                }
                else if (isUnlocked02 == true)
                {
                    spriteBatch.DrawString(AssetManager.AchieveFont, "Quack!", new Vector2(0, 400), Color.Red);
                    spriteBatch.DrawString(AssetManager.AchieveFont, "Wowza, you clicked once!", new Vector2(0, 430), Color.Red);
                }
            }
        }

        public void Draw03(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(icon03, new Vector2(100 + AssetManager.Achieve00.Width / 2, AssetManager.Achieve00.Height / 2), null, color03, 0f, new Vector2(AssetManager.Achieve00.Width, AssetManager.Achieve00.Height), .50f, SpriteEffects.None, 0f);

            if (Main.Cursor.Hitbox.Intersects(Hitbox03))
            {
                if (isUnlocked03 == false)
                {
                    spriteBatch.DrawString(AssetManager.AchieveFont, "???", new Vector2(0, 400), Color.Red);
                    spriteBatch.DrawString(AssetManager.AchieveFont, "?????", new Vector2(0, 430), Color.Red);
                }
                else if (isUnlocked03 == true)
                {
                    spriteBatch.DrawString(AssetManager.AchieveFont, "Quackier!", new Vector2(0, 400), Color.Red);
                    spriteBatch.DrawString(AssetManager.AchieveFont, "Literal show off...", new Vector2(0, 430), Color.Red);
                }
            }
        }

        public void Draw04(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(icon04, new Vector2(150 + AssetManager.Achieve00.Width / 2, AssetManager.Achieve00.Height / 2), null, color04, 0f, new Vector2(AssetManager.Achieve00.Width, AssetManager.Achieve00.Height), .50f, SpriteEffects.None, 0f);

            if (Main.Cursor.Hitbox.Intersects(Hitbox04))
            {
                if (isUnlocked04 == false)
                {
                    spriteBatch.DrawString(AssetManager.AchieveFont, "???", new Vector2(0, 400), Color.Red);
                    spriteBatch.DrawString(AssetManager.AchieveFont, "?????", new Vector2(0, 430), Color.Red);
                }
                else if (isUnlocked04 == true)
                {
                    spriteBatch.DrawString(AssetManager.AchieveFont, "Quackiest!", new Vector2(0, 400), Color.Red);
                    spriteBatch.DrawString(AssetManager.AchieveFont, "My jaw is on the ground...", new Vector2(0, 430), Color.Red);
                }
            }
        }
    }
}

