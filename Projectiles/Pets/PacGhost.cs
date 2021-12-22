using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PixelArtist.Projectiles.Pets
{
    public class PacGhost : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Red Ghost");
            Main.projFrames[projectile.type] = 1;
            Main.projPet[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.ZephyrFish);
            aiType = ProjectileID.ZephyrFish;
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
                modPlayer.PacGhost = false;
            }
            if (modPlayer.PacGhost)
            {
                projectile.timeLeft = 2;
            }
        }
    }
}