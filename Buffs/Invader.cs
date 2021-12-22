using Terraria;
using Terraria.ModLoader;

namespace PixelArtist.Buffs
{
    public class Invader : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Alien Invader");
            Description.SetDefault("An alien invader is following you!");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<PaPlayer>().Invader = true;
            bool PetProjectileNotSpawned = player.ownedProjectileCounts[ModContent.ProjectileType<Projectiles.Pets.Invader>()] <= 0;
            if (PetProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, ModContent.ProjectileType<Projectiles.Pets.Invader>(), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}