using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using NCMS;
using NCMS.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using ReflectionUtility;
using System.Reflection;
using HarmonyLib;
using Newtonsoft.Json;
using static Config;

namespace Isekai
{
    class IsekaiButtons
    {
        public static void init()
        {
            IsekaiTab.createTab("Button Tab_Isekai", "Tab_Isekai", "Isekai", "Spawn Isekai World beings directly in your world!!", -150);
            loadButtons();
        }

        private static void loadButtons()
        {
            PowersTab isekaiworldTab = getPowersTab("Isekai");
            //Races

            #region races

            var android = new GodPower();
            android.id = "spawnandroid";
            android.showSpawnEffect = true;
            android.multiple_spawn_tip = true;
            android.actorSpawnHeight = 3f;
            android.name = "spawnandroid";
            android.spawnSound = "spawnelf";
            android.actor_asset_id = "unit_android";
            android.click_action = new PowerActionWithID(callSpawnUnit);
            AssetManager.powers.add(android);

            var buttonandroid = NCMS.Utils.PowerButtons.CreateButton(
            "spawnandroid",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.iconandroids.png"),
            "A Mechanical Race",
            "The Mechanical Race Android",
            new Vector2(72, 18),
            ButtonType.GodPower, 
            isekaiworldTab.transform, 
            null
            );

            var darkelve = new GodPower();
            darkelve.id = "spawndarkelve";
            darkelve.showSpawnEffect = true;
            darkelve.multiple_spawn_tip = true;
            darkelve.actorSpawnHeight = 3f;
            darkelve.name = "spawndarkelve";
            darkelve.spawnSound = "spawnelf";
            darkelve.actor_asset_id = "unit_darkelve";
            darkelve.click_action = new PowerActionWithID(callSpawnUnit);
            AssetManager.powers.add(darkelve);

            var buttondarkelve = NCMS.Utils.PowerButtons.CreateButton(
            "spawndarkelve",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.icondarkelve.png"),
            "The Dark Elves",
            "The Great Race of Dark Elves",
            new Vector2(72, -18),
            ButtonType.GodPower, 
            isekaiworldTab.transform, 
            null
            );

            var beastmen = new GodPower();
            beastmen.id = "spawnbeastmen";
            beastmen.showSpawnEffect = true;
            beastmen.multiple_spawn_tip = true;
            beastmen.actorSpawnHeight = 3f;
            beastmen.name = "spawnbeastmen";
            beastmen.spawnSound = "spawnelf";
            beastmen.actor_asset_id = "unit_beastmen";
            beastmen.click_action = new PowerActionWithID(callSpawnUnit);
            AssetManager.powers.add(beastmen);

            var buttonbeastmen = NCMS.Utils.PowerButtons.CreateButton(
            "spawnbeastmen",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.iconbeastmen.png"),
            "The Beast Men",
            "The Great Race of Beast Men",            
            new Vector2(108, 18),
            ButtonType.GodPower, 
            isekaiworldTab.transform, 
            null
            );

            var gnome = new GodPower();
            gnome.id = "spawngnome";
            gnome.showSpawnEffect = true;
            gnome.multiple_spawn_tip = true;
            gnome.actorSpawnHeight = 3f;
            gnome.name = "spawngnome";
            gnome.spawnSound = "spawnelf";
            gnome.actor_asset_id = "unit_gnome";
            gnome.click_action = new PowerActionWithID(callSpawnUnit);
            AssetManager.powers.add(gnome);

            var buttongnome = NCMS.Utils.PowerButtons.CreateButton(
            "spawngnome",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.icongnomes.png"),
            "The Gnomes",
            "The Race of Gnomes",            
            new Vector2(108, -18),
            ButtonType.GodPower, 
            isekaiworldTab.transform, 
            null
            );

            var angel = new GodPower();
            angel.id = "spawnangel";
            angel.showSpawnEffect = true;
            angel.multiple_spawn_tip = true;
            angel.actorSpawnHeight = 3f;
            angel.name = "spawnangel";
            angel.spawnSound = "spawnelf";
            angel.actor_asset_id = "unit_angel";
            angel.click_action = new PowerActionWithID(callSpawnUnit);
            AssetManager.powers.add(angel);

            var buttonangel = NCMS.Utils.PowerButtons.CreateButton(
            "spawnangel",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.iconangels.png"),
            "The Angels",
            "The Holy Race of Angels",            
            new Vector2(144, 18),
            ButtonType.GodPower, 
            isekaiworldTab.transform, 
            null
            );

            var demonic = new GodPower();
            demonic.id = "spawndemonic";
            demonic.showSpawnEffect = true;
            demonic.multiple_spawn_tip = true;
            demonic.actorSpawnHeight = 3f;
            demonic.name = "spawndemonic";
            demonic.spawnSound = "spawnelf";
            demonic.actor_asset_id = "unit_demonic";
            demonic.click_action = new PowerActionWithID(callSpawnUnit);
            AssetManager.powers.add(demonic);

            var buttondemonic = NCMS.Utils.PowerButtons.CreateButton(
            "spawndemonic",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.icondemonics.png"),
            "The Demonics",
            "The Evil Race of Demonics",            
            new Vector2(144, -18),
            ButtonType.GodPower, 
            isekaiworldTab.transform, 
            null
            );

            var japaneses = new GodPower();
            japaneses.id = "spawnjapaneses";
            japaneses.showSpawnEffect = true;
            japaneses.multiple_spawn_tip = true;
            japaneses.actorSpawnHeight = 3f;
            japaneses.name = "spawnjapaneses";
            japaneses.spawnSound = "spawnelf";
            japaneses.actor_asset_id = "unit_japaneses";
            japaneses.click_action = new PowerActionWithID(callSpawnUnit);
            AssetManager.powers.add(japaneses);

            var buttonjapaneses = NCMS.Utils.PowerButtons.CreateButton(
            "spawnjapaneses",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.iconjapanflag.png"),
            "The Japan",
            "The Civilization Of The Japanese",     
            new Vector2(180, 18),
            ButtonType.GodPower, 
            isekaiworldTab.transform,
            null
            );

            var ancientchina = new GodPower();
            ancientchina.id = "spawnancientchina";
            ancientchina.showSpawnEffect = true;
            ancientchina.multiple_spawn_tip = true;
            ancientchina.actorSpawnHeight = 3f;
            ancientchina.name = "spawnancientchina";
            ancientchina.spawnSound = "spawnelf";
            ancientchina.actor_asset_id = "unit_ancientchina";
            ancientchina.click_action = new PowerActionWithID(callSpawnUnit);
            AssetManager.powers.add(ancientchina);

            var buttonancientchina = NCMS.Utils.PowerButtons.CreateButton(
            "spawnancientchina",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.iconancientchina.png"),
            "The Ancient China",
            "The Civilization Of The Ancient China",
            new Vector2(180, -18),
            ButtonType.GodPower, 
            isekaiworldTab.transform,
            null
            );

            #endregion
            
            //Creatures

            #region creatures

            var troll = new GodPower();
            troll.id = "spawntroll";
            troll.showSpawnEffect = true;
            troll.multiple_spawn_tip = true;
            troll.actorSpawnHeight = 3f;
            troll.name = "spawntroll";
            troll.spawnSound = "spawnelf";
            troll.actor_asset_id = "trolls";
            troll.click_action = new PowerActionWithID(callSpawnUnit);
            AssetManager.powers.add(troll);

            var buttontroll = NCMS.Utils.PowerButtons.CreateButton(
            "spawntroll",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.icontrolls.png"),
            "A Troll",
            "A Mythological Being",
            new Vector2(254, 18),
            ButtonType.GodPower, 
            isekaiworldTab.transform, 
            null
            );

            var griffin = new GodPower();
            griffin.id = "spawngriffin";
            griffin.showSpawnEffect = true;
            griffin.multiple_spawn_tip = true;
            griffin.actorSpawnHeight = 3f;
            griffin.name = "spawngriffin";
            griffin.spawnSound = "spawnelf";
            griffin.actor_asset_id = "griffins";
            griffin.click_action = new PowerActionWithID(callSpawnUnit);
            AssetManager.powers.add(griffin);

            var buttongriffin = NCMS.Utils.PowerButtons.CreateButton(
            "spawngriffin",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.icongriffins.png"),
            "A Griffin",
            "A Mighty Mythological Being",
            new Vector2(254, -18),
            ButtonType.GodPower, 
            isekaiworldTab.transform, 
            null
            );

            var darkknight = new GodPower();
            darkknight.id = "spawndarkknight";
            darkknight.showSpawnEffect = true;
            darkknight.multiple_spawn_tip = true;
            darkknight.actorSpawnHeight = 3f;
            darkknight.name = "spawndarkknight";
            darkknight.spawnSound = "spawnelf";
            darkknight.actor_asset_id = "darkknight";
            darkknight.click_action = new PowerActionWithID(callSpawnUnit);
            AssetManager.powers.add(darkknight);

            var buttondarkknight = NCMS.Utils.PowerButtons.CreateButton(
            "spawndarkknight",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.icondarkknight.png"),
            "A Dark Knight",
            "A Legendary Dark Knight",
            new Vector2(290, 18),
            ButtonType.GodPower, 
            isekaiworldTab.transform, 
            null
            );

            var phoenix = new GodPower();
            phoenix.id = "spawnphoenix";
            phoenix.showSpawnEffect = true;
            phoenix.multiple_spawn_tip = true;
            phoenix.actorSpawnHeight = 3f;
            phoenix.name = "spawnphoenix";
            phoenix.spawnSound = "spawnelf";
            phoenix.actor_asset_id = "phoenix";
            phoenix.click_action = new PowerActionWithID(callSpawnUnit);
            AssetManager.powers.add(phoenix);

            var buttonphoenix = NCMS.Utils.PowerButtons.CreateButton(
            "spawnphoenix",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.iconphoenix.png"),
            "A Phoenix",
            "A Mighty Phoenix",
            new Vector2(290, -18),
            ButtonType.GodPower, 
            isekaiworldTab.transform, 
            null
            );

            var witch = new GodPower();
            witch.id = "spawnwitch";
            witch.showSpawnEffect = true;
            witch.multiple_spawn_tip = true;
            witch.actorSpawnHeight = 3f;
            witch.name = "spawnwitch";
            witch.spawnSound = "spawnelf";
            witch.actor_asset_id = "witch";
            witch.click_action = new PowerActionWithID(callSpawnUnit);
            AssetManager.powers.add(witch);

            var buttonwitch = NCMS.Utils.PowerButtons.CreateButton(
            "spawnwitch",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.iconwitch.png"),
            "A Witch",
            "A Wicked Witch",
            new Vector2(326, 18),
            ButtonType.GodPower, 
            isekaiworldTab.transform, 
            null
            );

            var demonking = new GodPower();
            demonking.id = "spawndemonking";
            demonking.showSpawnEffect = true;
            demonking.multiple_spawn_tip = true;
            demonking.actorSpawnHeight = 3f;
            demonking.name = "spawndemonking";
            demonking.spawnSound = "spawnelf";
            demonking.actor_asset_id = "demonking";
            demonking.click_action = new PowerActionWithID(callSpawnUnit);
            AssetManager.powers.add(demonking);

            var buttondemonking = NCMS.Utils.PowerButtons.CreateButton(
            "spawndemonking",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.icondemonking.png"),
            "The Demon King",
            "The Mighty Demon King",
            new Vector2(326, -18),
            ButtonType.GodPower, 
            isekaiworldTab.transform, 
            null
            );

            #endregion

            //Gate

            #region gate

            var japan = new GodPower();
            japan.id = "spawnjapan";
            japan.showSpawnEffect = true;
            japan.multiple_spawn_tip = true;
            japan.actorSpawnHeight = 3f;
            japan.name = "spawnjapan";
            japan.spawnSound = "spawnelf";
            japan.actor_asset_id = "japansoldier";
            japan.click_action = new PowerActionWithID(callSpawnUnit);
            AssetManager.powers.add(japan);

            var buttonjapan = NCMS.Utils.PowerButtons.CreateButton(
            "spawnjapan",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.iconjapan.png"),
            "A Japanese Soldier",
            "Member of the Japan Self Defense Forces",
            new Vector2(362, 18),
            ButtonType.GodPower, 
            isekaiworldTab.transform, 
            null
            );

            var japan2 = new GodPower();
            japan2.id = "spawnjapan2";
            japan2.showSpawnEffect = true;
            japan2.multiple_spawn_tip = true;
            japan2.actorSpawnHeight = 3f;
            japan2.name = "spawnjapan2";
            japan2.spawnSound = "spawnelf";
            japan2.actor_asset_id = "japantank";
            japan2.click_action = new PowerActionWithID(callSpawnUnit);
            AssetManager.powers.add(japan2);

            var buttonjapan2 = NCMS.Utils.PowerButtons.CreateButton(
            "spawnjapan2",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.iconjapan2.png"),
            "A Japanese Tank",
            "A Japan Self Defense Forces Tank",
            new Vector2(400, 18),
            ButtonType.GodPower, 
            isekaiworldTab.transform, 
            null
            );

            var japan3 = new GodPower();
            japan3.id = "spawnjapan3";
            japan3.showSpawnEffect = true;
            japan3.multiple_spawn_tip = true;
            japan3.actorSpawnHeight = 3f;
            japan3.name = "spawnjapan3";
            japan3.spawnSound = "spawnelf";
            japan3.actor_asset_id = "japanhelicopter";
            japan3.click_action = new PowerActionWithID(callSpawnUnit);
            AssetManager.powers.add(japan3);

            var buttonjapan3 = NCMS.Utils.PowerButtons.CreateButton(
            "spawnjapan3",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.iconjapan3.png"),
            "A Japanese Helicopter",
            "A Japan Self Defense Forces Helicopter",
            new Vector2(400, -18),
            ButtonType.GodPower, 
            isekaiworldTab.transform, 
            null
            );

            var Gate = new GodPower();
            Gate.id = "spawnGate";
            Gate.name = "spawnGate";
            Gate.showSpawnEffect = true;
            Gate.multiple_spawn_tip = true;
            Gate.actorSpawnHeight = 3f;
            Gate.spawnSound = "spawnelf";
            Gate.actor_asset_id = "unit_japaneses";
            Gate.click_action = new PowerActionWithID(callSpawnUnit);
            AssetManager.powers.add(Gate);

            var buttonGate = NCMS.Utils.PowerButtons.CreateButton(
            "spawnGate",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.icongate.png"),
            "The Gate",
            "A Great Gate to the Other Side\n" + "~Temporarily unavailable~",
            new Vector2(362, -18),
            ButtonType.GodPower, 
            isekaiworldTab.transform, 
            null
            );

            #endregion

            #region Godzilla

            var Godzilla = new GodPower();
            Godzilla.id = "spawnGodzilla";
            Godzilla.actorSpawnHeight = 3f;
            Godzilla.name = "spawnGodzilla";
            Godzilla.spawnSound = "spawnelf";
            Godzilla.actor_asset_id = "Godzilla";
            Godzilla.showSpawnEffect = true;
            Godzilla.multiple_spawn_tip = true;
            Godzilla.click_action = new PowerActionWithID(callSpawnUnit);
            AssetManager.powers.add(Godzilla);

            var buttonGodzilla = NCMS.Utils.PowerButtons.CreateButton(
            "spawnGodzilla",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.iconGodzilla.png"),
            "Godzilla",
            "The Godzilla",
            new Vector2(436, 18),
            ButtonType.GodPower, 
            isekaiworldTab.transform, 
            null
            );

            #endregion

            #region DragonSlayer

            var DragonSlayer = new GodPower();
            DragonSlayer.id = "spawnDragonSlayer";
            DragonSlayer.actorSpawnHeight = 3f;
            DragonSlayer.name = "spawnDragonSlayer";
            DragonSlayer.spawnSound = "spawndragon";
            DragonSlayer.actor_asset_id = "DragonSlayer";
            DragonSlayer.showSpawnEffect = true;
            DragonSlayer.multiple_spawn_tip = true;
            DragonSlayer.click_action = new PowerActionWithID(callSpawnUnit);
            AssetManager.powers.add(DragonSlayer);

            var buttonDragonSlayer = NCMS.Utils.PowerButtons.CreateButton(
            "spawnDragonSlayer",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.iconDragonSlayer.png"),
            "DragonSlayer",
            "The Dragon Slayer",
            new Vector2(436, -18),
            ButtonType.GodPower, 
            isekaiworldTab.transform, 
            null
            );

            #endregion

        }
        public static bool callSpawnUnit(WorldTile pTile, string pPowerID)
        {
            AssetManager.powers.CallMethod("spawnUnit", pTile, pPowerID);
            return true;
        }
        private static PowersTab getPowersTab(string id)
		{
		GameObject gameObject = GameObjects.FindEvenInactive("Tab_" + id);
		return gameObject.GetComponent<PowersTab>();
        }
    }
}