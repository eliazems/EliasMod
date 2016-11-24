using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EliasMod.Items.Armor
{
    public class TruePhazonSuitBreastplate : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Shadow Phazon Suit";
            item.width = 18;
            item.height = 18;
            AddTooltip("Provides immunity to chill and freezing effects");
            AddTooltip2("Immunity to fire blocks");
            item.value = 90;
            item.rare = 2;
            item.defense = 20;
        }

        public override void UpdateEquip(Player player)
        {
            player.rangedDamage += 0.10f;   //5% de dano ranged
            player.magicDamage += 0.30f;
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
            recipe.AddIngredient(null, "PhazonSuitBreastplate", 1);
            recipe.AddIngredient(null, "PurePhazon", 10);
            recipe.AddIngredient(ItemID.BeetleHusk, 4);
            recipe.AddIngredient(ItemID.ShadowScale, 15);
            recipe.AddIngredient(ItemID.SoulofMight, 20);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "PhazonSuitBreastplate", 1);
            recipe.AddIngredient(null, "PurePhazon", 10);
            recipe.AddIngredient(ItemID.BeetleHusk, 4);
            recipe.AddIngredient(ItemID.TissueSample, 15);
            recipe.AddIngredient(ItemID.SoulofMight, 20);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}