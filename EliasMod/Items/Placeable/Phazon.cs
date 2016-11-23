using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EliasMod.Items.Placeable
{
    public class Phazon : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Phazon Ore";
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.toolTip = "Very radioactive";
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("PhazonTile"); //put your CustomBlock Tile name
        }
        
    }
}
