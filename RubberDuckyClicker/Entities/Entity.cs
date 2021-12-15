using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace RubberDuckyClicker.Entities
{

    public abstract class Entity
    {
        public Vector2 Position;

        public Rectangle Hitbox;

        public virtual bool IntersectsEntity(Entity entity) => Hitbox.Intersects(entity.Hitbox);

        public virtual bool IntersectsRectangle(Rectangle hitbox) => Hitbox.Intersects(hitbox);

        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
        }

        public virtual void Update(GameTime gameTime)
        {
        }
    }
}
