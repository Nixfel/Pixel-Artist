using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PixelArtist.Tiles
{
	public class White : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileLighted[Type] = true;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("White Pixel");
			AddMapEntry(new Color(255, 255, 255), name);

			dustType = DustID.DiamondBolt;
			drop = ModContent.ItemType<Items.White>();
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