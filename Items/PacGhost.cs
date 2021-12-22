using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PixelArtist.Items
{
    public class PacGhost : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tasty Pellet");
            Tooltip.SetDefault("Apparently spherical yellow creatures like to eat these...\nSummons a red ghost to follow you");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ZephyrFish);
            item.shoot = ModContent.ProjectileType<Projectiles.Pets.PacGhost>();
            item.buffType = ModContent.BuffType<Buffs.PacGhost>();
            item.value = Item.buyPrice(gold: 1);
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
}