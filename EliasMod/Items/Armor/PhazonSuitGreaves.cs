using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EliasMod.Items.Armor
{
    public class PhazonSuitGreaves : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Phazon Suit Greaves";
            item.width = 18;
            item.height = 18;
            AddTooltip("30% increased movement speed");
            AddTooltip2("Negate Fall Damage");
            item.value = 90;
            item.rare = 2;
            item.defense = 12;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.30f;  
            player.rangedDamage += 0.05f;
            player.spikedBoots += 1;
            player.noFallDmg = true;
        }

        public override void AddRecipes()           //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "GravitySuitGreaves", 1);
            recipe.AddIngredient(null, "PurePhazon", 20);
            recipe.AddIngredient(ItemID.SoulofNight, 13);
            recipe.AddTile(null, "NovaWorkTableTile");              //na bigorna
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}