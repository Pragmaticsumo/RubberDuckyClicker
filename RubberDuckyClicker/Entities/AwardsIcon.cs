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
    public class AwardsIcon : Entity
    {
        public float AwardScale = 1f;

        public override void Update(GameTime gameTime)
        {
            Hitbox = new Rectangle(780 - AssetManager.AwardIcon.Width, 100 - AssetManager.AwardIcon.Height, AssetManager.AwardIcon.Width, AssetManager.AwardIcon.Height);

            if (Main.Cursor.Hitbox.Intersects(Main.AwardIcon.Hitbox))
            {
                AwardScale = MathHelper.Lerp(AwardScale, 1f, 0.15f);

                if (Main.DuckyMouse.LeftButton == ButtonState.Pressed && Main.PrevDuckyMouse.LeftButton == ButtonState.Released)
                {
                    Main.click1.Play();
                    Game1.gameState = Game1.GameStates.Award;
                }
            }
            else
            {
                AwardScale = MathHelper.Lerp(AwardScale, 0.75f, 0.15f);
            }
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch) => spriteBatch.Draw(AssetManager.AwardIcon, new Vector2(780 - AssetManager.AwardIcon.Width / 2, 90 - AssetManager.AwardIcon.Height / 2), null, Color.White, 0f, new Vector2(AssetManager.AwardIcon.Width, AssetManager.AwardIcon.Height) / 2f, AwardScale, SpriteEffects.None, 0f);
    }
}
