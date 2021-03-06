using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EliasMod.Items.Armor
{
    public class GravitySuitHelmet : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Head);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Gravity Suit Helmet";
            item.width = 18;
            item.height = 18;
            //item.toolTip = "This is a Star helmet.";
            item.toolTip = "5% increased ranged damage";
            item.toolTip2 = "Jump Boost" + "Night Vision";
            item.value = 10000;
            item.rare = 2;
            item.defense = 5;
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
            return body.type == mod.ItemType("GravitySuitBreastplate") && legs.type == mod.ItemType("GravitySuitGreaves");  //put your Breastplate name and Leggings name
        }
        public override void UpdateArmorSet(Player player)
        {
            player.rangedDamage += 0.18f;
            player.setBonus = "Stops Lava Damage" + "\r\n" + "Free movement in liquid" + "\r\n" + "Default gravity in space"  + "Fall damage is negated" + "\r\n" + "18% increased ranged damage" + "\r\n" + "20%  Magic Damage";
            player.lavaImmune = true;
            //player.breath = player.breathMax;
            player.gills = true;
            player.magicDamage += 0.20f;
            player.fireWalk = true;
            player.noFallDmg = true;
            player.ignoreWater = true;
            player.gravity = Player.defaultGravity;
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "VariaSuitHelmet", 1);
            recipe.AddIngredient(ItemID.Gel, 13);
            recipe.AddIngredient(ItemID.Wire, 5);
            recipe.AddIngredient(ItemID.CursedFlame, 5);
            recipe.AddTile(TileID.MythrilAnvil);   //na bigorna
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "VariaSuitHelmet", 1);
            recipe.AddIngredient(ItemID.Gel, 13);
            recipe.AddIngredient(ItemID.Wire, 5);
            recipe.AddIngredient(ItemID.Ichor, 5);
            recipe.AddTile(TileID.MythrilAnvil);   //na bigorna
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}