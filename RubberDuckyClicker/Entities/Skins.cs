
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
    public class Skins
    {
        public bool isSelected01 = true;
        public bool isSelected02 = false;
        public bool isSelected03 = false;
        public bool isSelected04 = false;

        public Rectangle Hitbox01 = new Rectangle(0, 0, AssetManager.DuckyLarge.Width / 4, AssetManager.DuckyLarge.Height / 4);
        public Rectangle Hitbox02 = new Rectangle(70, 0, AssetManager.LibertyDuck.Width / 4, AssetManager.LibertyDuck.Height / 4);
        public Rectangle Hitbox03 = new Rectangle(140, 0, AssetManager.ClownDucky.Width / 4, AssetManager.ClownDucky.Height / 4);
        public Rectangle Hitbox04 = new Rectangle(210, 0, AssetManager.SantaDucky.Width / 4, AssetManager.SantaDucky.Height / 4);

        public Color color01;
        public Color color02;
        public Color color03;
        public Color color04;

        public void Update01(GameTime gameTime)
        {
            if (isSelected01 == false)
            {
                color01 = Color.Gray;
            }
            else if (isSelected01 == true)
            {
                color01 = Color.White;
            }

            if (Main.Cursor.Hitbox.Intersects(Hitbox01))
            {
                if (Main.DuckyMouse.LeftButton == ButtonState.Pressed && Main.PrevDuckyMouse.LeftButton == ButtonState.Released)
                {
                    if (isSelected01 == false)
                    {
                        Main.click1.Play();
                        isSelected01 = true;
                        isSelected02 = false;
                        isSelected03 = false;
                        isSelected04 = false;
                        Game1.skinState = Game1.SkinState.Default;
                    }
                }
            }
        }

        public void Update02(GameTime gameTime)
        {
            if (isSelected02 == false)
            {
                color02 = Color.Gray;
            }
            else if (isSelected02 == true)
            {
                color02 = Color.White;
            }

            if (Main.Cursor.Hitbox.Intersects(Hitbox02))
            {
                if (Main.DuckyMouse.LeftButton == ButtonState.Pressed && Main.PrevDuckyMouse.LeftButton == ButtonState.Released)
                {
                    if (isSelected02 == false)
                    {
                        Main.click1.Play();
                        isSelected02 = true;
                        isSelected01 = false;
                        isSelected03 = false;
                        isSelected04 = false;
                        Game1.skinState = Game1.SkinState.Liberty;
                    }
                }
            }
        }

        public void Update03(GameTime gameTime)
        {
            if (isSelected03 == false)
            {
                color03 = Color.Gray;
            }
            else if (isSelected03 == true)
            {
                color03 = Color.White;
            }

            if (Main.Cursor.Hitbox.Intersects(Hitbox03))
            {
                if (Main.DuckyMouse.LeftButton == ButtonState.Pressed && Main.PrevDuckyMouse.LeftButton == ButtonState.Released)
                {
                    if (isSelected03 == false)
                    {
                        Main.click1.Play();
                        isSelected03 = true;
                        isSelected02 = false;
                        isSelected01 = false;
                        isSelected04 = false;
                        Game1.skinState = Game1.SkinState.Clown;
                    }
                }
            }
        }

        public void Update04(GameTime gameTime)
        {
            if (isSelected04 == false)
            {
                color04 = Color.Gray;
            }
            else if (isSelected04 == true)
            {
                color04 = Color.White;
            }

            if (Main.Cursor.Hitbox.Intersects(Hitbox04))
            {
                if (Main.DuckyMouse.LeftButton == ButtonState.Pressed && Main.PrevDuckyMouse.LeftButton == ButtonState.Released)
                {
                    if (isSelected04 == false)
                    {
                        Main.click1.Play();
                        isSelected04 = true;
                        isSelected03 = false;
                        isSelected02 = false;
                        isSelected01 = false;
                        Game1.skinState = Game1.SkinState.Santa;
                    }
                }
            }
        }

        public void Draw01(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(AssetManager.DuckyLarge, new Vector2(AssetManager.DuckyLarge.Width / 4, AssetManager.DuckyLarge.Height / 4), null, color01, 0f, new Vector2(AssetManager.DuckyLarge.Width, AssetManager.DuckyLarge.Height), 1f / 4, SpriteEffects.None, 0f);
            if (Main.Cursor.Hitbox.Intersects(Hitbox01))
            {
                    spriteBatch.DrawString(AssetManager.AchieveFont, "Rubber Ducky", new Vector2(0, 400), Color.Red);
                    spriteBatch.DrawString(AssetManager.AchieveFont, "Nice and default", new Vector2(0, 430), Color.Red);
            }
        }

        public void Draw02(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(AssetManager.LibertyDuck, new Vector2(70 + AssetManager.LibertyDuck.Width / 4, AssetManager.LibertyDuck.Height / 4), null, color02, 0f, new Vector2(AssetManager.LibertyDuck.Width, AssetManager.LibertyDuck.Height), 1f / 4, SpriteEffects.None, 0f);
            if (Main.Cursor.Hitbox.Intersects(Hitbox02))
            {
                spriteBatch.DrawString(AssetManager.AchieveFont, "Liberty Ducky", new Vector2(0, 400), Color.Red);
                spriteBatch.DrawString(AssetManager.AchieveFont, "In New York, Concrete jungle where dreams are made of, There's nothin' you can't do.", new Vector2(0, 430), Color.Red);
            }
        }

        public void Draw03(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(AssetManager.ClownDucky, new Vector2(140 + AssetManager.ClownDucky.Width / 4, AssetManager.ClownDucky.Height / 4), null, color03, 0f, new Vector2(AssetManager.ClownDucky.Width, AssetManager.ClownDucky.Height), 1f / 4, SpriteEffects.None, 0f);
            if (Main.Cursor.Hitbox.Intersects(Hitbox03))
            {
                spriteBatch.DrawString(AssetManager.AchieveFont, "Quarters The Clown", new Vector2(0, 400), Color.Red);
                spriteBatch.DrawString(AssetManager.AchieveFont, "(Made By DuckTober!) We live in a society...", new Vector2(0, 430), Color.Red);
            }
        }

        public void Draw04(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(AssetManager.SantaDucky, new Vector2(140 + AssetManager.SantaDucky.Width / 4, AssetManager.SantaDucky.Height / 4), null, color04, 0f, new Vector2(AssetManager.SantaDucky.Width, AssetManager.SantaDucky.Height), 1f / 4, SpriteEffects.None, 0f);
            if (Main.Cursor.Hitbox.Intersects(Hitbox04))
            {
                spriteBatch.DrawString(AssetManager.AchieveFont, "Santa Quack", new Vector2(0, 400), Color.Red);
                spriteBatch.DrawString(AssetManager.AchieveFont, "I am old Kris Kringle, I'm the king of jingaling!", new Vector2(0, 430), Color.Red);
            }
        }
    }
}