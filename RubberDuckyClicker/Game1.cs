using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace RubberDuckyClicker
{
    public class Game1 : Game
    {
        public static Game1 Instance { get; private set; }
        public GraphicsDeviceManager DuckyGraphicsDeviceManager { get; }
        public SpriteBatch DuckySpriteBatch { get; private set; }

        public static GameStates gameState;
        public enum GameStates { Playing, Stats, Shop, Egg, Award, Skins }

        public static SkinState skinState;
        public enum SkinState { Default, Liberty, Clown, Santa }

        public Game1()
        {
            Instance = this;
            DuckyGraphicsDeviceManager = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        // Called when the program gets focused
        protected override void OnActivated(object sender, EventArgs args)
        {
            Window.Title = "RubberDuckyClicker";

            base.OnActivated(sender, args);
        }

        protected override void Initialize()
        {
            base.Initialize();
            Window.AllowAltF4 = true;
        }

        protected override void LoadContent()
        {
            DuckySpriteBatch = new SpriteBatch(GraphicsDevice);
            AssetManager.LoadAssets();

            gameState = GameStates.Playing;
        }

        protected override void Update(GameTime gameTime)
        {
            Main.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            DuckySpriteBatch.Begin();
            Main.Draw(gameTime, DuckySpriteBatch);
            DuckySpriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
