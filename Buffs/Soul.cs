using Terraria;
using Terraria.ModLoader;

namespace PixelArtist.Buffs
{
    public class Soul : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Soul");
            Description.SetDefault("A soul is following you!");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<PaPlayer>().Soul = true;
            bool PetProjectileNotSpawned = player.ownedProjectileCounts[ModContent.ProjectileType<Projectiles.Pets.Soul>()] <= 0;
            if (PetProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, ModContent.ProjectileType<Projectiles.Pets.Soul>(), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}