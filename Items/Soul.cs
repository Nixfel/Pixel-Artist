using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PixelArtist.Items
{
    public class Soul : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Worn Dagger");
            Tooltip.SetDefault("Perfect for cutting plants and vines.\nSummons a pet soul to follow you");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ZephyrFish);
            item.shoot = ModContent.ProjectileType<Projectiles.Pets.Soul>();
            item.buffType = ModContent.BuffType<Buffs.Soul>();
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