using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EliasMod.Items.Weapons
{
    public class decapitadora : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Executioner's Blade";
            item.damage = 100;
            item.melee = true;
            item.width = 80  ;
            item.height = 80 ;
            item.toolTip = "Regenerates with the blood of enemies";
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 100;
            item.rare = 2;
            item.useSound = 1;
            item.autoReuse = true;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Terraria.ID.ItemID.MythrilBar, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
            }
       
        }
}