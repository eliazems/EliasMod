using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace EliasMod.Tiles
{
    public class PhazonCoreTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;  //true for block to emit light
            Main.tileLighted[Type] = true;
            drop = mod.ItemType("PhazonCore");   //put your CustomBlock name
            AddMapEntry(new Color(255, 65, 0), "Phazon Core");
            minPick = 250;
            soundType = 21;  //som certo pra isso, que no caso é o da picareta na pedra
            dustType = 28;  //a 13 tem a cor exata do minério
        }
        /*public override void Effects(Player player, int index)
        {
            //player.lifeRegen -= 60;
            player.AddBuff(ModifyLight.BuffType("Phazon Radiation"), 400);

        }*/
        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)   //light colors
        {
            //r = 0.5f;
            //g = 0.5f;
            //b = 0.5f;
            r = (255f / 255f);
            g = (105f / 255f);
            b = (0f / 255f);
        }
    }
}