using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PixelArtist.Tiles
{
	public class Cyan : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileLighted[Type] = true;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Cyan Pixel");
			AddMapEntry(new Color(44, 232, 245), name);

			dustType = DustID.SapphireBolt;
			drop = ModContent.ItemType<Items.Cyan>();
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