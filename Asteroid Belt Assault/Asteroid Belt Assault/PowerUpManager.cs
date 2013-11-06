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
        private float powerupTime = 10f;
        private float spawnPowerup = 20f;
        private bool powerupEnabled = false;

        public Sprite powerup;
        public Texture2D spriteSheet;
        public PlayerManager playerManager;


        public PowerupManager(Texture2D spriteSheet, PlayerManager playerManager)
        {
            this.spriteSheet = spriteSheet;
            this.playerManager = playerManager;

            SpawnPowerup();
        }

        public void SpawnPowerup()
        {
           

            powerup = new Sprite(new Vector2(20, 20), spriteSheet, new Rectangle(53, 272, 64, 64), new Vector2(50, 50));
            powerup.Velocity = new Vector2(50);

        }

        public void Update(GameTime gameTime)
        {
            if (powerup != null)
                powerup.Update(gameTime);

            if (powerup.IsCircleColliding(playerManager.playerSprite.Center, 15))
            {
                powerup.Location = new Vector2(-500, -500);
     
                powerupEnabled = true;

            }
        }

        public void Draw(SpriteBatch spritebatch)
        {
            if (powerup != null)
                powerup.Draw(spritebatch);
        }
    }
}