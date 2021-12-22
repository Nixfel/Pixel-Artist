using Terraria.ModLoader;

namespace PixelArtist
{
    public class PaPlayer : ModPlayer // Pa stands for "Pixel Art" or "Pixel Artist"
    {
        public bool PacGhost;

        public bool Invader;

        public bool Soul;

        public override void ResetEffects()
        {
            PacGhost = false;

            Invader = false;

            Soul = false;
        }
    }
}