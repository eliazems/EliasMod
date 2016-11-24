using Terraria.ID;
using Terraria.ModLoader;

namespace EliasMod.Items
{
    public class NovaWorkTable : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Nova Worktable";
            item.width = 30;
            item.height = 30;
            item.maxStack = 99;
            AddTooltip("Used for crafting Phazon based items");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 150;
            item.createTile = mod.TileType("NovaWorkTableTile");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SilverBar, 10);
            recipe.AddIngredient(ItemID.IronBar, 5);
            recipe.AddIngredient(ItemID.Emerald, 7);
            recipe.AddIngredient(ItemID.CursedFlame, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TungstenBar, 10);
            recipe.AddIngredient(ItemID.LeadBar, 5);
            recipe.AddIngredient(ItemID.Emerald, 7);
            recipe.AddIngredient(ItemID.Ichor, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}