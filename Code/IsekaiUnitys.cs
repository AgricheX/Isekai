using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using NCMS;
using NCMS.Utils;
using UnityEngine;
using ReflectionUtility;
using HarmonyLib;
using System.Reflection;

namespace Isekai
{
    class IsekaiUnitys
    {
      public static void init()
      {
        create_japansoldiers();
        create_trolls();
        create_griffins();
        create_darkknight();
        create_phoenix();
        create_witch();
        create_demonking();
        create_JapanHeliBoat();
        create_Godzilla();
        create_DragonSlayer();
        
      }

      public static void create_japansoldiers()
       {
        var japansoldier = AssetManager.actor_library.clone("japansoldier", "_mob");
        japansoldier.nameLocale = "JapanSoldier";
        japansoldier.nameTemplate = "japan_name";
        japansoldier.race = "Japan";
        japansoldier.kingdom = "Japan";
        japansoldier.zombieID = "zombie";
        japansoldier.animation_walk = "walk_0,walk_1,walk_2,walk_3";
        japansoldier.animation_swim = "swim_0,swim_1,swim_2,swim_3";
        japansoldier.texture_path = "japansoldier";
        japansoldier.icon = "iconjapansoldier";
        japansoldier.job = "move_mob";
        japansoldier.defaultWeapons = List.Of<string>(new string[]
		    {
         "HowaType89",
         "HowaType64",
         "HowaType20",
         "HowaType62",
         "HowaType64SniperRifle"
		    });
        japansoldier.defaultWeaponsMaterial = List.Of<string>(new string[]
		    {
		     "wood"
		    });
        japansoldier.base_stats[S.max_age] = 84;
        japansoldier.base_stats[S.attack_speed] = 70f;
        japansoldier.base_stats[S.accuracy] = 100f;
        japansoldier.base_stats[S.health] = 200;
        japansoldier.base_stats[S.speed] = 40f;
        japansoldier.base_stats[S.damage] = 43;
        japansoldier.base_stats[S.dodge] = 30f;
        japansoldier.canBeKilledByDivineLight = false;
        japansoldier.canBeKilledByLifeEraser = true;
        japansoldier.ignoredByInfinityCoin = false;
        japansoldier.disableJumpAnimation = true;
        japansoldier.canBeMovedByPowers = true;
        japansoldier.canTurnIntoZombie = true;
        japansoldier.canAttackBuildings = true;
        japansoldier.hideFavoriteIcon = false;
        japansoldier.can_edit_traits = true;
        japansoldier.very_high_flyer = false;
        japansoldier.damagedByOcean = false;
        japansoldier.swampCreature = false;
        japansoldier.damagedByRain = false;
        japansoldier.oceanCreature = false;
        japansoldier.action_liquid = new WorldAction(ActionLibrary.swimToIsland);
        japansoldier.landCreature = true;
        japansoldier.dieOnGround = false;
        japansoldier.take_items = false;
        japansoldier.use_items = true;
        japansoldier.diet_meat = false;
        japansoldier.has_soul = true;
		    japansoldier.dieInLava = true;
        japansoldier.needFood = false;
        japansoldier.flying = false;
        AssetManager.actor_library.add(japansoldier);
        AssetManager.actor_library.CallMethod("loadShadow", japansoldier);
        AssetManager.actor_library.CallMethod("addTrait", "veteran");
        Localization.addLocalization(japansoldier.nameLocale, japansoldier.nameLocale);

        var japantank = AssetManager.actor_library.clone("japantank", "_mob");
        japantank.nameLocale = "JapanTank";
        japantank.nameTemplate = "japan_clan";
        japantank.race = "Japan";
        japantank.kingdom = "Japan";
        japantank.defaultAttack = "Bazooka";
        japantank.animation_walk = "walk_0,walk_1,walk_2,walk_3";
        japantank.animation_swim = "swim_0,swim_1";
        japantank.texture_path = "japantank";
        japantank.icon = "iconjapantank";
        japantank.job = "move_mob";
        japantank.base_stats[S.max_age] = 100;
        japantank.base_stats[S.attack_speed] = 60f;
        japantank.base_stats[S.accuracy] = 100f;
        japantank.base_stats[S.health] = 3000;
        japantank.base_stats[S.speed] = 60f;
        japantank.base_stats[S.damage] = 200;
        japantank.base_stats[S.knockback_reduction] = 1000f;
        japantank.canBeKilledByDivineLight = false;
        japantank.canBeKilledByLifeEraser = true;
        japantank.ignoredByInfinityCoin = false;
        japantank.disableJumpAnimation = true;
        japantank.canBeMovedByPowers = true;
        japantank.canTurnIntoZombie = false;
        japantank.canTurnIntoMush = false;
        japantank.canTurnIntoTumorMonster = false;
        japantank.canAttackBuildings = true;
        japantank.hideFavoriteIcon = false;
        japantank.can_edit_traits = true;
        japantank.very_high_flyer = false;
        japantank.damagedByOcean = true;
        japantank.swampCreature = false;
        japantank.damagedByRain = false;
        japantank.oceanCreature = false;
        japantank.action_liquid = new WorldAction(ActionLibrary.swimToIsland);
        japantank.landCreature = true;
        japantank.dieOnGround = false;
        japantank.take_items = false;
        japantank.use_items = false;
        japantank.diet_meat = false;
        japantank.has_soul = false;
		    japantank.dieInLava = true;
        japantank.needFood = false;
        japantank.flying = false;
        AssetManager.actor_library.CallMethod("loadShadow", japantank);
        AssetManager.actor_library.CallMethod("addTrait", "veteran");
        Localization.addLocalization(japantank.nameLocale, japantank.nameLocale);

        var japanhelicopter = AssetManager.actor_library.clone("japanhelicopter", "_mob");
        japanhelicopter.nameLocale = "JapanHelicopter";
        japanhelicopter.nameTemplate = "japan_clan";
        japanhelicopter.race = "Japan";
        japanhelicopter.kingdom = "Japan";
        japanhelicopter.defaultAttack = "HowaType89";
        japanhelicopter.animation_walk = "walk_0,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2,walk_1,walk_2";
        japanhelicopter.animation_swim = "walk_1,walk_2";
        japanhelicopter.texture_path = "japanhelicopter";
        japanhelicopter.icon = "iconjapanhelicopter";
        japanhelicopter.job = "move_mob";
        japanhelicopter.base_stats[S.max_age] = 100;
        japanhelicopter.base_stats[S.attack_speed] = 100f;
        japanhelicopter.base_stats[S.accuracy] = 100f;
        japanhelicopter.base_stats[S.health] = 1000;
        japanhelicopter.base_stats[S.speed] = 100f;
        japanhelicopter.base_stats[S.damage] = 93;
        japanhelicopter.base_stats[S.knockback_reduction] = 500f;
        japanhelicopter.flying = false;
        japanhelicopter.very_high_flyer = true;
        japanhelicopter.canBeKilledByDivineLight = false;
        japanhelicopter.canBeKilledByLifeEraser = true;
        japanhelicopter.ignoredByInfinityCoin = false;
        japanhelicopter.disableJumpAnimation = true;
        japanhelicopter.canBeMovedByPowers = true;
        japanhelicopter.canTurnIntoZombie = false;
        japanhelicopter.canTurnIntoMush = false;
        japanhelicopter.canTurnIntoTumorMonster = false;
        japanhelicopter.canAttackBuildings = true;
        japanhelicopter.hideFavoriteIcon = false;
        japanhelicopter.can_edit_traits = true;
        japanhelicopter.damagedByOcean = false;
        japanhelicopter.swampCreature = true;
        japanhelicopter.damagedByRain = false;
        japanhelicopter.oceanCreature = true;
        japanhelicopter.action_liquid = new WorldAction(ActionLibrary.swimToIsland);
        japanhelicopter.landCreature = true;
        japanhelicopter.dieOnGround = false;
        japanhelicopter.take_items = false;
        japanhelicopter.use_items = false;
        japanhelicopter.diet_meat = false;
        japanhelicopter.has_soul = false;
		    japanhelicopter.dieInLava = true;
        japanhelicopter.needFood = false;
        AssetManager.actor_library.CallMethod("loadShadow", japanhelicopter);
        AssetManager.actor_library.CallMethod("addTrait", "veteran");
        Localization.addLocalization(japanhelicopter.nameLocale, japanhelicopter.nameLocale);
        }

        //Magic Creatures

        public static void create_trolls()
        {
        var trolls = AssetManager.actor_library.clone("trolls", "_mob");
        trolls.nameLocale = "Trolls";
        trolls.nameTemplate = "trolls_name";
        trolls.race = "Troll";
        trolls.kingdom = "Troll";
        trolls.animation_walk = "walk_0,walk_1,walk_2,walk_3";
        trolls.animation_swim = "swim_0,swim_1,swim_2,swim_3";
        trolls.texture_path = "trolls";
        trolls.icon = "icontrolls";
        trolls.job = "move_mob";
        trolls.base_stats[S.max_age] = 1000;
        trolls.base_stats[S.attack_speed] = 50f;
        trolls.base_stats[S.health] = 500;
        trolls.base_stats[S.speed] = 40f;
        trolls.base_stats[S.damage] = 70;
        trolls.animal = true;
        trolls.canBeKilledByDivineLight = false;
        trolls.canBeKilledByLifeEraser = true;
        trolls.ignoredByInfinityCoin = false;
        trolls.disableJumpAnimation = true;
        trolls.canBeMovedByPowers = true;
        trolls.disableJumpAnimation = true;
        trolls.canTurnIntoZombie = false;
        trolls.canTurnIntoMush = false;
        trolls.canTurnIntoTumorMonster = false;
        trolls.canAttackBuildings = true;
        trolls.hideFavoriteIcon = false;
        trolls.can_edit_traits = true;
        trolls.very_high_flyer = false;
        trolls.damagedByOcean = false;
        trolls.swampCreature = false;
        trolls.damagedByRain = false;
        trolls.oceanCreature = false;
        trolls.action_liquid = new WorldAction(ActionLibrary.swimToIsland);
        trolls.landCreature = true;
        trolls.dieOnGround = false;
        trolls.take_items = false;
        trolls.use_items = false;
        trolls.diet_meat = false;
        trolls.has_soul = true;
		    trolls.dieInLava = true;
        trolls.needFood = false;
        trolls.flying = false;
        AssetManager.actor_library.add(trolls);
        AssetManager.actor_library.CallMethod("loadShadow", trolls);
        AssetManager.actor_library.CallMethod("addTrait", "savage");
        Localization.addLocalization(trolls.nameLocale, trolls.nameLocale);
        }

        public static void create_griffins()
        {
        var griffins = AssetManager.actor_library.clone("griffins", "_mob");
        griffins.nameLocale = "Griffins";
        griffins.nameTemplate = "griffins_name";
        griffins.race = "Griffin";
        griffins.kingdom = "Griffin";
        griffins.animation_walk = "walk_0,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3";
        griffins.animation_swim = "swim_0,swim_1,swim_2,swim_3";
        griffins.texture_path = "griffins";
        griffins.icon = "icongriffins";
        griffins.job = "move_mob";
        griffins.attack_spells = List.Of<string>(new string[]
		    {
        "bloodRain",
        "bloodRain",
			  "bloodRain"
		    });
        griffins.base_stats[S.max_age] = 5000;
        griffins.base_stats[S.attack_speed] = 100f;
        griffins.base_stats[S.health] = 1000;
        griffins.base_stats[S.speed] = 60f;
        griffins.base_stats[S.damage] = 100;
        griffins.animal = true;
        griffins.canBeKilledByDivineLight = false;
        griffins.canBeKilledByLifeEraser = true;
        griffins.ignoredByInfinityCoin = false;
        griffins.disableJumpAnimation = true;
        griffins.canBeMovedByPowers = true;
        griffins.canTurnIntoZombie = false;
        griffins.canTurnIntoMush = false;
        griffins.canTurnIntoTumorMonster = false;
        griffins.canAttackBuildings = true;
        griffins.hideFavoriteIcon = false;
        griffins.can_edit_traits = true;
        griffins.very_high_flyer = false;
        griffins.damagedByOcean = false;
        griffins.swampCreature = false;
        griffins.damagedByRain = false;
        griffins.oceanCreature = true;
        griffins.action_liquid = new WorldAction(ActionLibrary.swimToIsland);
        griffins.landCreature = true;
        griffins.dieOnGround = false;
        griffins.take_items = false;
        griffins.use_items = false;
        griffins.diet_meat = false;
        griffins.has_soul = true;
		    griffins.dieInLava = true;
        griffins.needFood = false;
        griffins.flying = false;
        AssetManager.actor_library.add(griffins);
        AssetManager.actor_library.CallMethod("loadShadow", griffins);
        Localization.addLocalization(griffins.nameLocale, griffins.nameLocale);
        }

        public static void create_darkknight()
        {
        var darkknight = AssetManager.actor_library.clone("darkknight", "_mob");
        darkknight.nameLocale = "Dark Knight";
        darkknight.nameTemplate = "darkknight_name";
        darkknight.race = "DarkKnight";
        darkknight.kingdom = "DarkKnight";
        darkknight.animation_walk = "walk_0,walk_1,walk_2,walk_3";
        darkknight.animation_swim = "swim_0,swim_1,swim_2";
        darkknight.texture_path = "darkknight";
        darkknight.icon = "icondarkknight";
        darkknight.job = "move_mob";
        darkknight.attack_spells = List.Of<string>(new string[]
		    {
			  "bloodRain",
        "shield"
		    });
        darkknight.defaultAttack = "Katana";
        darkknight.base_stats[S.max_age] = 500;
        darkknight.base_stats[S.attack_speed] = 70f;
        darkknight.base_stats[S.health] = 700;
        darkknight.base_stats[S.speed] = 150f;
        darkknight.base_stats[S.damage] = 80;
        darkknight.canBeKilledByDivineLight = false;
        darkknight.canBeKilledByLifeEraser = true;
        darkknight.ignoredByInfinityCoin = false;
        darkknight.disableJumpAnimation = true;
        darkknight.canBeMovedByPowers = true;
        darkknight.disableJumpAnimation = true;
        darkknight.canTurnIntoZombie = false;
        darkknight.canTurnIntoMush = false;
        darkknight.canTurnIntoTumorMonster = false;
        darkknight.canAttackBuildings = true;
        darkknight.hideFavoriteIcon = false;
        darkknight.can_edit_traits = true;
        darkknight.very_high_flyer = false;
        darkknight.damagedByOcean = false;
        darkknight.swampCreature = false;
        darkknight.damagedByRain = false;
        darkknight.oceanCreature = false;
        darkknight.action_liquid = new WorldAction(ActionLibrary.swimToIsland);
        darkknight.landCreature = true;
        darkknight.dieOnGround = false;
        darkknight.take_items = false;
        darkknight.use_items = false;
        darkknight.diet_meat = false;
        darkknight.has_soul = true;
		    darkknight.dieInLava = true;
        darkknight.needFood = false;
        darkknight.flying = false;
        AssetManager.actor_library.add(darkknight);
        AssetManager.actor_library.CallMethod("loadShadow", darkknight);
        AssetManager.actor_library.CallMethod("addTrait", "evil");
        Localization.addLocalization(darkknight.nameLocale, darkknight.nameLocale);
        }

        public static void create_phoenix()
        {
        var phoenix = AssetManager.actor_library.clone("phoenix", "_mob");
        phoenix.nameLocale = "Phoenixes";
        phoenix.nameTemplate = "phoenix_name";
        phoenix.race = "Phoenix";
        phoenix.kingdom = "Phoenix";
        phoenix.animation_walk = "walk_0,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3,walk_1,walk_2,walk_3";
        phoenix.animation_swim = "swim_0,swim_1,swim_2,swim_3";
        phoenix.texture_path = "phoenix";
        phoenix.icon = "iconphoenix";
        phoenix.job = "move_mob";
        phoenix.attack_spells = List.Of<string>(new string[]
		    {
        "fire",
			  "bloodRain"
		    });
        phoenix.effect_cast_ground = "fx_cast_ground_red";
        phoenix.base_stats[S.max_age] = 5000;
        phoenix.base_stats[S.attack_speed] = 100f;
        phoenix.base_stats[S.health] = 1000;
        phoenix.base_stats[S.speed] = 60f;
        phoenix.base_stats[S.damage] = 100;
        phoenix.animal = true;
        phoenix.canBeKilledByDivineLight = false;
        phoenix.canBeKilledByLifeEraser = true;
        phoenix.ignoredByInfinityCoin = false;
        phoenix.disableJumpAnimation = true;
        phoenix.canBeMovedByPowers = true;
        phoenix.canTurnIntoZombie = false;
        phoenix.canTurnIntoMush = false;
        phoenix.canTurnIntoTumorMonster = false;
        phoenix.canAttackBuildings = true;
        phoenix.hideFavoriteIcon = false;
        phoenix.can_edit_traits = true;
        phoenix.very_high_flyer = false;
        phoenix.damagedByOcean = false;
        phoenix.swampCreature = false;
        phoenix.damagedByRain = false;
        phoenix.oceanCreature = true;
        phoenix.action_liquid = new WorldAction(ActionLibrary.swimToIsland);
        phoenix.landCreature = true;
        phoenix.dieOnGround = false;
        phoenix.take_items = false;
        phoenix.use_items = false;
        phoenix.diet_meat = false;
        phoenix.has_soul = true;
		    phoenix.dieInLava = true;
        phoenix.needFood = false;
        phoenix.flying = false;
        AssetManager.actor_library.add(phoenix);
        AssetManager.actor_library.CallMethod("loadShadow", phoenix);
        AssetManager.actor_library.CallMethod("addTrait", "fire_blood");
        AssetManager.actor_library.CallMethod("addTrait", "fire_proof");
        Localization.addLocalization(phoenix.nameLocale, phoenix.nameLocale);
        }

        public static void create_witch()
        {
        var witch = AssetManager.actor_library.clone("witch", "_mob");
        witch.nameLocale = "Witches";
        witch.nameTemplate = "witch_name";
        witch.race = "Witch";
        witch.kingdom = "undead";
        witch.zombieID = "zombie";
        witch.skeletonID = "skeleton_cursed";
        witch.attack_spells = List.Of<string>(new string[]
		    {
        "curse",
        "spawnSkeleton",
			  "bloodRain",
        "shield"
		    });
        witch.effect_cast_top = "fx_cast_top_green";
		    witch.effect_cast_ground = "fx_cast_ground_green";
        witch.defaultAttack = "necromancer_staff";
        witch.animation_walk = "walk_0,walk_1,walk_2,walk_3,walk_4,walk_1,walk_2,walk_3,walk_4,walk_1,walk_2,walk_3,walk_4,walk_1,walk_2,walk_3,walk_4,walk_1,walk_2,walk_3,walk_4,walk_1,walk_2,walk_3,walk_4,walk_1,walk_2,walk_3,walk_4,walk_1,walk_2,walk_3,walk_4,walk_1,walk_2,walk_3,walk_4,walk_1,walk_2,walk_3,walk_4,walk_1,walk_2,walk_3,walk_4,walk_1,walk_2,walk_3,walk_4,walk_1,walk_2,walk_3,walk_4,walk_1,walk_2,walk_3,walk_4,walk_1,walk_2,walk_3,walk_4,walk_1,walk_2,walk_3,walk_4,walk_1,walk_2,walk_3,walk_4,walk_1,walk_2,walk_3,walk_4,walk_1,walk_2,walk_3,walk_4,walk_1,walk_2,walk_3,walk_4";
        witch.animation_swim = "walk_1,walk_2,walk_3";
        witch.texture_path = "witch";
        witch.icon = "iconwitch";
        witch.job = "necromancer";
        witch.color = Toolbox.makeColor("#EE3A42", -1f);
        witch.base_stats[S.max_age] = 1000;
        witch.base_stats[S.attack_speed] = 100f;
        witch.base_stats[S.health] = 1000;
        witch.base_stats[S.speed] = 100f;
        witch.base_stats[S.damage] = 80;
        witch.canBeKilledByDivineLight = false;
        witch.canBeKilledByLifeEraser = true;
        witch.ignoredByInfinityCoin = false;
        witch.disableJumpAnimation = true;
        witch.canBeMovedByPowers = true;
        witch.canAttackBuildings = true;
        witch.canTurnIntoZombie = true;
        witch.hideFavoriteIcon = false;
        witch.can_edit_traits = true;
        witch.very_high_flyer = true;
        witch.damagedByOcean = false;
        witch.swampCreature = false;
        witch.damagedByRain = false;
        witch.oceanCreature = true;
        witch.action_liquid = new WorldAction(ActionLibrary.swimToIsland);
        witch.landCreature = true;
        witch.dieOnGround = false;
        witch.take_items = false;
        witch.use_items = false;
        witch.diet_meat = false;
        witch.has_soul = true;
		    witch.dieInLava = true;
        witch.needFood = false;
        witch.flying = false;
        witch.disableJumpAnimation = true;
        AssetManager.actor_library.add(witch);
        AssetManager.actor_library.CallMethod("loadShadow", witch);
        AssetManager.actor_library.CallMethod("addTrait", "immortal"); 
        AssetManager.actor_library.CallMethod("addTrait", "regeneration"); 
        AssetManager.actor_library.CallMethod("addTrait", "evil"); 
        AssetManager.actor_library.CallMethod("addTrait", "poison_immune");
        AssetManager.actor_library.CallMethod("addTrait", "WitchPowers"); 
        Localization.addLocalization(witch.nameLocale, witch.nameLocale);
        }

        public static void create_demonking()
        {
        var demonking = AssetManager.actor_library.clone("demonking", "_mob");
        demonking.nameLocale = "DemonKing";
        demonking.nameTemplate = "demon_name";
        demonking.race = "demon";
        demonking.kingdom = "demons";
        demonking.skeletonID = "skeleton_cursed";
        demonking.attack_spells = List.Of<string>(new string[]
		    {
        "teleportRandom",
        "lightning",
        "fire",
			  "bloodRain",
        "shield"
		    });
        demonking.effect_cast_top = "fx_cast_top_red";
		    demonking.effect_cast_ground = "fx_cast_ground_red";
        demonking.defaultAttack = "evil_staff";
        demonking.animation_walk = "walk_0,walk_1,walk_2,walk_3";
        demonking.animation_swim = "swim_0,swim_1";
        demonking.texture_path = "demonking";
        demonking.icon = "icondemonking";
        demonking.job = "move_mob";
        demonking.color = Toolbox.makeColor("#EE3A42", -1f);
        demonking.base_stats[S.max_age] = 2000;
        demonking.base_stats[S.attack_speed] = 100f;
        demonking.base_stats[S.health] = 5000;
        demonking.base_stats[S.speed] = 80f;
        demonking.base_stats[S.damage] = 200;
        demonking.canBeKilledByDivineLight = true;
        demonking.canBeKilledByLifeEraser = true;
        demonking.ignoredByInfinityCoin = false;
        demonking.disableJumpAnimation = true;
        demonking.canBeMovedByPowers = true;
        demonking.canAttackBuildings = true;
        demonking.canTurnIntoZombie = false;
        demonking.canTurnIntoMush = false;
        demonking.canTurnIntoTumorMonster = false;
        demonking.hideFavoriteIcon = false;
        demonking.can_edit_traits = true;
        demonking.very_high_flyer = false;
        demonking.damagedByOcean = true;
        demonking.swampCreature = false;
        demonking.damagedByRain = true;
        demonking.oceanCreature = false;
        demonking.action_liquid = new WorldAction(ActionLibrary.swimToIsland);
        demonking.landCreature = true;
        demonking.dieOnGround = false;
        demonking.take_items = false;
        demonking.use_items = false;
        demonking.diet_meat = false;
        demonking.has_soul = true;
		    demonking.dieInLava = false;
        demonking.needFood = false;
        demonking.flying = false;
        demonking.disableJumpAnimation = true;
        AssetManager.actor_library.add(demonking);
        AssetManager.actor_library.CallMethod("loadShadow", demonking);
        AssetManager.actor_library.CallMethod("addTrait", "immortal"); 
        AssetManager.actor_library.CallMethod("addTrait", "regeneration"); 
        AssetManager.actor_library.CallMethod("addTrait", "burning_feet"); 
        AssetManager.actor_library.CallMethod("addTrait", "fire_blood"); 
        AssetManager.actor_library.CallMethod("addTrait", "fire_proof"); 
        AssetManager.actor_library.CallMethod("addTrait", "evil");
        AssetManager.actor_library.CallMethod("addTrait", "mega_heartbeat"); 
        AssetManager.actor_library.CallMethod("addTrait", "DemonKingPowers"); 
        Localization.addLocalization(demonking.nameLocale, demonking.nameLocale);
        }

      public static void create_Godzilla(){
      var Godzilla = AssetManager.actor_library.clone("Godzilla", "_mob");
      Godzilla.nameLocale = "Godzilla";
      Godzilla.nameTemplate = "Godzilla_name";
      Godzilla.race = "GodzillaRace";
      Godzilla.kingdom = "GodzillaRace";
      Godzilla.base_stats[S.max_age] = 10000000;
      Godzilla.base_stats[S.knockback_reduction] = 1000f;
      Godzilla.base_stats[S.critical_chance] = 999f;
      Godzilla.base_stats[S.attack_speed] = 60f;
      Godzilla.base_stats[S.health] = 50000;
      Godzilla.base_stats[S.speed] = 50f;
      Godzilla.base_stats[S.damage] = 1000;
      Godzilla.base_stats[S.targets] = 100;
      Godzilla.base_stats[S.range] = 18f;
      Godzilla.base_stats[S.dodge] = -100f;
      Godzilla.base_stats[S.armor] = 1000;
      Godzilla.canBeKilledByDivineLight = false;
      Godzilla.canBeKilledByLifeEraser = true;
      Godzilla.ignoredByInfinityCoin = false;
      Godzilla.disableJumpAnimation = true;
      Godzilla.canBeMovedByPowers = true;
      Godzilla.canTurnIntoZombie = false;
      Godzilla.canAttackBuildings = true;
      Godzilla.hideFavoriteIcon = true;
      Godzilla.can_edit_traits = true;
      Godzilla.very_high_flyer = false;
      Godzilla.damagedByOcean = false;
      Godzilla.damagedByRain = false;
      Godzilla.swampCreature = true;
      Godzilla.oceanCreature = true;
      Godzilla.landCreature = true;
      Godzilla.dieOnGround = false;
      Godzilla.take_items = false;
      Godzilla.use_items = false;
      Godzilla.diet_meat = false;
      Godzilla.has_soul = true;
		  Godzilla.dieInLava = false;
      Godzilla.needFood = false;
      Godzilla.flying = false;
      Godzilla.hideOnMinimap = false;
      Godzilla.action_liquid = new WorldAction(ActionLibrary.swimToIsland);
      Godzilla.actorSize = ActorSize.S17_Dragon;
      Godzilla.animation_walk = "walk_0,walk_1,walk_2,walk_3";
      Godzilla.animation_swim = "swim_0,swim_1";
      Godzilla.texture_path = "Godzilla";
      Godzilla.icon = "iconGodzilla";
      Godzilla.job = "attacker";
      AssetManager.actor_library.add(Godzilla);
      AssetManager.actor_library.CallMethod("loadShadow", Godzilla);
      AssetManager.actor_library.CallMethod("addTrait", "Godzilla Power");
      AssetManager.actor_library.CallMethod("addTrait", "immortal");
      AssetManager.actor_library.CallMethod("addTrait", "fire_proof");
      AssetManager.actor_library.CallMethod("addTrait", "freeze_proof");
      AssetManager.actor_library.CallMethod("addTrait", "poison_immune");
      AssetManager.actor_library.CallMethod("addTrait", "acid_proof");
      Localization.addLocalization(Godzilla.nameLocale, Godzilla.nameLocale);
      }

      public static void create_DragonSlayer(){
      var DragonSlayer = AssetManager.actor_library.clone("DragonSlayer", "_mob");
      DragonSlayer.nameLocale = "DragonSlayer";
      DragonSlayer.nameTemplate = "dragonslayer_name";
      DragonSlayer.race = "DragonSlayerRace";
      DragonSlayer.kingdom = "DragonSlayerRace";
      DragonSlayer.base_stats[S.max_age] = 1000;
      DragonSlayer.base_stats[S.knockback_reduction] = 10f;
      DragonSlayer.base_stats[S.critical_chance] = 100f;
      DragonSlayer.base_stats[S.attack_speed] = 70f;
      DragonSlayer.base_stats[S.knockback] = 0f;
      DragonSlayer.base_stats[S.accuracy] = 70f;
      DragonSlayer.base_stats[S.health] = 5000;
      DragonSlayer.base_stats[S.speed] = 120f;
      DragonSlayer.base_stats[S.damage] = 100;
      DragonSlayer.base_stats[S.targets] = 1;
      DragonSlayer.base_stats[S.dodge] = 100f;
      DragonSlayer.base_stats[S.armor] = 50;
      DragonSlayer.canBeKilledByDivineLight = false;
      DragonSlayer.canBeKilledByLifeEraser = true;
      DragonSlayer.ignoredByInfinityCoin = false;
      DragonSlayer.disableJumpAnimation = true;
      DragonSlayer.canBeMovedByPowers = true;
      DragonSlayer.canTurnIntoZombie = false;
      DragonSlayer.canAttackBuildings = true;
      DragonSlayer.hideFavoriteIcon = false;
      DragonSlayer.can_edit_traits = true;
      DragonSlayer.very_high_flyer = false;
      DragonSlayer.damagedByOcean = false;
      DragonSlayer.swampCreature = false;
      DragonSlayer.damagedByRain = false;
      DragonSlayer.oceanCreature = false;
      DragonSlayer.landCreature = true;
      DragonSlayer.dieOnGround = false;
      DragonSlayer.take_items = false;
      DragonSlayer.use_items = true;
      DragonSlayer.diet_meat = false;
		  DragonSlayer.dieInLava = false;
      DragonSlayer.needFood = false;
      DragonSlayer.has_soul = true;
      DragonSlayer.flying = false;
      DragonSlayer.action_liquid = new WorldAction(ActionLibrary.swimToIsland);
      DragonSlayer.defaultWeapons = List.Of<string>(new string[]{  "DragonSlayerBow", "DragonSlayerSword", "DragonSlayerSpear"  });
	    DragonSlayer.defaultWeaponsMaterial = List.Of<string>(new string[] { "adamantine" });
      DragonSlayer.animation_walk = "walk_0,walk_1,walk_2,walk_3";
      DragonSlayer.animation_swim = "swim_0,swim_1";
      DragonSlayer.texture_path = "DragonSlayer";
      DragonSlayer.icon = "iconDragonSlayer";
      DragonSlayer.job = "attacker";
      AssetManager.actor_library.add(DragonSlayer);
      AssetManager.actor_library.CallMethod("loadShadow", DragonSlayer);
      AssetManager.actor_library.CallMethod("addTrait", "dragonslayer");
      AssetManager.actor_library.CallMethod("addTrait", "immortal");
      AssetManager.actor_library.CallMethod("addTrait", "fire_proof");
      Localization.addLocalization(DragonSlayer.nameLocale, DragonSlayer.nameLocale);
      }

        public static void create_JapanHeliBoat(){
        var JapanHeliBoat = AssetManager.actor_library.clone("JapanHeliBoat", "_boat");
        JapanHeliBoat.nameLocale = "JapanHeliBoat";
		    JapanHeliBoat.race = "boat";
        JapanHeliBoat.kingdom = "neutral_animals";
        JapanHeliBoat.prefab = "p_boat";
        JapanHeliBoat.job = "attacker";
		    JapanHeliBoat.tech = "boats_transport";
        JapanHeliBoat.sound_hit = "event:/SFX/HIT/HitWood";
        JapanHeliBoat.fmod_spawn = "event:/SFX/UNITS/UNIQUE/BoatTransport/BoatTransportSpawn";
		    JapanHeliBoat.fmod_idle_loop = "event:/SFX/UNITS/UNIQUE/BoatTransport/BoatTransportIdleLoop";
		    JapanHeliBoat.fmod_death = "event:/SFX/UNITS/UNIQUE/BoatTransport/BoatTransportDeath";
        JapanHeliBoat.defaultAttack = "Bazooka";
        JapanHeliBoat.color = Toolbox.makeColor("#000000", -1f);
        JapanHeliBoat.base_stats[S.scale] = 0.25f;
		    JapanHeliBoat.base_stats[S.knockback_reduction] = 1f;
        JapanHeliBoat.base_stats[S.speed] = 120f;
        JapanHeliBoat.base_stats[S.health] = 3000;
        JapanHeliBoat.base_stats[S.armor] = 60f;
        JapanHeliBoat.base_stats[S.accuracy] = 100f;
        JapanHeliBoat.base_stats[S.damage] = 200;
        JapanHeliBoat.base_stats[S.attack_speed] = 60f;
        JapanHeliBoat.path_movement_timeout = 0.1f;
        JapanHeliBoat.inspectAvatarScale = 1f;
        JapanHeliBoat.cost = new ConstructionCost(5, 0, 2, 20);
        JapanHeliBoat.texture_atlas = UnitTextureAtlasID.Boats;
        JapanHeliBoat.allowed_status_tiers = StatusTier.Basic;
        JapanHeliBoat.actorSize = ActorSize.S17_Dragon;
		    JapanHeliBoat.canBeKilledByStuff = true;
		    JapanHeliBoat.canBeKilledByLifeEraser = true;
		    JapanHeliBoat.canAttackBuildings = true;
		    JapanHeliBoat.canBeMovedByPowers = true;
		    JapanHeliBoat.canBeHurtByPowers = true;
		    JapanHeliBoat.updateZ = true;
		    JapanHeliBoat.effectDamage = true;
	      JapanHeliBoat.dieOnGround = true;
	      JapanHeliBoat.oceanCreature = true;
		    JapanHeliBoat.shadow = false;
		    JapanHeliBoat.isBoat = true;
		    JapanHeliBoat.canBeInspected = true;
		    JapanHeliBoat.hideOnMinimap = true;
		    JapanHeliBoat.inspect_stats = false;
	      JapanHeliBoat.inspect_children = false;
	      JapanHeliBoat.inspect_home = false;
		    JapanHeliBoat.specialAnimation = true;
	      JapanHeliBoat.immune_to_injuries = true;
	      JapanHeliBoat.render_status_effects = false;
	      JapanHeliBoat.drawBoatMark = true;
		    JapanHeliBoat.drawBoatMark_big = true;
        JapanHeliBoat.landCreature = true;
        JapanHeliBoat.can_edit_traits = true;
        JapanHeliBoat.inspect_experience = true;
        JapanHeliBoat.inspect_kills = true;
        JapanHeliBoat.skipFightLogic = false;
        JapanHeliBoat.get_override_sprite = delegate(Actor pActor)
		    {
			  Boat component = pActor.GetComponent<Boat>();
			  AnimationDataBoat animationDataBoat = ActorAnimationLoader.loadAnimationBoat("boat_japanese_heli");
			  ActorAnimation actorAnimation = animationDataBoat.normal;
			  if (!pActor.data.alive)
			  {
				 actorAnimation = animationDataBoat.broken;
			  }
			  else if (pActor.zPosition.y != 0f || pActor.isInMagnet())
			  {
				 actorAnimation = animationDataBoat.normal;
			  }
		  	else
			  {
				 animationDataBoat.dict.TryGetValue(component.last_movement_angle, out actorAnimation);
				 if (actorAnimation == null)
				 {
					 int closestAngle = Toolbox.getClosestAngle(component.last_movement_angle, animationDataBoat);
				  	animationDataBoat.dict.TryGetValue(closestAngle, out actorAnimation);
				 }
			 }
			 if (actorAnimation == null)
			 {
			  	actorAnimation = animationDataBoat.normal;
			 }
			 Sprite sprite = actorAnimation.frames[0];
			 if (actorAnimation.frames.Length != 0)
			 {
				 sprite = AnimationHelper.getSpriteFromList(0, actorAnimation.frames, pActor.asset.animation_swim_speed);
			 }
			 AnimationFrameData pFrameData = null;
			 Sprite pMainSprite = sprite;
			 Kingdom kingdom = pActor.kingdom;
			 Sprite spriteUnit = UnitSpriteConstructor.getSpriteUnit(pFrameData, pMainSprite, pActor, (kingdom != null) ? kingdom.kingdomColor : null, pActor.race, pActor.data.skin_set, pActor.data.skin, pActor.asset.texture_atlas);
			 if (spriteUnit == null)
			 {
				return null;
			 }
			 return spriteUnit;
		  };
      AssetManager.actor_library.add(JapanHeliBoat);
      AssetManager.actor_library.CallMethod("loadShadow", JapanHeliBoat);
      AssetManager.actor_library.CallMethod("addTrait", "immortal");
      Localization.addLocalization(JapanHeliBoat.nameLocale, JapanHeliBoat.nameLocale);

        //Kingdoms

         KingdomAsset TrollKingdom = new KingdomAsset();
         TrollKingdom.id = "Troll";
         TrollKingdom.mobs = true;
         TrollKingdom.addTag("Troll");
         TrollKingdom.addFriendlyTag("Troll");
         TrollKingdom.addEnemyTag("civ");
         AssetManager.kingdoms.add(TrollKingdom);
         MapBox.instance.kingdoms.CallMethod("newHiddenKingdom", TrollKingdom);

         KingdomAsset GriffinKingdom = new KingdomAsset();
         GriffinKingdom.id = "Griffin";
         GriffinKingdom.mobs = true;
         GriffinKingdom.addTag("Griffin");
         GriffinKingdom.addFriendlyTag("Griffin");
         GriffinKingdom.addEnemyTag("civ");
         AssetManager.kingdoms.add(GriffinKingdom);
         MapBox.instance.kingdoms.CallMethod("newHiddenKingdom", GriffinKingdom);

         KingdomAsset DarkKnightKingdom = new KingdomAsset();
         DarkKnightKingdom.id = "DarkKnight";
         DarkKnightKingdom.mobs = true;
         DarkKnightKingdom.addTag("DarkKnight");
         DarkKnightKingdom.addFriendlyTag("DarkKnight");
         DarkKnightKingdom.addEnemyTag("civ");
         AssetManager.kingdoms.add(DarkKnightKingdom);
         MapBox.instance.kingdoms.CallMethod("newHiddenKingdom", DarkKnightKingdom);

         KingdomAsset PhoenixKingdom = new KingdomAsset();
         PhoenixKingdom.id = "Phoenix";
         PhoenixKingdom.mobs = true;
         PhoenixKingdom.addTag("Phoenix");
         PhoenixKingdom.addFriendlyTag("Phoenix");
         PhoenixKingdom.addEnemyTag("civ");
         AssetManager.kingdoms.add(PhoenixKingdom);
         MapBox.instance.kingdoms.CallMethod("newHiddenKingdom", PhoenixKingdom);

         KingdomAsset WitchKingdom = new KingdomAsset();
         WitchKingdom.id = "Witch";
         WitchKingdom.mobs = true;
         WitchKingdom.addTag("Witch");
         WitchKingdom.addFriendlyTag("Witch");
         WitchKingdom.addEnemyTag("civ");
         AssetManager.kingdoms.add(WitchKingdom);
         MapBox.instance.kingdoms.CallMethod("newHiddenKingdom", WitchKingdom);

          KingdomAsset GodzillaRaceKingdom = new KingdomAsset();
          GodzillaRaceKingdom.id = "GodzillaRace";
          GodzillaRaceKingdom.mobs = true;
          GodzillaRaceKingdom.addTag("GodzillaRace");
          GodzillaRaceKingdom.addFriendlyTag("GodzillaRace");
          GodzillaRaceKingdom.addEnemyTag("nature_creature");
          GodzillaRaceKingdom.addEnemyTag("civ");
          AssetManager.kingdoms.add(GodzillaRaceKingdom);
          MapBox.instance.kingdoms.CallMethod("newHiddenKingdom", GodzillaRaceKingdom);

          KingdomAsset DragonSlayerRaceKingdom = new KingdomAsset();
          DragonSlayerRaceKingdom.id = "DragonSlayerRace";
          DragonSlayerRaceKingdom.mobs = true;
          DragonSlayerRaceKingdom.addTag("DragonSlayerRace");
          DragonSlayerRaceKingdom.addFriendlyTag("DragonSlayerRace");
          AssetManager.kingdoms.add(DragonSlayerRaceKingdom);
          MapBox.instance.kingdoms.CallMethod("newHiddenKingdom", DragonSlayerRaceKingdom);
       }
    }
}