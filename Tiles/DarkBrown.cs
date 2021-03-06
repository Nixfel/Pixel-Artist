using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PixelArtist.Tiles
{
	public class DarkBrown : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileLighted[Type] = true;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Dark Brown Pixel");
			AddMapEntry(new Color(115, 62, 57), name);

			dustType = DustID.Pot;
			drop = ModContent.ItemType<Items.DarkBrown>();
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