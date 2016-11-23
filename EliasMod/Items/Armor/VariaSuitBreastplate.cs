using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EliasMod.Items.Armor
{
    public class VariaSuitBreastplate : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Varia Suit";
            item.width = 18;
            item.height = 18;
            AddTooltip("5% increased ranged damage");
            AddTooltip2("Imunity to Fire Blocks");
            item.value = 40;
            item.rare = 2;
            item.defense = 6;
        }

        public override void UpdateEquip(Player player)
        {
            player.rangedDamage += 0.05f;   //5% de dano ranged
            player.buffImmune[BuffID.Burning] = true;
            //player.buffImmune[BuffID.OnFire] = true;
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 30);   //você precisa de 30 Hellstone, e 5 Meteorite
            recipe.AddIngredient(ItemID.MeteoriteBar, 5);
            recipe.AddTile(TileID.Anvils);   //na bigorna
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}