using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PixelArtist.Items
{
    public class Invader : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Little Ufo");
            Tooltip.SetDefault("It seems to be an alien's ufo...\nSummons a pet alien invader to follow you");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ZephyrFish);
            item.shoot = ModContent.ProjectileType<Projectiles.Pets.Invader>();
            item.buffType = ModContent.BuffType<Buffs.Invader>();
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