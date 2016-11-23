using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EliasMod.Items.Armor
{
    public class VariaSuitGreaves : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Varia Suit Greaves";
            item.width = 18;
            item.height = 18;
            AddTooltip("10% increased movement speed");
            AddTooltip2("Negate Fall Damage");
            item.value = 90;
            item.rare = 2;
            item.defense = 3;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.10f;  
            player.rangedDamage += 0.05f;
            player.spikedBoots += 1;
            player.noFallDmg = true;
        }

        public override void AddRecipes()           //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 25);   //você precisa de 25 Hellstone Bar e 2 Meteorite
            recipe.AddIngredient(ItemID.MeteoriteBar, 2);
            recipe.AddTile(TileID.Anvils);              //na bigorna
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}