using PixelArtist.Items;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace PixelArtist.NPCs
{
    [AutoloadHead]
    public class PixelArtist : ModNPC
    {
        public override string Texture => "PixelArtist/NPCs/PixelArtist";

        public override bool Autoload(ref string name)
        {
            name = "Pixel Artist";
            return mod.Properties.Autoload;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pixel Artist");
            Main.npcFrameCount[npc.type] = 25;
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 700;
            NPCID.Sets.AttackType[npc.type] = 0;
            NPCID.Sets.AttackTime[npc.type] = 90;
            NPCID.Sets.AttackAverageChance[npc.type] = 30;
            NPCID.Sets.HatOffsetY[npc.type] = 4;
        }

        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 40;
            npc.aiStyle = 7;
            npc.damage = 10;
            npc.defense = 15;
            npc.lifeMax = 250;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            animationType = NPCID.Guide;
        }

        public override void HitEffect(int hitDirection, double damage)
        {
            int num = npc.life > 0 ? 1 : 5;
            for (int k = 0; k < num; k++)
            {
                Dust.NewDust(npc.position, npc.width, npc.height, DustID.Blood);
            }
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            return NPC.downedBoss2;
        }

        public override string TownNPCName()
        {
            switch (WorldGen.genRand.Next(8))
            {
                case 0: return "Leonardo";
                case 1: return "Michelangelo";
                case 2: return "Rembrandt";
                case 3: return "Picasso";
                case 4: return "Munch";
                case 5: return "Monet";
                case 6: return "Gogh";
                default: return "Pollock";
            }
        }

        public override string GetChat()
        {
            int painter = NPC.FindFirstNPC(NPCID.Painter);
            if (painter >= 0 && Main.rand.NextBool(4))
            {
                return "I think you should use my pixels instead of the paint " + Main.npc[painter].GivenName + " sells.";
            }

            int partygirl = NPC.FindFirstNPC(NPCID.PartyGirl);
            if (partygirl >= 0 && Main.rand.NextBool(4))
            {
                return Main.npc[partygirl].GivenName + " buys a lot of colorful pixels from me. I wonder what she makes with them.";
            }

            if (Main.bloodMoon && Main.rand.NextBool(4))
            {
                return "There are monsters everywhere! It must be a blood moon. To mark the occasion, I have some new items in stock.";
            }

            if (Main.eclipse && Main.rand.NextBool(4))
            {
                return "There are monsters everywhere! It must be a solar eclipse. To mark the occasion, I have some new items in stock.";
            }

            switch (Main.rand.Next(4))
            {
                case 0:
                    return "Do you like to make pixel art too?";
                case 1:
                    return "Yes, I still have both of my ears.";
                case 2:
                    return "If you are looking for pixels to buy, you have come to the right person! Just don't draw weird stuff with them...";
                default:
                    return "Looking to buy pixels? You have come to the right person!";
            }
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = Language.GetTextValue("LegacyInterface.28");
        }

        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            if (firstButton)
            {
                shop = true;
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<Black>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<Blue>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<Cyan>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<DarkBlue>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<DarkBrown>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<DarkGray>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<DarkGreen>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<DarkOrange>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<DarkPurple>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<DarkRed>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<Gray>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<LightBrown>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<LightGreen>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<LightOrange>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<LightRed>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<Pink>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<Purple>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<Tan>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<White>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<Tan>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<PacGhost>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<Invader>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<ShipGun>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<ShipRocket>());
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<ChipMusicBox>());
            nextSlot++;
            if (Main.bloodMoon)
            {
                shop.item[nextSlot].SetDefaults(ItemID.CreeperMask);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.CreeperShirt);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.CreeperPants);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<Soul>());
                nextSlot++;
            }
            if (Main.eclipse)
            {
                shop.item[nextSlot].SetDefaults(ItemID.HerosHat);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.HerosShirt);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.HerosPants);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.PaintingCastleMarsberg);
                nextSlot++;
            }
        }

        public override bool CanGoToStatue(bool toKingStatue)
        {
            return true;
        }
        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 10;
            knockback = 1f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 22;
            randExtraCooldown = 22;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = ProjectileID.Shuriken;
            attackDelay = 1;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 10f;
            randomOffset = 2f;
        }

    }
}