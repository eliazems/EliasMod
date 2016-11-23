using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EliasMod.Items.Armor
{
    public class GravitySuitBreastplate : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Gravity Suit";
            item.width = 18;
            item.height = 18;
            AddTooltip("Provides immunity to chill and freezing effects");
            AddTooltip2("Immunity to fire blocks");
            item.value = 90;
            item.rare = 2;
            item.defense = 10;
        }

        public override void UpdateEquip(Player player)
        {
            player.rangedDamage += 0.05f;   //5% de dano ranged
            player.fireWalk = true;
            //player.knockbackresist -= 0.5f;
            player.buffImmune[46] = true;
            player.buffImmune[47] = true;
            //player.lavaImmune = true;
            //player.ignoreWater = true;
            //player.buffImmune[BuffID.OnFire] = true;
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MythrilBar, 20);   
            recipe.AddIngredient(ItemID.Wire, 12);
            recipe.AddTile(TileID.MythrilAnvil);   //na bigorna
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}