using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EliasMod.Items.Armor
{
    public class TruePhazonSuitGreaves : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Shadow Phazon Suit Greaves";
            item.width = 18;
            item.height = 18;
            AddTooltip("40% increased movement speed");
            AddTooltip2("Negate Fall Damage");
            item.value = 90;
            item.rare = 2;
            item.defense = 15;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.40f;  
            player.rangedDamage += 0.10f;
            player.spikedBoots += 1;
            player.noFallDmg = true;
        }

        public override void AddRecipes()           //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "PhazonSuitGreaves", 1);
            recipe.AddIngredient(null, "PurePhazon", 5);
            recipe.AddIngredient(ItemID.BeetleHusk, 3);
            recipe.AddIngredient(ItemID.ShadowScale, 10);
            recipe.AddIngredient(ItemID.SoulofFright, 20);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "PhazonSuitGreaves", 1);
            recipe.AddIngredient(null, "PurePhazon", 5);
            recipe.AddIngredient(ItemID.BeetleHusk, 3);
            recipe.AddIngredient(ItemID.TissueSample, 10);
            recipe.AddIngredient(ItemID.SoulofFright, 20);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}