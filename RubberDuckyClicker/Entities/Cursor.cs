using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace RubberDuckyClicker.Entities
{
    public class Cursor : Entity
    {
        public override void Update(GameTime gameTime)
        {
            Position = new Vector2(Main.DuckyMouse.X, Main.DuckyMouse.Y);
            Hitbox = new Rectangle((int)Position.X, (int)Position.Y, 1, 1);
        }
    }
}
