using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EliasMod.Buffs
{
    public class PhazonDebuff : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
            Main.buffName[this.Type] = "Phazon Radiation";
            //Main.buffTip[this.Type] = "Raidly Regen Life";
        }
        public override void Update(Player player, ref int buffIndex)
        {                                            
            player.lifeRegen -= 21;
            //player.meleeDamage += 20;
        }
        
    }
}