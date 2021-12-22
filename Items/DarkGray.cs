using Terraria.ID;
using Terraria.ModLoader;

namespace PixelArtist.Items
{
    public class DarkGray : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dark Gray Pixel");
            Tooltip.SetDefault("This block is dark gray colored.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 5;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = ModContent.TileType<Tiles.DarkGray>();
            item.placeStyle = 0;
        }
    }
}