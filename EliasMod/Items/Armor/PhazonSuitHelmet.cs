using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EliasMod.Items.Armor
{
    public class PhazonSuitHelmet : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Head);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Phazon Suit Helmet";
            item.width = 18;
            item.height = 18;
            //item.toolTip = "This is a Star helmet.";
            item.toolTip = "night vision increased";
            item.toolTip2 = "Jump Boost";
            item.value = 10000;
            item.rare = 6;
            item.defense = 10;
        }
        public override void UpdateEquip(Player player)
        {
            player.nightVision = true;
            player.rangedDamage += 0.10f;
            player.magicDamage += 0.10f;
            //player.gills = true;
            player.jumpBoost = true;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("PhazonSuitBreastplate") && legs.type == mod.ItemType("PhazonSuitGreaves");  //put your Breastplate name and Leggings name
        }
        public override void UpdateArmorSet(Player player)
        {
            player.rangedDamage += 0.33f;
            player.magicDamage += 0.35f;
            player.setBonus = "Gravity Suit Set Bonus" + "\r\n" + "Grants immunity to Phazon damage" + "\r\n" + "35% Magic Damage" + "\r\n" + "33% Ranged Damage";
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
            recipe.AddIngredient(null, "GravitySuitHelmet", 1);
            recipe.AddIngredient(null, "PurePhazon", 15);
            recipe.AddIngredient(ItemID.SoulofNight, 7);
            recipe.AddTile(null, "NovaWorkTableTile");   //na bigorna
            recipe.SetResult(this);
            recipe.AddRecipe();
          
        }
    }
}