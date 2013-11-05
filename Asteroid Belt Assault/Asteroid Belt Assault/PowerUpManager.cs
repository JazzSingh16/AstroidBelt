using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Asteroid_Belt_Assault
{
    class PowerupManager
    {
        Texture2D spriteSheet;
        private PlayerManager playerManager;
        public List<Sprite> Powerups = new List<Sprite>();

        public PowerupManager(Texture2D spriteSheet, PlayerManager playerManager)
        {
            this.spriteSheet = spriteSheet;
            this.playerManager = playerManager;

            
            SpawnPowerup();
        }

        public void SpawnPowerup()
        {
            Powerups.Add(new Sprite(new Vector2(55, 272), spriteSheet, new Rectangle(55, 272, 65, 65), Vector2.Zero));
        }

        public void Update(GameTime gameTime)
        {
            for (int i = Powerups.Count - 1; i >= 0; i--)
                Powerups[i].Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = Powerups.Count - 1; i >= 0; i--)
                Powerups[i].Draw(spriteBatch);
        }
    }
}