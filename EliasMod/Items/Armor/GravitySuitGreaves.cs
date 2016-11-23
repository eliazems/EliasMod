using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EliasMod.Items.Armor
{
    public class GravitySuitGreaves : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Gravity Suit Greaves";
            item.width = 18;
            item.height = 18;
            AddTooltip("20% increased movement speed");
            AddTooltip2("Negate Fall Damage");
            item.value = 90;
            item.rare = 2;
            item.defense = 6;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.20f;  
            player.rangedDamage += 0.05f;
            player.spikedBoots += 1;
            player.noFallDmg = true;
        }

        public override void AddRecipes()           //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MythrilBar, 15);   //você precisa de 25 Hellstone Bar e 2 Meteorite
            recipe.AddIngredient(ItemID.Wire, 8);
            recipe.AddTile(TileID.MythrilAnvil);              //na bigorna
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}