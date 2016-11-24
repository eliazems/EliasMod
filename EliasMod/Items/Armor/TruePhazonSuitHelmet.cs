using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EliasMod.Items.Armor
{
    public class TruePhazonSuitHelmet : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Head);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Shadow Phazon Suit Helmet";
            item.width = 18;
            item.height = 18;
            //item.toolTip = "This is a Star helmet.";
            item.toolTip = "night vision increased";
            item.toolTip2 = "Jump Boost";
            item.value = 10000;
            item.rare = 6;
            item.defense = 13;
        }
        public override void UpdateEquip(Player player)
        {
            player.nightVision = true;
            player.rangedDamage += 0.15f;
            player.magicDamage += 0.15f;
            //player.gills = true;
            player.jumpBoost = true;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("TruePhazonSuitBreastplate") && legs.type == mod.ItemType("TruePhazonSuitGreaves");  //put your Breastplate name and Leggings name
        }
        public override void UpdateArmorSet(Player player)
        {
            player.rangedDamage += 0.40f;
            player.magicDamage += 0.45f;
            player.setBonus = "Phazon Suit Set Bonus" + "\r\n" + "40% Ranged Damage" + "\r\n" + "45% Magic Damage";
            player.lavaImmune = true;
            //player.breath = player.breathMax;
            player.gills = true;
            player.fireWalk = true;
            player.noFallDmg = true;
            player.ignoreWater = true;
            player.gravity = Player.defaultGravity;
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "PhazonSuitHelmet", 1);
            recipe.AddIngredient(null, "PurePhazon", 5);
            recipe.AddIngredient(ItemID.BeetleHusk, 2);
            recipe.AddIngredient(ItemID.ShadowScale, 10);
            recipe.AddIngredient(ItemID.SoulofSight, 20);
            recipe.AddTile(TileID.DemonAltar);   
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "PhazonSuitHelmet", 1);
            recipe.AddIngredient(null, "PurePhazon", 5);
            recipe.AddIngredient(ItemID.BeetleHusk, 2);
            recipe.AddIngredient(ItemID.TissueSample, 10);
            recipe.AddIngredient(ItemID.SoulofSight, 20);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}