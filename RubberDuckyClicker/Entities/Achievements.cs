using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using RubberDuckyClicker.Entities;

namespace RubberDuckyClicker
{
    
    public class Achievements
    {
        Rectangle Hitbox00 = new Rectangle(780 - AssetManager.StatIcon.Width, 460 - AssetManager.StatIcon.Height, AssetManager.StatIcon.Width, AssetManager.StatIcon.Height);
        Rectangle Hitbox03 = new Rectangle(0, 0, AssetManager.Achieve03.Width, AssetManager.Achieve03.Height);
        public void Update00(GameTime gameTime)
        {
        }

        public void Update01(GameTime gameTime)
        {
        }

        public void Update03(GameTime gameTime)
        {
            if (Main.Cursor.Hitbox.Intersects(Main.Achievement.Hitbox00))
            {
                if (Main.DuckyMouse.LeftButton == ButtonState.Pressed && Main.PrevDuckyMouse.LeftButton == ButtonState.Released)
                {
                    Main.achieveUnlock.Play();
                    Main.achieve03 = true;
                }
            }
        }

        public void Draw00(GameTime gameTime, SpriteBatch spriteBatch) => spriteBatch.Draw(AssetManager.Achieve00, new Vector2(0, 0), null, Color.Gray, 0f, Vector2.Zero, .50f, SpriteEffects.None, 0f);
        //public void Draw01(GameTime gameTime, SpriteBatch spriteBatch) => spriteBatch.Draw(AssetManager.Achieve01, new Vector2(0, 0), null, Color.White, 0f, Vector2.Zero, .50f, SpriteEffects.None, 0f);
        public void Draw03(GameTime gameTime, SpriteBatch spriteBatch) => spriteBatch.Draw(AssetManager.Achieve03, new Vector2(0, 0), null, Color.White, 0f, Vector2.Zero, .50f, SpriteEffects.None, 0f);
    }
}

