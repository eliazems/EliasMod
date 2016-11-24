using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EliasMod.NPCs
{
    public class LarvalMetroid : ModNPC
    {
        public override void SetDefaults()
        {
            npc.name = "Larval Metroid";
            npc.displayName = "Larval Metroid";
            npc.width = 38;
            npc.height = 38;
            npc.damage = 20;
            npc.defense = 23;
            npc.lifeMax = 100;
            npc.soundHit = 1;
            npc.soundKilled = 1;
            npc.value = 60f;
            npc.knockBackResist = 0.5f;
            npc.aiStyle = 14; //see here: http://tconfig.wikia.com/wiki/List_of_NPC_AI_Styles
            //Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
            Main.npcFrameCount[npc.type] = 3;
            aiType = NPCID.EaterofSouls;
            animationType = NPCID.EaterofSouls;
        }

        public override float CanSpawn(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.spawnTileY < Main.worldSurface && Main.dayTime ? 0.5f : 0.5f; //spawn at day
        }
        /*public override void FindFrame(int frameHeight)
        {
            npc.frameCounter -= 0.5F;
            npc.frameCounter %= Main.npcFrameCount[npc.type];
            int frame = (int)npc.frameCounter;
            npc.frame.Y = frame * frameHeight;
            npc.spriteDirection = npc.direction;
        }*/
        public override void NPCLoot()
        {
            if (Main.rand.Next(1, 50) == 1) //drop chance - This gives a 49% chance as 50-1 = 49
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Gel, Main.rand.Next(5, 10)); //amount
            }
        }
    }
}