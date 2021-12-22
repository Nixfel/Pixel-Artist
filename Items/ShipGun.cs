using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PixelArtist.Items
{
	public class ShipGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spaceship Gun");
			Tooltip.SetDefault("It's a ship from an arcade game you can use as a gun. \nUses spaceship rockets \nRockets home in on enemies");
		}

		public override void SetDefaults()
		{
			item.damage = 8;
			item.ranged = true;
			item.width = 24;
			item.height = 32;
			item.useTime = 32;
			item.useAnimation = 24;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 4f;
			item.value = Item.buyPrice(gold: 1);
			item.rare = ItemRarityID.Yellow;
			item.UseSound = SoundID.Item12;
			item.autoReuse = true;
			item.shoot = ProjectileID.VortexBeaterRocket;
			item.shootSpeed = 6f;
			item.useAmmo = ModContent.ItemType<ShipRocket>();        //Restrict the type of ammo the weapon can use, so that the weapon cannot use other ammos
		}
	}
}