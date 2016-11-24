using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EliasMod.Items
{
    public class PurePhazon : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Pure Phazon";
            item.width = 16;
            item.height = 16;
            item.maxStack = 99;
            item.toolTip = "'Highly concentrated Phazon, in its purist form.'";
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Phazon", 5);
            recipe.AddTile(null, "NovaWorkTableTile");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        }
}
