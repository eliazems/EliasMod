using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EliasMod.Items.Armor
{
    public class VariaSuitHelmet : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Head);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Varia Suit Helmet";
            item.width = 18;
            item.height = 18;
            //item.toolTip = "This is a Star helmet.";
            item.toolTip2 = "5% increased ranged damage";
            item.value = 10000;
            item.rare = 2;
            item.defense = 3;
        }
        public override void UpdateEquip(Player player)
        {
            player.nightVision = true;
            player.rangedDamage += 0.05f;
            player.gills = true;
            //player.breath = player.breathMax;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("VariaSuitBreastplate") && legs.type == mod.ItemType("VariaSuitGreaves");  //put your Breastplate name and Leggings name
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "15% Ranged Damage"; // the armor set bonus
            player.rangedDamage *= 0.15f;
        }
        
        public override void AddRecipes()  //How to craft this item
        {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.MeteoriteBar, 5);
        recipe.AddIngredient(ItemID.HellstoneBar, 20);  //20 Hellstone e 5 Meteorite
        recipe.AddTile(TileID.Anvils);   //na bigorna
        recipe.SetResult(this);
        recipe.AddRecipe();
        }
    }
}