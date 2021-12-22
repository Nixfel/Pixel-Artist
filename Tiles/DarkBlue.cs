using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PixelArtist.Tiles
{
	public class DarkBlue : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileLighted[Type] = true;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Dark Blue Pixel");
			AddMapEntry(new Color(18, 78, 137), name);

			dustType = DustID.SapphireBolt;
			drop = ModContent.ItemType<Items.DarkBlue>();
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