using Terraria;
using Terraria.ModLoader;


namespace PixelArtist
{
	public class PixelArtist : Mod
	{
        public override void Load()
        {
            if (!Main.dedServ)
            {
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Chiptune"), ItemType("ChipMusicBox"), TileType("ChipMusicBox"));
            }
        }
    }}