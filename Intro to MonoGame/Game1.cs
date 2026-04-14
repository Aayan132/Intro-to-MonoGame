using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Intro_to_MonoGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Rectangle window;

        Texture2D Moontexture;
        Texture2D Werewolftexture;
        Texture2D NightSkytexture;
        Texture2D UFOtexture;
        //Texture2D Mountaintexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            //Resize Window
            window = new Rectangle(0, 0, 800, 600);
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();

            this.Window.Title = "Assignment 1";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            Moontexture = Content.Load<Texture2D>("Moon");
            Werewolftexture = Content.Load<Texture2D>("Werewolf");
            NightSkytexture = Content.Load<Texture2D>("Night Sky");
            UFOtexture = Content.Load<Texture2D>("UFO2");
            //Mountaintexture = Content.Load<Texture2D>("Mountain");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();
            _spriteBatch.Draw(NightSkytexture, window, Color.White);
            //_spriteBatch.Draw(Mountaintexture, new Vector2(500, 500), Color.White);
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 5; col++) 
                {
                    _spriteBatch.Draw(UFOtexture, new Vector2(1 + col * 20, 0 + row * 20), Color.White);
                }
            }
            _spriteBatch.Draw(Moontexture, new Vector2(185, 50), Color.White);
            _spriteBatch.Draw(Werewolftexture, new Vector2(240, 150), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
