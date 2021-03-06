﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rterrariamod.Projectiles
{
    public class Moth : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 8;
            projectile.height = 8;
            projectile.aiStyle = 36;
            projectile.friendly = true;
            projectile.penetrate = 3;
            projectile.alpha = 255;
            projectile.timeLeft = 600;
            projectile.extraUpdates = 3;
            Main.projFrames[projectile.type] = 4;
            aiType = ProjectileID.Bee;
        }

        public override void AI()
        {
            if ((projectile.frameCounter = ++projectile.frameCounter % 1) == 0) projectile.frame = ++projectile.frame % 5;
        }
    }
}