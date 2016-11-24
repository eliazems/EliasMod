using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EliasMod.NPCs.Phantoon
{
    public class Phantoon : ModNPC
    {
        public override void SetDefaults()
        {
            npc.name = "Phantoon";
            npc.displayName = "Phantoon";
            npc.aiStyle = 5;  //5 is the flying AI
            npc.lifeMax = 10000;   //boss life
            npc.damage = 50;  //boss damage
            npc.defense = 25;    //boss defense
            npc.knockBackResist = 0;
            npc.width = 100;
            npc.height = 100;
            animationType = NPCID.DemonEye;   //this boss will behavior like the DemonEye
            Main.npcFrameCount[npc.type] = 1;    //boss frame/animation 
            npc.value = Item.buyPrice(0, 40, 75, 45);
            npc.npcSlots = 10;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.soundHit = 1;
            npc.soundKilled = 10;
            npc.buffImmune[24] = true;
            music = MusicID.Boss2;
            npc.netAlways = true;
        }
        public override void AutoloadHead(ref string headTexture, ref string bossHeadTexture)
        {
            bossHeadTexture = "EliasMod/NPCs/Boss/Phantoon_Head_Boss"; //the boss head texture
        }
        public override void BossLoot(ref string name, ref int potionType)
        {
            potionType = ItemID.LesserHealingPotion;   //boss drops
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Nova Drill"));
        }
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.579f * bossLifeScale);  //boss life scale in expertmode
            npc.damage = (int)(npc.damage * 0.6f);  //boss damage increase in expermode
        }
    }
}