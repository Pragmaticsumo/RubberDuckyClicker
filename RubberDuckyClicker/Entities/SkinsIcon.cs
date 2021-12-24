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

    public class SkinsIcon : Entity
    {
        public float skinScale = 1f;

    public override void Update(GameTime gameTime)
    {
        Hitbox = new Rectangle(780 - AssetManager.SkinsIcon.Width, 210 - AssetManager.SkinsIcon.Height, AssetManager.SkinsIcon.Width, AssetManager.SkinsIcon.Height);

        if (Main.Cursor.Hitbox.Intersects(Main.SkinIcon.Hitbox))
        {
            skinScale = MathHelper.Lerp(skinScale, 1f, 0.15f);

            if (Main.DuckyMouse.LeftButton == ButtonState.Pressed && Main.PrevDuckyMouse.LeftButton == ButtonState.Released)
            {
                Main.click1.Play();
                Game1.gameState = Game1.GameStates.Skins;
            }
        }
        else
        {
            skinScale = MathHelper.Lerp(skinScale, 0.75f, 0.15f);
        }
    }

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch) => spriteBatch.Draw(AssetManager.SkinsIcon, new Vector2(780 - AssetManager.SkinsIcon.Width / 2, 200 - AssetManager.SkinsIcon.Height / 2), null, Color.White, 0f, new Vector2(AssetManager.SkinsIcon.Width, AssetManager.SkinsIcon.Height) / 2f, skinScale, SpriteEffects.None, 0f);
    }
}
