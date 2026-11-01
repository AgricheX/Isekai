using System;
using System.Threading;
using NCMS;
using UnityEngine;
using ReflectionUtility;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Beebyte.Obfuscator;
using ai;

namespace Isekai
{
    class IsekaiTraits
    {
        public static void init()
        {
         //Androids Power
         ActorTrait androidpower = new ActorTrait();
         androidpower.action_attack_target = new AttackAction(AndroidAtackEffect1);
         androidpower.action_death = new WorldAction(AndroidDeath);
         androidpower.id = "AndroidPower";
         androidpower.path_icon = "ui/Extras/iconAndroidPower";
         androidpower.group_id = IsekaiTraitGroup.isekai;
         androidpower.can_be_given = true;
         AssetManager.traits.add(androidpower);
         addTraitToLocalizedLibrary(androidpower.id, "Using NanoMachines, has a rare chance to turn the opponent into an Android.");
         PlayerConfig.unlockTrait("AndroidPower");

         ActorTrait androidpower2 = new ActorTrait();
         androidpower2.action_death = new WorldAction(AndroidAtackEffect2);
         androidpower2.id = "AndroidPower2";
         androidpower2.path_icon = "ui/Extras/iconAndroidPower2";
         androidpower2.group_id = IsekaiTraitGroup.isekai;
         androidpower2.can_be_given = true;
         AssetManager.traits.add(androidpower2);
         addTraitToLocalizedLibrary(androidpower2.id, "It will soon turn into an Android.");
         PlayerConfig.unlockTrait("AndroidPower2");

         //Witch Power
         ActorTrait witchpowers = new ActorTrait();
         witchpowers.action_get_hit = new GetHitAction(WitchPowers1);
         //witchpowers.action_get_hit = new GetHitAction(WitchPowers2);
         witchpowers.id = "WitchPowers";
         witchpowers.path_icon = "ui/Extras/iconWitchPowers";
         witchpowers.group_id = IsekaiTraitGroup.isekai;
         witchpowers.can_be_given = true;
         AssetManager.traits.add(witchpowers);
         addTraitToLocalizedLibrary(witchpowers.id, "These are the witch's powers.");
         PlayerConfig.unlockTrait("WitchPowers");

         //Demon King Power
         ActorTrait demonkingpowers = new ActorTrait();
         demonkingpowers.action_get_hit = new GetHitAction(DemonKingPowers1);
         demonkingpowers.id = "DemonKingPowers";
         demonkingpowers.path_icon = "ui/Extras/iconDemonKingPowers";
         demonkingpowers.group_id = IsekaiTraitGroup.isekai;
         demonkingpowers.can_be_given = true;
         AssetManager.traits.add(demonkingpowers);
         addTraitToLocalizedLibrary(demonkingpowers.id, "The Powers of the Demon King.");
         PlayerConfig.unlockTrait("DemonKingPowers");

         //Godzilla Power
         ActorTrait GodzillaPower = new ActorTrait();
         GodzillaPower.id = "Godzilla Power";
         GodzillaPower.path_icon = "ui/Extras/iconGodzillaPower";
         GodzillaPower.group_id = IsekaiTraitGroup.isekai;
         GodzillaPower.can_be_given = false;
         GodzillaPower.action_attack_target = new AttackAction(GodzillaPower1);
         GodzillaPower.action_special_effect = new WorldAction(GodzillaPower2);
         GodzillaPower.action_attack_target = new AttackAction(GodzillaPower3);
         AssetManager.traits.add(GodzillaPower);
         addTraitToLocalizedLibrary(GodzillaPower.id, "The Godzilla Power.");
         PlayerConfig.unlockTrait("Godzilla Power");
        }

         //Effects

        public static bool AndroidAtackEffect1(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null) 
      	{
         if (pTarget != null)
         {
         Actor a = Reflection.GetField(pTarget.GetType(), pTarget, "a") as Actor;
         if (Toolbox.randomChance(0.001f)){ //0.001
         a.addTrait("AndroidPower2");
         }
      	 return true;
         }
         return false;

        }
        public static bool AndroidAtackEffect2(BaseSimObject pTarget, WorldTile pTile = null)
        {
            Actor a = pTarget.a;
            a.removeTrait("cursed");
            a.removeTrait("infected");
            a.removeTrait("mushSpores");
            a.removeTrait("tumorInfection");
            a.removeTrait("AndroidPower2");
            var act = World.world.units.createNewUnit("unit_android", pTile, 0f);
            ActorTool.copyUnitToOtherUnit(a, act);
            act.data.health += 100;
            EffectsLibrary.spawn("fx_spawn", act.currentTile, null, null, 0f, -1f, -1f);
            return true;

        }
        public static bool AndroidDeath(BaseSimObject pTarget, WorldTile pTile = null)
      	{
         if (pTarget != null)
         {
         EffectsLibrary.spawnAtTileRandomScale("fx_explosion_small", pTile, 0.1f, 0.15f);
         }
      		return true;
        }
        public static bool WitchPowers1(BaseSimObject pSelf, BaseSimObject pAttackedBy = null, WorldTile pTile = null)
        {
            if (Toolbox.randomChance(0.05f))
            {
                Actor a = Reflection.GetField(pSelf.GetType(), pSelf, "a") as Actor;
                ActorData pData = (ActorData)Reflection.GetField(typeof(Actor), a, "data");
                int count = 0;
                if (pData.custom_data_int == null || !pData.custom_data_int.TryGetValue("ghostCount", out count))
                {
                    pData.set("ghostCount", 0);
                }
                if (count < 1)
                {
                    var act = World.world.units.createNewUnit("ghost", pTile);
                    act.kingdom = pSelf.kingdom;
                    count++;
                    pData.set("ghostCount", count);
                }
            }
            return false;

        }
        public static bool DemonKingPowers1(BaseSimObject pSelf, BaseSimObject pAttackedBy = null, WorldTile pTile = null)
        {
            if (Toolbox.randomChance(0.05f))
            {
                Actor a = Reflection.GetField(pSelf.GetType(), pSelf, "a") as Actor;
                ActorData pData = (ActorData)Reflection.GetField(typeof(Actor), a, "data");
                int count = 0;
                if (pData.custom_data_int == null || !pData.custom_data_int.TryGetValue("demonCount", out count))
                {
                    pData.set("demonCount", 0);
                }
                if (count < 1)
                {
                    var act = World.world.units.createNewUnit("demon", pTile);
                    act.kingdom = pSelf.kingdom;
                    count++;
                    pData.set("demonCount", count);
                }
            }
            return false;

            //Godzilla Power Effects
         }
        public static bool GodzillaPower1(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null) 
      	{
          if(pTarget != null){
          if(Toolbox.randomChance(0.5f)){
          World.world.applyForce(pTile, 3, 0.3f, true, true, 0, null, pSelf, null);
          EffectsLibrary.spawnExplosionWave(pTile.posV3, 3f, 0.5f);
          }
        return true;
        }
            return false; 

          }
        public static bool GodzillaPower2(BaseSimObject pTarget, WorldTile pTile = null) 
      	{
          if(pTarget != null){
          if(Toolbox.randomChance(0.001f)){
          World.world.applyForce(pTile, 3, 0.3f, true, true, 0, null, pTarget, null);
          EffectsLibrary.spawnExplosionWave(pTile.posV3, 3f, 0.5f);
          World.world.earthquakeManager.startQuake(pTile, EarthquakeType.RandomPower);
          }
        return true;
        }
            return false;

          }
        public static bool GodzillaPower3(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null) 
      	{
          if(pTarget != null){
          if(Toolbox.randomChance(0.01f)){
          World.world.applyForce(pTile, 3, 0.3f, true, true, 0, null, pTarget, null);
          EffectsLibrary.spawn("fx_nuke_flash", pTile, "atomicBomb", null, 0f, -1f, -1f);
          }
        return true;
        }
            return false;
        
         //Boring

        }
        public static void addTraitToLocalizedLibrary(string id, string description)
      	{
      		string language = Reflection.GetField(LocalizedTextManager.instance.GetType(), LocalizedTextManager.instance, "language") as string;
      		Dictionary<string, string> localizedText = Reflection.GetField(LocalizedTextManager.instance.GetType(), LocalizedTextManager.instance, "localizedText") as Dictionary<string, string>;
      		localizedText.Add("trait_" + id, id);
      		localizedText.Add("trait_" + id + "_info", description);
        }
    }
}