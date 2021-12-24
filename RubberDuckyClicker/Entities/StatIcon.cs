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
    public class StatIcon : Entity
    {
            public float statScale = 1f;

            public override void Update(GameTime gameTime)
            {
                Hitbox = new Rectangle(780 - AssetManager.StatIcon.Width, 320 - AssetManager.StatIcon.Height, AssetManager.StatIcon.Width, AssetManager.StatIcon.Height);

                if (Main.Cursor.Hitbox.Intersects(Main.StatIcon.Hitbox))
                {
                    statScale = MathHelper.Lerp(statScale, 1f, 0.15f);

                    if (Main.DuckyMouse.LeftButton == ButtonState.Pressed && Main.PrevDuckyMouse.LeftButton == ButtonState.Released)
                    {
                        Main.click1.Play();
                        Game1.gameState = Game1.GameStates.Stats;
                    }
                }
                else
                {
                    statScale = MathHelper.Lerp(statScale, 0.75f, 0.15f);
                }
            }

            public override void Draw(GameTime gameTime, SpriteBatch spriteBatch) => spriteBatch.Draw(AssetManager.StatIcon, new Vector2(780 - AssetManager.StatIcon.Width / 2, 310 - AssetManager.StatIcon.Height / 2), null, Color.White, 0f, new Vector2(AssetManager.StatIcon.Width, AssetManager.StatIcon.Height) / 2f, statScale, SpriteEffects.None, 0f);
        }
    }
