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

        Texture2D dinotexture;
        Texture2D monstertexture;

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

            this.Window.Title = "AAAAAAAADDDDDIIIIINGGGGG CCCCOOOONNNTTTTENNNTTTT";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            dinotexture = Content.Load<Texture2D>("dino");
            monstertexture = Content.Load<Texture2D>("Monster");
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
            _spriteBatch.Draw(dinotexture, new Vector2(500, 250), Color.Black);
            _spriteBatch.Draw(dinotexture, new Vector2(600, 300), Color.Black);
            _spriteBatch.Draw(dinotexture, new Vector2(10, 10), Color.White);
            _spriteBatch.Draw(monstertexture, new Vector2(200, 200), Color.Red);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
