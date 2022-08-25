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
    public class GameIcon : Entity
    {
        public float gameScale = 1f;

        public override void Update(GameTime gameTime)
        {
            Hitbox = new Rectangle(780 - AssetManager.GamesIcon.Width, 420 - AssetManager.GamesIcon.Height, AssetManager.GamesIcon.Width, AssetManager.GamesIcon.Height);

            if (Main.Cursor.Hitbox.Intersects(Main.GameIcon.Hitbox))
            {
                gameScale = MathHelper.Lerp(gameScale, 1f, 0.15f);

                if (Main.DuckyMouse.LeftButton == ButtonState.Pressed && Main.PrevDuckyMouse.LeftButton == ButtonState.Released)
                {
                    Main.click1.Play();
                    Game1.gameState = Game1.GameStates.Games;
                }
            }
            else
            {
                gameScale = MathHelper.Lerp(gameScale, 0.75f, 0.15f);
            }
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch) => spriteBatch.Draw(AssetManager.GamesIcon, new Vector2(780 - AssetManager.GamesIcon.Width / 2, 420 - AssetManager.GamesIcon.Height / 2), null, Color.White, 0f, new Vector2(AssetManager.GamesIcon.Width, AssetManager.GamesIcon.Height) / 2f, gameScale, SpriteEffects.None, 0f);
    }
}
