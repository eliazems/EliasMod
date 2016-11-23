using Terraria;
using Terraria.ModLoader;

namespace EliasMod.Items
{
    public class NovaDrill : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Nova Drill";
            item.height = 10;
            item.toolTip = "Can Mine Phazon";
            item.useTime = 7;
            item.useAnimation = 25;
            item.channel = true;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.pick = 250;
            item.tileBoost++;
            item.useStyle = 5;
            item.knockBack = 2;
            item.damage = 40;
            item.value = Item.buyPrice(0, 1, 20, 0);
            item.rare = 5;
            item.useSound = 23;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("NovaDrillProjectile");
            item.shootSpeed = 40f;
        }
    }
}