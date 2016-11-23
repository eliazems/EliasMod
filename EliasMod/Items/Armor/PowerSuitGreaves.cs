using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EliasMod.Items.Armor
{
    public class PowerSuitGreaves : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Power Suit Greaves";
            item.width = 18;
            item.height = 18;
            AddTooltip2("5% increased movement speed");
            item.value = 90;
            item.rare = 2;
            item.defense = 2;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.05f;  //player movement speed incresed 0.05f = 5%
            player.rangedDamage += 0.05f;
            player.spikedBoots += 1;
            player.noFallDmg = true;
        }

        public override void AddRecipes()           //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MeteoriteBar, 25);   //você precisa de 25 Meteorite Bar e 1 Topaz
            recipe.AddIngredient(ItemID.Topaz, 1);
            recipe.AddTile(TileID.Anvils);              //na bigorna
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}