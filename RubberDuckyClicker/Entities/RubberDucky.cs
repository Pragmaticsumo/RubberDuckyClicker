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
    public class RubberDucky : Entity
    {        
        public float rotationSpeed = 0.1f;
        public float duckyScale = 1f;
        public float duckyRotation = 0f;
        public bool rotationDirection = false;

        public static Vector2 ScreenMiddle => Main.WindowMeasurements / 2f;

        public SoundEffect quack = AssetManager.Quack_1; 

        public override void Update(GameTime gameTime)
        {
            if (Game1.skinState == Game1.SkinState.Default)
            {
                Position = ScreenMiddle;
                Hitbox = new Rectangle((int)ScreenMiddle.X - AssetManager.DuckyLarge.Width / 2, (int)ScreenMiddle.Y - AssetManager.DuckyLarge.Height / 2, AssetManager.DuckyLarge.Width, AssetManager.DuckyLarge.Height);

                if (Main.Cursor.Hitbox.Intersects(Main.LargeDucky.Hitbox))
                {
                    duckyScale = MathHelper.Lerp(duckyScale, 1f, 0.15f);
                    rotationSpeed = MathHelper.Lerp(rotationSpeed, 0.75f, 0.025f);

                    if (Main.DuckyMouse.LeftButton == ButtonState.Pressed && Main.PrevDuckyMouse.LeftButton == ButtonState.Released)
                    {
                        Main.maxScore++;
                        Main.Score++;
                        quack.Play();
                    }
                }
                else
                {
                    duckyScale = MathHelper.Lerp(duckyScale, 0.75f, 0.15f);
                    rotationSpeed = MathHelper.Lerp(rotationSpeed, 0.1f, 0.025f);
                }

                if (rotationDirection)
                {
                    duckyRotation += MathHelper.ToRadians(rotationSpeed);

                    if (duckyRotation >= MathHelper.ToRadians(10f))
                        rotationDirection = false;
                }
                else
                {
                    duckyRotation -= MathHelper.ToRadians(rotationSpeed);

                    if (duckyRotation <= MathHelper.ToRadians(-10f))
                        rotationDirection = true;
                }
            }
            else if (Game1.skinState == Game1.SkinState.Liberty)
            {
                Position = ScreenMiddle;
                Hitbox = new Rectangle((int)ScreenMiddle.X - AssetManager.DuckyLarge.Width / 2, (int)ScreenMiddle.Y - AssetManager.DuckyLarge.Height / 2, AssetManager.DuckyLarge.Width, AssetManager.DuckyLarge.Height);

                if (Main.Cursor.Hitbox.Intersects(Main.LargeDucky.Hitbox))
                {
                    duckyScale = MathHelper.Lerp(duckyScale, 1f, 0.15f);
                    rotationSpeed = MathHelper.Lerp(rotationSpeed, 0.75f, 0.025f);

                    if (Main.DuckyMouse.LeftButton == ButtonState.Pressed && Main.PrevDuckyMouse.LeftButton == ButtonState.Released)
                    {
                        Main.maxScore++;
                        Main.Score++;
                        quack.Play();
                    }
                }
                else
                {
                    duckyScale = MathHelper.Lerp(duckyScale, 0.75f, 0.15f);
                    rotationSpeed = MathHelper.Lerp(rotationSpeed, 0.1f, 0.025f);
                }

                if (rotationDirection)
                {
                    duckyRotation += MathHelper.ToRadians(rotationSpeed);

                    if (duckyRotation >= MathHelper.ToRadians(10f))
                        rotationDirection = false;
                }
                else
                {
                    duckyRotation -= MathHelper.ToRadians(rotationSpeed);

                    if (duckyRotation <= MathHelper.ToRadians(-10f))
                        rotationDirection = true;
                }
            }
            else if (Game1.skinState == Game1.SkinState.Clown)
            {
                Position = ScreenMiddle;
                Hitbox = new Rectangle((int)ScreenMiddle.X - AssetManager.DuckyLarge.Width / 2, (int)ScreenMiddle.Y - AssetManager.DuckyLarge.Height / 2, AssetManager.DuckyLarge.Width, AssetManager.DuckyLarge.Height);

                if (Main.Cursor.Hitbox.Intersects(Main.LargeDucky.Hitbox))
                {
                    duckyScale = MathHelper.Lerp(duckyScale, 1f, 0.15f);
                    rotationSpeed = MathHelper.Lerp(rotationSpeed, 0.75f, 0.025f);

                    if (Main.DuckyMouse.LeftButton == ButtonState.Pressed && Main.PrevDuckyMouse.LeftButton == ButtonState.Released)
                    {
                        Main.maxScore++;
                        Main.Score++;
                        quack.Play();
                    }
                }
                else
                {
                    duckyScale = MathHelper.Lerp(duckyScale, 0.75f, 0.15f);
                    rotationSpeed = MathHelper.Lerp(rotationSpeed, 0.1f, 0.025f);
                }

                if (rotationDirection)
                {
                    duckyRotation += MathHelper.ToRadians(rotationSpeed);

                    if (duckyRotation >= MathHelper.ToRadians(10f))
                        rotationDirection = false;
                }
                else
                {
                    duckyRotation -= MathHelper.ToRadians(rotationSpeed);

                    if (duckyRotation <= MathHelper.ToRadians(-10f))
                        rotationDirection = true;
                }
            }
            else if (Game1.skinState == Game1.SkinState.Santa)
            {
                Position = ScreenMiddle;
                Hitbox = new Rectangle((int)ScreenMiddle.X - AssetManager.DuckyLarge.Width / 2, (int)ScreenMiddle.Y - AssetManager.DuckyLarge.Height / 2, AssetManager.DuckyLarge.Width, AssetManager.DuckyLarge.Height);

                if (Main.Cursor.Hitbox.Intersects(Main.LargeDucky.Hitbox))
                {
                    duckyScale = MathHelper.Lerp(duckyScale, 1f, 0.15f);
                    rotationSpeed = MathHelper.Lerp(rotationSpeed, 0.75f, 0.025f);

                    if (Main.DuckyMouse.LeftButton == ButtonState.Pressed && Main.PrevDuckyMouse.LeftButton == ButtonState.Released)
                    {
                        Main.maxScore++;
                        Main.Score++;
                        quack.Play();
                    }
                }
                else
                {
                    duckyScale = MathHelper.Lerp(duckyScale, 0.75f, 0.15f);
                    rotationSpeed = MathHelper.Lerp(rotationSpeed, 0.1f, 0.025f);
                }

                if (rotationDirection)
                {
                    duckyRotation += MathHelper.ToRadians(rotationSpeed);

                    if (duckyRotation >= MathHelper.ToRadians(10f))
                        rotationDirection = false;
                }
                else
                {
                    duckyRotation -= MathHelper.ToRadians(rotationSpeed);

                    if (duckyRotation <= MathHelper.ToRadians(-10f))
                        rotationDirection = true;
                }
            }
            else if (Game1.skinState == Game1.SkinState.Dapper)
            {
                Position = ScreenMiddle;
                Hitbox = new Rectangle((int)ScreenMiddle.X - AssetManager.DuckyLarge.Width / 2, (int)ScreenMiddle.Y - AssetManager.DuckyLarge.Height / 2, AssetManager.DuckyLarge.Width, AssetManager.DuckyLarge.Height);

                if (Main.Cursor.Hitbox.Intersects(Main.LargeDucky.Hitbox))
                {
                    duckyScale = MathHelper.Lerp(duckyScale, 1f, 0.15f);
                    rotationSpeed = MathHelper.Lerp(rotationSpeed, 0.75f, 0.025f);

                    if (Main.DuckyMouse.LeftButton == ButtonState.Pressed && Main.PrevDuckyMouse.LeftButton == ButtonState.Released)
                    {
                        Main.maxScore++;
                        Main.Score++;
                        quack.Play();
                    }
                }
                else
                {
                    duckyScale = MathHelper.Lerp(duckyScale, 0.75f, 0.15f);
                    rotationSpeed = MathHelper.Lerp(rotationSpeed, 0.1f, 0.025f);
                }

                if (rotationDirection)
                {
                    duckyRotation += MathHelper.ToRadians(rotationSpeed);

                    if (duckyRotation >= MathHelper.ToRadians(10f))
                        rotationDirection = false;
                }
                else
                {
                    duckyRotation -= MathHelper.ToRadians(rotationSpeed);

                    if (duckyRotation <= MathHelper.ToRadians(-10f))
                        rotationDirection = true;
                }
            }
            else if (Game1.skinState == Game1.SkinState.WhoCare)
            {
                Position = ScreenMiddle;
                Hitbox = new Rectangle((int)ScreenMiddle.X - AssetManager.DuckyLarge.Width / 2, (int)ScreenMiddle.Y - AssetManager.DuckyLarge.Height / 2, AssetManager.DuckyLarge.Width, AssetManager.DuckyLarge.Height);

                if (Main.Cursor.Hitbox.Intersects(Main.LargeDucky.Hitbox))
                {
                    duckyScale = MathHelper.Lerp(duckyScale, 1f, 0.15f);
                    rotationSpeed = MathHelper.Lerp(rotationSpeed, 0.75f, 0.025f);

                    if (Main.DuckyMouse.LeftButton == ButtonState.Pressed && Main.PrevDuckyMouse.LeftButton == ButtonState.Released)
                    {
                        Main.maxScore++;
                        Main.Score++;
                        quack.Play();
                    }
                }
                else
                {
                    duckyScale = MathHelper.Lerp(duckyScale, 0.75f, 0.15f);
                    rotationSpeed = MathHelper.Lerp(rotationSpeed, 0.1f, 0.025f);
                }

                if (rotationDirection)
                {
                    duckyRotation += MathHelper.ToRadians(rotationSpeed);

                    if (duckyRotation >= MathHelper.ToRadians(10f))
                        rotationDirection = false;
                }
                else
                {
                    duckyRotation -= MathHelper.ToRadians(rotationSpeed);

                    if (duckyRotation <= MathHelper.ToRadians(-10f))
                        rotationDirection = true;
                }
            }
            else if (Game1.skinState == Game1.SkinState.Joker)
            {
                Position = ScreenMiddle;
                Hitbox = new Rectangle((int)ScreenMiddle.X - AssetManager.DuckyLarge.Width / 2, (int)ScreenMiddle.Y - AssetManager.DuckyLarge.Height / 2, AssetManager.DuckyLarge.Width, AssetManager.DuckyLarge.Height);

                if (Main.Cursor.Hitbox.Intersects(Main.LargeDucky.Hitbox))
                {
                    duckyScale = MathHelper.Lerp(duckyScale, 1f, 0.15f);
                    rotationSpeed = MathHelper.Lerp(rotationSpeed, 0.75f, 0.025f);

                    if (Main.DuckyMouse.LeftButton == ButtonState.Pressed && Main.PrevDuckyMouse.LeftButton == ButtonState.Released)
                    {
                        Main.maxScore++;
                        Main.Score++;
                        quack.Play();
                    }
                }
                else
                {
                    duckyScale = MathHelper.Lerp(duckyScale, 0.75f, 0.15f);
                    rotationSpeed = MathHelper.Lerp(rotationSpeed, 0.1f, 0.025f);
                }

                if (rotationDirection)
                {
                    duckyRotation += MathHelper.ToRadians(rotationSpeed);

                    if (duckyRotation >= MathHelper.ToRadians(10f))
                        rotationDirection = false;
                }
                else
                {
                    duckyRotation -= MathHelper.ToRadians(rotationSpeed);

                    if (duckyRotation <= MathHelper.ToRadians(-10f))
                        rotationDirection = true;
                }
            }
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            if (Game1.skinState == Game1.SkinState.Default)
            {
                spriteBatch.Draw(AssetManager.DuckyLarge, ScreenMiddle, null, Color.White, duckyRotation, new Vector2(AssetManager.DuckyLarge.Width, AssetManager.DuckyLarge.Height) / 2f, duckyScale, SpriteEffects.None, 0f);
            }
            else if (Game1.skinState == Game1.SkinState.Liberty)
            {
                spriteBatch.Draw(AssetManager.LibertyDuck, ScreenMiddle, null, Color.White, duckyRotation, new Vector2(AssetManager.DuckyLarge.Width, AssetManager.DuckyLarge.Height) / 2f, duckyScale, SpriteEffects.None, 0f);
            }
            else if (Game1.skinState == Game1.SkinState.Clown)
            {
                spriteBatch.Draw(AssetManager.ClownDucky, ScreenMiddle, null, Color.White, duckyRotation, new Vector2(AssetManager.DuckyLarge.Width, AssetManager.DuckyLarge.Height) / 2f, duckyScale, SpriteEffects.None, 0f);
            }
            else if (Game1.skinState == Game1.SkinState.Santa)
            {
                spriteBatch.Draw(AssetManager.SantaDucky, ScreenMiddle, null, Color.White, duckyRotation, new Vector2(AssetManager.DuckyLarge.Width, AssetManager.DuckyLarge.Height) / 2f, duckyScale, SpriteEffects.None, 0f);
            }
            else if (Game1.skinState == Game1.SkinState.Dapper)
            {
                spriteBatch.Draw(AssetManager.DapperDucky, ScreenMiddle, null, Color.White, duckyRotation, new Vector2(AssetManager.DuckyLarge.Width, AssetManager.DuckyLarge.Height) / 2f, duckyScale, SpriteEffects.None, 0f);
            }
            else if (Game1.skinState == Game1.SkinState.WhoCare)
            {
                spriteBatch.Draw(AssetManager.WhoCareDucky, ScreenMiddle, null, Color.White, duckyRotation, new Vector2(AssetManager.DuckyLarge.Width, AssetManager.DuckyLarge.Height) / 2f, duckyScale, SpriteEffects.None, 0f);
            }
            else if (Game1.skinState == Game1.SkinState.Joker)
            {
                spriteBatch.Draw(AssetManager.JokerDucky, ScreenMiddle, null, Color.White, duckyRotation, new Vector2(AssetManager.DuckyLarge.Width, AssetManager.DuckyLarge.Height) / 2f, duckyScale, SpriteEffects.None, 0f);
            }
        }
    }
}
