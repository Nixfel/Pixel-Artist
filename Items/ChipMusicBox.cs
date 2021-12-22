using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace PixelArtist.Items
{
	public class ChipMusicBox : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chiptune Music Box");
			Tooltip.SetDefault("Plays a chiptune song\nSong: Happy Airlines by Milton");
		}

		public override void SetDefaults()
		{
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.ChipMusicBox>();
			item.width = 24;
			item.height = 24;
			item.rare = ItemRarityID.LightRed;
			item.value = Item.buyPrice(gold: 1);
			item.accessory = true;
		}
	}
}