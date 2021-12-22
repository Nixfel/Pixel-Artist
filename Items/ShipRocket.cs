using Terraria.ID;
using Terraria.ModLoader;

namespace PixelArtist.Items
{
    public class ShipRocket : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spaceship Rocket");
            Tooltip.SetDefault("Only used for the spaceship gun \nHomes in on enemies");
        }

        public override void SetDefaults()
        {
            item.damage = 8;
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1.5f;
            item.value = 5;
            item.rare = ItemRarityID.Green;
            item.shoot = ProjectileID.VortexBeaterRocket;
            item.crit = 4;
            item.shootSpeed = 16f;
            item.ammo = item.type;
        }
    }
}
