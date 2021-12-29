
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
        public bool isSelected05 = false;
        public bool isSelected06 = false;
        public bool isSelected07 = false;

        public Rectangle Hitbox01 = new Rectangle(0, 0, AssetManager.DuckyLarge.Width / 4, AssetManager.DuckyLarge.Height / 4);
        public Rectangle Hitbox02 = new Rectangle(70, 0, AssetManager.LibertyDuck.Width / 4, AssetManager.LibertyDuck.Height / 4);
        public Rectangle Hitbox03 = new Rectangle(140, 0, AssetManager.ClownDucky.Width / 4, AssetManager.ClownDucky.Height / 4);
        public Rectangle Hitbox04 = new Rectangle(210, 0, AssetManager.SantaDucky.Width / 4, AssetManager.SantaDucky.Height / 4);
        public Rectangle Hitbox05 = new Rectangle(280, 0, AssetManager.DapperDucky.Width / 4, AssetManager.DapperDucky.Height / 4);
        public Rectangle Hitbox06 = new Rectangle(350, 0, AssetManager.WhoCareDucky.Width / 4, AssetManager.WhoCareDucky.Height / 4);
        public Rectangle Hitbox07 = new Rectangle(420, 0, AssetManager.JokerDucky.Width / 4, AssetManager.JokerDucky.Height / 4);

        public Color color01;
        public Color color02;
        public Color color03;
        public Color color04;
        public Color color05;
        public Color color06;
        public Color color07;

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
                        isSelected05 = false;
                        isSelected06 = false;
                        isSelected07 = false;
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
                        isSelected05 = false;
                        isSelected06 = false;
                        isSelected07 = false;
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
                        isSelected05 = false;
                        isSelected06 = false;
                        isSelected07 = false;
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
                        isSelected05 = false;
                        isSelected06 = false;
                        isSelected07 = false;
                        Game1.skinState = Game1.SkinState.Santa;
                    }
                }
            }
        }

        public void Update05(GameTime gameTime)
        {
            if (isSelected05 == false)
            {
                color05 = Color.Gray;
            }
            else if (isSelected05 == true)
            {
                color05 = Color.White;
            }

            if (Main.Cursor.Hitbox.Intersects(Hitbox05))
            {
                if (Main.DuckyMouse.LeftButton == ButtonState.Pressed && Main.PrevDuckyMouse.LeftButton == ButtonState.Released)
                {
                    if (isSelected05 == false)
                    {
                        Main.click1.Play();
                        isSelected04 = false;
                        isSelected03 = false;
                        isSelected02 = false;
                        isSelected01 = false;
                        isSelected05 = true;
                        isSelected06 = false;
                        isSelected07 = false;
                        Game1.skinState = Game1.SkinState.Dapper;
                    }
                }
            }
        }

        public void Update06(GameTime gameTime)
        {
            if (isSelected06 == false)
            {
                color06 = Color.Gray;
            }
            else if (isSelected06 == true)
            {
                color06 = Color.White;
            }

            if (Main.Cursor.Hitbox.Intersects(Hitbox06))
            {
                if (Main.DuckyMouse.LeftButton == ButtonState.Pressed && Main.PrevDuckyMouse.LeftButton == ButtonState.Released)
                {
                    if (isSelected06 == false)
                    {
                        Main.click1.Play();
                        isSelected04 = false;
                        isSelected03 = false;
                        isSelected02 = false;
                        isSelected01 = false;
                        isSelected05 = false;
                        isSelected06 = true;
                        isSelected07 = false;
                        Game1.skinState = Game1.SkinState.WhoCare;
                    }
                }
            }
        }

        public void Update07(GameTime gameTime)
        {
            if (isSelected07 == false)
            {
                color07 = Color.Gray;
            }
            else if (isSelected07 == true)
            {
                color07 = Color.White;
            }

            if (Main.Cursor.Hitbox.Intersects(Hitbox07))
            {
                if (Main.DuckyMouse.LeftButton == ButtonState.Pressed && Main.PrevDuckyMouse.LeftButton == ButtonState.Released)
                {
                    if (isSelected07 == false)
                    {
                        Main.click1.Play();
                        isSelected04 = false;
                        isSelected03 = false;
                        isSelected02 = false;
                        isSelected01 = false;
                        isSelected05 = false;
                        isSelected06 = false;
                        isSelected07 = true;
                        Game1.skinState = Game1.SkinState.Joker;
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
                spriteBatch.DrawString(AssetManager.AchieveFont, "In New York, Concrete jungle where dreams are made of, There's nothin' you can't do.\n\nShitbox", new Vector2(0, 430), Color.Red);
            }
        }

        public void Draw03(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(AssetManager.ClownDucky, new Vector2(140 + AssetManager.ClownDucky.Width / 4, AssetManager.ClownDucky.Height / 4), null, color03, 0f, new Vector2(AssetManager.ClownDucky.Width, AssetManager.ClownDucky.Height), 1f / 4, SpriteEffects.None, 0f);
            if (Main.Cursor.Hitbox.Intersects(Hitbox03))
            {
                spriteBatch.DrawString(AssetManager.AchieveFont, "Quarters The Clown", new Vector2(0, 400), Color.Red);
                spriteBatch.DrawString(AssetManager.AchieveFont, "(Made By DuckTober!) Buisness is BOOMIN babyyyyy", new Vector2(0, 430), Color.Red);
            }
        }

        public void Draw04(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(AssetManager.SantaDucky, new Vector2(210 + AssetManager.SantaDucky.Width / 4, AssetManager.SantaDucky.Height / 4), null, color04, 0f, new Vector2(AssetManager.SantaDucky.Width, AssetManager.SantaDucky.Height), 1f / 4, SpriteEffects.None, 0f);
            if (Main.Cursor.Hitbox.Intersects(Hitbox04))
            {
                spriteBatch.DrawString(AssetManager.AchieveFont, "Santa Quack", new Vector2(0, 400), Color.Red);
                spriteBatch.DrawString(AssetManager.AchieveFont, "I am old Kris Kringle, I'm the king of jingaling!", new Vector2(0, 430), Color.Red);
            }
        }

        public void Draw05(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(AssetManager.DapperDucky, new Vector2(280 + AssetManager.DapperDucky.Width / 4, AssetManager.DapperDucky.Height / 4), null, color05, 0f, new Vector2(AssetManager.DapperDucky.Width, AssetManager.DapperDucky.Height), 1f / 4, SpriteEffects.None, 0f);
            if (Main.Cursor.Hitbox.Intersects(Hitbox05))
            {
                spriteBatch.DrawString(AssetManager.AchieveFont, "Bourgeoisie Duckie", new Vector2(0, 400), Color.Red);
                spriteBatch.DrawString(AssetManager.AchieveFont, "(Made by Aganoo!)'Their early work was a little too new wave for my tastes,\n but when Sports came out in '83, I think they really came into their own.'", new Vector2(0, 430), Color.Red);
            }
        }

        public void Draw06(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(AssetManager.WhoCareDucky, new Vector2(350 + AssetManager.WhoCareDucky.Width / 4, AssetManager.WhoCareDucky.Height / 4), null, color06, 0f, new Vector2(AssetManager.WhoCareDucky.Width, AssetManager.WhoCareDucky.Height), 1f / 4, SpriteEffects.None, 0f);
            if (Main.Cursor.Hitbox.Intersects(Hitbox06))
            {
                spriteBatch.DrawString(AssetManager.AchieveFont, "'Who Care' Ducky", new Vector2(0, 400), Color.Red);
                spriteBatch.DrawString(AssetManager.AchieveFont, "(Made by Chaz!) Who Care?", new Vector2(0, 430), Color.Red);
            }
        }

        public void Draw07(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(AssetManager.JokerDucky, new Vector2(420 + AssetManager.JokerDucky.Width / 4, AssetManager.JokerDucky.Height / 4), null, color07, 0f, new Vector2(AssetManager.JokerDucky.Width, AssetManager.JokerDucky.Height), 1f / 4, SpriteEffects.None, 0f);
            if (Main.Cursor.Hitbox.Intersects(Hitbox07))
            {
                spriteBatch.DrawString(AssetManager.AchieveFont, "Joker Ducky", new Vector2(0, 400), Color.Red);
                spriteBatch.DrawString(AssetManager.AchieveFont, "(Made by HappyHammoud) We live in a society...", new Vector2(0, 430), Color.Red);
            }
        }
    }
}