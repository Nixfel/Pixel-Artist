using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PixelArtist.Projectiles.Pets
{
    public class Invader : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Alien Invader");
            Main.projFrames[projectile.type] = 4;
            Main.projPet[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.ZephyrFish);
            aiType = ProjectileID.ZephyrFish;
            projectile.width = 15;
            projectile.height = 15;
        }

        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.zephyrfish = false;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            PaPlayer modPlayer = player.GetModPlayer<PaPlayer>();
            if (player.dead)
            {
                modPlayer.Invader= false;
            }
            if (modPlayer.Invader)
            {
                projectile.timeLeft = 2;
            }
        }
    }
}