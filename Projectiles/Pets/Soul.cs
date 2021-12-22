using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PixelArtist.Projectiles.Pets
{
    public class Soul : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul");
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
                modPlayer.Soul = false;
            }
            if (modPlayer.Soul)
            {
                projectile.timeLeft = 2;
            }
        }
    }
}