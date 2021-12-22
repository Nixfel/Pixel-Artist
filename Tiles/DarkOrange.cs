using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PixelArtist.Tiles
{
	public class DarkOrange : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
            Main.tileLighted[Type] = true;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Dark Orange Pixel");
			AddMapEntry(new Color(247, 118, 34), name);

			dustType = DustID.TopazBolt;
			drop = ModContent.ItemType<Items.DarkOrange>();
			soundType = SoundID.Tink;
			soundStyle = 1;
		}
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.9f;
			g = 0.9f;
			b = 0.9f;
		}
	}
}