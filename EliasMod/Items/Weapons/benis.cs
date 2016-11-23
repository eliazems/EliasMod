using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EliasMod.Items.Weapons
{
    public class Benis : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Benis";
            item.damage = 120;
            item.melee = true;
            item.width = 80;
            item.height = 80;
            item.toolTip = "hereto grande";
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 10;
            item.value = 10000;
            item.rare = 10;
            item.useSound = 1;
            item.autoReuse = true;
            

        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Ichor, 20);
        }
    }
}