using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EliasMod.Items.Armor
{
    public class PowerSuitBreastplate : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Power Suit";
            item.width = 18;
            item.height = 18;
            AddTooltip("5% increased ranged damage");
            item.value = 40;
            item.rare = 2;
            item.defense = 4;
        }
        
        public override void UpdateEquip(Player player)
        {
            player.rangedDamage += 0.05f;   //5% de dano ranged
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MeteoriteBar, 30);   //você precisa de 30 meteorite, e 2 topaz
            recipe.AddIngredient(ItemID.Topaz, 2);
            recipe.AddTile(TileID.Anvils);   //na bigorna
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}