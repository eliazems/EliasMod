using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EliasMod.Items.Armor
{
    public class PowerSuitHelmet : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Head);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Power Suit Helmet";
            item.width = 18;
            item.height = 18;
            //item.toolTip = "This is a Star helmet.";
            item.toolTip2 = "5% increased ranged damage";
            item.value = 10000;
            item.rare = 2;
            item.defense = 1;
        }
        public override void UpdateEquip(Player player)
        {
            player.nightVision = true;
            player.rangedDamage += 0.05f;
            player.gills = true;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("PowerSuitBreastplate") && legs.type == mod.ItemType("PowerSuitGreaves");  //put your Breastplate name and Leggings name
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "8% Ranged Damage"; // the armor set bonus
            player.rangedDamage *= 0.8f;
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MeteoriteBar, 20);
            recipe.AddIngredient(ItemID.Topaz, 1);  //20 Meteorite e 1 Topaz
            recipe.AddTile(TileID.Anvils);   //na bigorna
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}