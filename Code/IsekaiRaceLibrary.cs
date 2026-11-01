using HarmonyLib;
using System;
using NCMS;
using NCMS.Utils;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Reflection;
using ReflectionUtility;
using System.Threading;
using System.Text;
using System.IO;
using UnityEngine.Events;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using System.Reflection.Emit;
using ai;

namespace Isekai{
    class IsekaiRaceLibrary
    {
        internal static List<string> defaultRaces = new List<string>(){
            "human", "elf", "orc", "dwarf"
        };

        internal static List<string> human = new List<string>(){
            "human"
        };

        internal static List<string> additionalRaces = new List<string>(){
            "android", "darkelve", "beastmen", "gnome", "angel", "demonic", "japaneses", "ancientchina"
        };
        
        internal void init(){

            var android = AssetManager.raceLibrary.clone("android", "human");
            android.civ_baseCities = 5;
            android.civ_base_army_mod  = 0.9f;
            android.civ_base_zone_range = 4;
            android.culture_rate_tech_limit = 6;
            android.culture_knowledge_gain_per_intelligence = 2.5f;
            android.build_order_id = "kingdom_base";
            android.path_icon = "ui/Icons/iconAndroid";
            android.nameLocale = "Androids";
            android.banner_id= "android";
            android.main_texture_path = "races/android/";
            android.name_template_city = "human_city";
            android.name_template_kingdom = "human_kingdom";
            android.name_template_culture = "human_culture";
            android.name_template_clan = "human_clan";
            android.production = new string[] { "bread" };
            android.skin_citizen_male = List.Of<string>(new string[] {	
			"unit_male_1",
			"unit_male_2"});
            android.skin_citizen_female = List.Of<string>(new string[] {
 			"unit_female_1",
			"unit_female_2"});
            android.skin_warrior = List.Of<string>(new string[] {
  			"unit_warrior_1",
			"unit_warrior_2"});
            android.nomad_kingdom_id = $"nomads_{android.id}";
            android.preferred_weapons.Clear();
            AssetManager.raceLibrary.CallMethod("setPreferredStatPool", "diplomacy#5,warfare#5,stewardship#5,intelligence#5" );
            AssetManager.raceLibrary.CallMethod("setPreferredFoodPool", "meat#5");
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "An01", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "An02", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "An03", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "An04", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "An05", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "An06", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "An07", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "An08", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "An09", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "An10", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "An11", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "An12", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "An13", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "An14", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "An15", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "An16", 10);
            AssetManager.raceLibrary.addBuildingOrderKey(SB.order_tent, "tent_android");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_0, "house_android");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_1, "1house_android");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_2, "2house_android");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_3, "3house_android");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_4, "4house_android");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_5, "5house_android");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_0, "hall_android");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_1, "1hall_android");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_2, "2hall_android");
            AssetManager.raceLibrary.addBuildingOrderKey(SB.order_windmill_0, "windmill_android");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_windmill_1, "windmill_android");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_docks_0, "fishing_docks_android");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_docks_1, "docks_android");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_watch_tower, "watch_tower_android");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_barracks, "barracks_android");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_temple, "temple_android");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_statue, SB.statue);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_well, SB.well);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_bonfire, SB.bonfire);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_mine, SB.mine);
            //Reflection.CallStaticMethod(typeof(BannerGenerator), "loadTexturesFromResources", "android");

            
            var darkelve = AssetManager.raceLibrary.clone("darkelve", "human");
            darkelve.civ_baseCities =  3;
            darkelve.civ_base_army_mod  = 0.6f;
            darkelve.civ_base_zone_range = 4;
            darkelve.culture_rate_tech_limit = 5;
            darkelve.culture_knowledge_gain_per_intelligence = 1.5f;
            darkelve.build_order_id = "kingdom_base";
            darkelve.path_icon = "ui/Icons/iconDarkElves";
            darkelve.nameLocale = "DarkElves";
            darkelve.banner_id= "elf";
            darkelve.main_texture_path = "races/darkelve/";
            darkelve.name_template_city = "elf_city";
            darkelve.name_template_kingdom = "elf_kingdom";
            darkelve.name_template_culture = "elf_culture";
            darkelve.name_template_clan = "elf_clan";
            darkelve.production = new string[] { "bread","jam","sushi","cider" };
            darkelve.skin_citizen_male = List.Of<string>(new string[] {	
			"unit_male_1",
			"unit_male_2"});
            darkelve.skin_citizen_female = List.Of<string>(new string[] {
 			"unit_female_1",
			"unit_female_2"});
            darkelve.skin_warrior = List.Of<string>(new string[] {
  			"unit_warrior_1",
			"unit_warrior_2"});
            darkelve.nomad_kingdom_id = $"nomads_{darkelve.id}";
            darkelve.preferred_weapons.Clear();
            AssetManager.raceLibrary.CallMethod("setPreferredStatPool", "diplomacy#2,warfare#5,stewardship#5,intelligence#3");
            AssetManager.raceLibrary.CallMethod("setPreferredFoodPool", "lemons#1,herbs#3,berries#5,bread#5,fish#1,sushi#10,cider#10,tea#1");
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "stick", 5);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "spear", 5);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "bow", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "sword", 2);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "XBeast", 10);
            AssetManager.raceLibrary.addBuildingOrderKey(SB.order_tent, "tent_darkelve");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_0, "house_darkelve");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_1, "1house_darkelve");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_2, "2house_darkelve");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_3, "3house_darkelve");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_4, "4house_darkelve");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_5, "5house_darkelve");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_0, "hall_darkelve");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_1, "1hall_darkelve");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_2, "2hall_darkelve");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_windmill_0, "windmill_darkelve");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_windmill_1, "windmill_darkelve");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_docks_0, "fishing_docks_darkelve");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_docks_1, "docks_darkelve");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_watch_tower, "watch_tower_darkelve");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_barracks, "barracks_darkelve");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_temple, "temple_darkelve");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_statue, SB.statue);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_well, SB.well);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_bonfire, SB.bonfire);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_mine, SB.mine);
            //Reflection.CallStaticMethod(typeof(BannerGenerator), "loadTexturesFromResources", "darkelve");


            var beastmen = AssetManager.raceLibrary.clone("beastmen", "human");
            beastmen.civ_baseCities =  3;
            beastmen.civ_base_army_mod  = 0.7f;
            beastmen.civ_base_zone_range = 4;
            beastmen.culture_rate_tech_limit = 5;
            beastmen.culture_knowledge_gain_per_intelligence = 1.5f;
            beastmen.build_order_id = "kingdom_base";
            beastmen.path_icon = "ui/Icons/iconBeastmen";
            beastmen.nameLocale = "Beastmen";
            beastmen.banner_id= "beastmen";
            beastmen.main_texture_path = "races/beastmen/";
            beastmen.name_template_city = "orc_city";
            beastmen.name_template_kingdom = "orc_kingdom";
            beastmen.name_template_culture = "orc_culture";
            beastmen.name_template_clan = "orc_clan";
            beastmen.production = new string[] { "bread","jam","sushi","cider" };
            beastmen.skin_citizen_male = List.Of<string>(new string[] {	
			"unit_male_1",
			"unit_male_2",
			"unit_male_3",
			"unit_male_4",
			"unit_male_5"});
            beastmen.skin_citizen_female = List.Of<string>(new string[] {
 			"unit_female_1",
			"unit_female_2",
			"unit_female_3",
			"unit_female_4",
			"unit_female_5"});
            beastmen.skin_warrior = List.Of<string>(new string[] {
  			"unit_warrior_1",
			"unit_warrior_2",
			"unit_warrior_3",
			"unit_warrior_4",
			"unit_warrior_5"});
            beastmen.nomad_kingdom_id = $"nomads_{beastmen.id}";
            beastmen.preferred_weapons.Clear();
            AssetManager.raceLibrary.CallMethod("setPreferredStatPool", "diplomacy#3,stewardship#1,intelligence#2,warfare#5");
            AssetManager.raceLibrary.CallMethod("setPreferredFoodPool", "meat#5");
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "bow", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "spear", 8);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "sword", 6);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "axe", 5);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "hammer", 3);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "Club", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "XBeast", 10);
            AssetManager.raceLibrary.addBuildingOrderKey(SB.order_tent, "tent_beastmen");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_0, "house_beastmen");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_1, "1house_beastmen");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_2, "2house_beastmen");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_3, "3house_beastmen");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_4, "4house_beastmen");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_5, "5house_beastmen");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_0, "hall_beastmen");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_1, "1hall_beastmen");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_2, "2hall_beastmen");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_windmill_0, "windmill_beastmen");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_windmill_1, "windmill_beastmen");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_docks_0, "fishing_docks_beastmen");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_docks_1, "docks_beastmen");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_watch_tower, "watch_tower_beastmen");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_barracks, "barracks_beastmen");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_temple, "temple_beastmen");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_statue, SB.statue);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_well, SB.well);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_bonfire, SB.bonfire);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_mine, SB.mine);
            //Reflection.CallStaticMethod(typeof(BannerGenerator), "loadTexturesFromResources", "beastmen");


            var gnome = AssetManager.raceLibrary.clone("gnome", "human");
            gnome.civ_baseCities =  2;
            gnome.civ_base_army_mod  = 0.5f;
            gnome.civ_base_zone_range = 3;
            gnome.culture_rate_tech_limit = 5;
            gnome.culture_knowledge_gain_per_intelligence = 1.7f;
            gnome.build_order_id = "kingdom_base";
            gnome.path_icon = "ui/Icons/iconGnomes";
            gnome.nameLocale = "Gnomes";
            gnome.banner_id= "gnome";
            gnome.main_texture_path = "races/gnome/";
            gnome.name_template_city = "dwarf_city";
            gnome.name_template_kingdom = "dwarf_kingdom";
            gnome.name_template_culture = "dwarf_culture";
            gnome.name_template_clan = "dwarf_clan";
            gnome.production = new string[] { "bread","ale" };
            gnome.skin_citizen_male = List.Of<string>(new string[] {	
			"unit_male_1"});
            gnome.skin_citizen_female = List.Of<string>(new string[] {
 			"unit_female_1"});
            gnome.skin_warrior = List.Of<string>(new string[] {
  			"unit_warrior_1"});
            gnome.nomad_kingdom_id = $"nomads_{gnome.id}";
            gnome.preferred_weapons.Clear();
            AssetManager.raceLibrary.CallMethod("setPreferredStatPool", "diplomacy#5,warfare#1,stewardship#2,intelligence#3");
            AssetManager.raceLibrary.CallMethod("setPreferredFoodPool", "berries#1,bread#5,fish#5,meat#5,sushi#1,jam#1,cider#1,ale#10,burger#2,pie#2,tea#1");
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "stick", 3);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "hammer", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "bow", 8);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "sword", 2);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "Pistol", 10);
            AssetManager.raceLibrary.addBuildingOrderKey(SB.order_tent, "tent_gnome");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_0, "house_gnome");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_1, "1house_gnome");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_2, "2house_gnome");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_3, "3house_gnome");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_4, "4house_gnome");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_5, "5house_gnome");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_0, "hall_gnome");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_1, "1hall_gnome");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_2, "2hall_gnome");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_windmill_0, "windmill_gnome");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_windmill_1, "windmill_gnome");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_docks_0, "fishing_docks_gnome");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_docks_1, "docks_gnome");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_watch_tower, "watch_tower_gnome");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_barracks, "barracks_gnome");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_temple, "temple_gnome");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_statue, SB.statue);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_well, SB.well);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_bonfire, SB.bonfire);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_mine, SB.mine);
            //Reflection.CallStaticMethod(typeof(BannerGenerator), "loadTexturesFromResources", "gnome");


            var angel = AssetManager.raceLibrary.clone("angel", "human");
            angel.civ_baseCities =  5;
            angel.civ_base_army_mod  = 0.8f;
            angel.civ_base_zone_range = 4;
            angel.culture_rate_tech_limit = 6;
            angel.culture_knowledge_gain_per_intelligence = 2.5f;
            angel.build_order_id = "kingdom_base";
            angel.path_icon = "ui/Icons/iconAngels";
            angel.nameLocale = "Angels";
            angel.banner_id= "angel";
            angel.main_texture_path = "races/angel/";
            angel.name_template_city = "human_city";
            angel.name_template_kingdom = "human_kingdom";
            angel.name_template_culture = "human_culture";
            angel.name_template_clan = "human_clan";
            angel.production = new string[] { "bread","sushi","cider","pie" };
            angel.skin_citizen_male = List.Of<string>(new string[] {	
			"unit_male_1"});
            angel.skin_citizen_female = List.Of<string>(new string[] {
 			"unit_female_1"});
            angel.skin_warrior = List.Of<string>(new string[] {
  			"unit_warrior_1"});
            angel.nomad_kingdom_id = $"nomads_{angel.id}";
            angel.preferred_weapons.Clear();
            AssetManager.raceLibrary.CallMethod("setPreferredStatPool", "diplomacy#5,warfare#2,stewardship#1,intelligence#5");
            AssetManager.raceLibrary.CallMethod("setPreferredFoodPool", "berries#5,bread#5,fish#5,meat#2,sushi#2,jam#1,cider#1,ale#2,burger#1,pie#1,tea#2,herbs#3,lemons#1");
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "stick", 1);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "axe", 2);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "spear", 2);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "bow", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "sword", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "DivineStaff", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "DivineSword", 10);
            AssetManager.raceLibrary.addBuildingOrderKey(SB.order_tent, "tent_angel");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_0, "house_angel");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_1, "1house_angel");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_2, "2house_angel");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_3, "3house_angel");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_4, "4house_angel");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_5, "5house_angel");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_0, "hall_angel");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_1, "1hall_angel");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_2, "2hall_angel");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_windmill_0, "windmill_angel");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_windmill_1, "windmill_angel");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_docks_0, "fishing_docks_angel");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_docks_1, "docks_angel");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_watch_tower, "watch_tower_angel");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_barracks, "barracks_angel");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_temple, "temple_angel");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_statue, SB.statue);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_well, SB.well);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_bonfire, SB.bonfire);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_mine, SB.mine);
            //Reflection.CallStaticMethod(typeof(BannerGenerator), "loadTexturesFromResources", "angel");


            var demonic = AssetManager.raceLibrary.clone("demonic", "human");
            demonic.civ_baseCities =  4;
            demonic.civ_base_army_mod  = 0.8f;
            demonic.civ_base_zone_range = 4;
            demonic.culture_rate_tech_limit = 4;
            demonic.culture_knowledge_gain_per_intelligence = 1.0f;
            demonic.build_order_id = "kingdom_base";
            demonic.path_icon = "ui/Icons/iconDemonic";
            demonic.nameLocale = "Demonic";
            demonic.banner_id= "demonic";
            demonic.main_texture_path = "races/demonic/";
            demonic.name_template_city = "orc_city";
            demonic.name_template_kingdom = "orc_kingdom";
            demonic.name_template_culture = "orc_culture";
            demonic.name_template_clan = "orc_clan";
            demonic.production = new string[] { "jam","pie","tea" };
            demonic.skin_citizen_male = List.Of<string>(new string[] {	
			"unit_male_1"});
            demonic.skin_citizen_female = List.Of<string>(new string[] {
 			"unit_female_1"});
            demonic.skin_warrior = List.Of<string>(new string[] {
  			"unit_warrior_1"});
            demonic.nomad_kingdom_id = $"nomads_{demonic.id}";
            demonic.preferred_weapons.Clear();
            AssetManager.raceLibrary.CallMethod("setPreferredStatPool", "diplomacy#1,stewardship#5,intelligence#2,warfare#5");
            AssetManager.raceLibrary.CallMethod("setPreferredFoodPool", "meat#5");
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "bow", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "sword", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "InfernalTrident", 10);
            AssetManager.raceLibrary.addBuildingOrderKey(SB.order_bonfire, SB.bonfire);
            AssetManager.raceLibrary.addBuildingOrderKey(SB.order_tent, "tent_demonic");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_0, "house_demonic");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_1, "1house_demonic");
            AssetManager.raceLibrary.addBuildingOrderKey(SB.order_statue, SB.statue);
            AssetManager.raceLibrary.addBuildingOrderKey(SB.order_mine, SB.mine);
            AssetManager.raceLibrary.addBuildingOrderKey(SB.order_barracks, "barracks_demonic");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_2, "2house_demonic");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_3, "3house_demonic");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_4, "4house_demonic");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_5, "5house_demonic");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_0, "hall_demonic");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_1, "1hall_demonic");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_2, "2hall_demonic");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_windmill_0, "windmill_demonic");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_windmill_1, "windmill_demonic");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_docks_0, "fishing_docks_demonic");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_docks_1, "docks_demonic");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_watch_tower, "watch_tower_demonic");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_temple, "temple_demonic");
            AssetManager.raceLibrary.addBuildingOrderKey(SB.order_well, SB.well);
            //Reflection.CallStaticMethod(typeof(BannerGenerator), "loadTexturesFromResources", "demonic");

            var japaneses = AssetManager.raceLibrary.clone("japaneses", "human");
            japaneses.civ_baseCities = 5;
            japaneses.civ_base_army_mod  = 10.0f;
            japaneses.civ_base_zone_range = 4;
            japaneses.culture_rate_tech_limit = 50;
            japaneses.culture_knowledge_gain_per_intelligence = 9.0f;
            japaneses.build_order_id = "kingdom_base";
            japaneses.path_icon = "ui/Icons/iconJapaneses";
            japaneses.nameLocale = "Japaneses";
            japaneses.banner_id= "human";
            japaneses.main_texture_path = "races/japaneses/";
            japaneses.name_template_city = "japan_city";
            japaneses.name_template_kingdom = "japan_kingdom";
            japaneses.name_template_culture = "human_culture";
            japaneses.name_template_clan = "japan_clan";
            japaneses.production = new string[] { "sushi", "bread", "pie", "tea", "burger", "cider", "jam", "ale" };
            japaneses.skin_citizen_male = List.Of<string>(new string[] {	
			"unit_male_1",
            "unit_male_2",
            "unit_male_3",
            "unit_male_4",
			"unit_male_5"});
            japaneses.skin_citizen_female = List.Of<string>(new string[] {
 			"unit_female_1",
            "unit_female_2",
            "unit_female_3",
            "unit_female_4",
			"unit_female_5"});
            japaneses.skin_warrior = List.Of<string>(new string[] {
  			"unit_warrior_1",
            "unit_warrior_2",
            "unit_warrior_3",
            "unit_warrior_4",
			"unit_warrior_5"});
            japaneses.nomad_kingdom_id = $"nomads_{japaneses.id}";
            japaneses.preferred_weapons.Clear();
            AssetManager.raceLibrary.CallMethod("setPreferredStatPool", "diplomacy#5,warfare#5,stewardship#5,intelligence#5" );
            AssetManager.raceLibrary.CallMethod("setPreferredFoodPool", "berries#5,bread#5,fish#5,meat#2,sushi#2,jam#1,cider#1,ale#2,burger#1,pie#1,tea#2,candy#1,lemons#1,herbs#3");
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "HowaType89", 10);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "HowaType64", 6);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "HowaType20", 8);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "HowaType62", 5);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "HowaType64SniperRifle", 4);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "M4", 3);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "Bazooka", 2);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "JapaneseTank", 1);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "JapaneseHelicopter", 1);
            AssetManager.raceLibrary.addBuildingOrderKey(SB.order_tent, "tent_japaneses");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_0, "house_japaneses");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_1, "1house_japaneses");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_2, "2house_japaneses");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_3, "3house_japaneses");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_4, "4house_japaneses");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_5, "5house_japaneses");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_0, "hall_japaneses");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_1, "1hall_japaneses");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_2, "2hall_japaneses");
            AssetManager.raceLibrary.addBuildingOrderKey(SB.order_windmill_0, "windmill_japaneses");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_windmill_1, "windmill_japaneses");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_docks_0, "fishing_docks_japaneses");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_docks_1, "docks_japaneses");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_watch_tower, "watch_tower_japaneses");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_barracks, "barracks_japaneses");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_temple, "temple_japaneses");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_statue, SB.statue);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_well, SB.well);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_bonfire, SB.bonfire);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_mine, SB.mine);

            var ancientchina = AssetManager.raceLibrary.clone("ancientchina", "human");
            ancientchina.civ_baseCities = 5;
            ancientchina.civ_base_army_mod  = 10.0f;
            ancientchina.civ_base_zone_range = 4;
            ancientchina.culture_rate_tech_limit = 50;
            ancientchina.culture_knowledge_gain_per_intelligence = 9.0f;
            ancientchina.build_order_id = "kingdom_base";
            ancientchina.path_icon = "ui/Icons/iconAncientChina";
            ancientchina.nameLocale = "AncientChina";
            ancientchina.banner_id= "human";
            ancientchina.main_texture_path = "races/ancientchina/";
            ancientchina.name_template_city = "china_city";
            ancientchina.name_template_kingdom = "china_kingdom";
            ancientchina.name_template_culture = "china_culture";
            ancientchina.name_template_clan = "china_clan";
            ancientchina.production = new string[] { "sushi", "bread", "pie", "tea", "burger", "cider", "jam", "ale" };
            ancientchina.skin_citizen_male = List.Of<string>(new string[] {	
			"unit_male_1"});
            ancientchina.skin_citizen_female = List.Of<string>(new string[] {
 			"unit_female_1"});
            ancientchina.skin_warrior = List.Of<string>(new string[] {
  			"unit_warrior_1"});
            ancientchina.nomad_kingdom_id = $"nomads_{ancientchina.id}";
            ancientchina.preferred_weapons.Clear();
            AssetManager.raceLibrary.CallMethod("setPreferredStatPool", "diplomacy#5,warfare#5,stewardship#5,intelligence#5" );
            AssetManager.raceLibrary.CallMethod("setPreferredFoodPool", "berries#5,bread#5,fish#5,meat#2,sushi#2,jam#1,cider#1,ale#2,burger#1,pie#1,tea#2,candy#1,lemons#1,herbs#3");
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "stick", 5);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "sword", 5);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "axe", 2);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "spear", 2);
            AssetManager.raceLibrary.CallMethod("addPreferredWeapon", "bow", 7);
            AssetManager.raceLibrary.addBuildingOrderKey(SB.order_tent, "tent_ancientchina");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_0, "house_ancientchina");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_1, "1house_ancientchina");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_2, "2house_ancientchina");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_3, "3house_ancientchina");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_4, "4house_ancientchina");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_house_5, "5house_ancientchina");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_0, "hall_ancientchina");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_1, "1hall_ancientchina");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_hall_2, "2hall_ancientchina");
            AssetManager.raceLibrary.addBuildingOrderKey(SB.order_windmill_0, "windmill_ancientchina");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_windmill_1, "windmill_ancientchina");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_docks_0, "fishing_docks_ancientchina");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_docks_1, "docks_ancientchina");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_watch_tower, "watch_tower_ancientchina");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_barracks, "barracks_ancientchina");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_temple, "temple_ancientchina");
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_statue, SB.statue);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_well, SB.well);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_bonfire, SB.bonfire);
		    AssetManager.raceLibrary.addBuildingOrderKey(SB.order_mine, SB.mine);

            android.hateRaces = List.Of<string>(new string[]
		    {
			SK.orc
		    });

            darkelve.hateRaces = List.Of<string>(new string[]
		    {
			SK.orc,SK.dwarf,demonic.id,gnome.id
		    });

            beastmen.hateRaces = List.Of<string>(new string[]
		    {
			SK.orc,demonic.id
		    });

            gnome.hateRaces = List.Of<string>(new string[]
		    {
			SK.orc,SK.elf,demonic.id
		    });

            angel.hateRaces = List.Of<string>(new string[]
		    {
			SK.orc,demonic.id
		    });

            demonic.hateRaces = List.Of<string>(new string[]
		    {
			SK.human,SK.elf,SK.orc,SK.dwarf,darkelve.id,beastmen.id,gnome.id,angel.id,japaneses.id,ancientchina.id
		    });

            japaneses.hateRaces = List.Of<string>(new string[]
		    {
			SK.orc,demonic.id
		    });

            ancientchina.hateRaces = List.Of<string>(new string[]
		    {
			SK.orc,demonic.id
		    });

            var human = AssetManager.raceLibrary.get("human");
            human.hateRaces = List.Of<string>(new string[]
		    {
			demonic.id,SK.orc
		    });

            var elf = AssetManager.raceLibrary.get("elf");
            elf.hateRaces = List.Of<string>(new string[]
		    {
			demonic.id,gnome.id,SK.orc,SK.dwarf
		    });

            var orc = AssetManager.raceLibrary.get("orc");
            orc.hateRaces = List.Of<string>(new string[]
		    {
			demonic.id,darkelve.id,beastmen.id,gnome.id,angel.id,japaneses.id,ancientchina.id,SK.human,SK.elf,SK.dwarf
		    });

            var dwarf = AssetManager.raceLibrary.get("dwarf");
            dwarf.hateRaces = List.Of<string>(new string[]
		    {
			demonic.id,darkelve.id,SK.orc,SK.elf
		    });
        }

        [HarmonyPrefix]
        [HarmonyPatch(typeof(ActorAnimationLoader), "loadAnimationBoat")]
        public static bool loadAnimationBoat_Prefix(ref string pTexturePath, ActorAnimationLoader __instance)
        {
        if (pTexturePath.EndsWith("_"))
        {
         pTexturePath = pTexturePath + "human";
         return true;
        }
        foreach (string race in Main.instance.addRaces)
        {
        if (race == "android")
         {
          pTexturePath = pTexturePath.Replace(race, "android");
         }
        else if (race == "darkelve")
         {
          pTexturePath = pTexturePath.Replace(race, "darkelve");
         }
        else if (race == "beastmen")
         {
          pTexturePath = pTexturePath.Replace(race, "beastmen");
         }
        else if (race == "gnome")
         {
          pTexturePath = pTexturePath.Replace(race, "gnome");
         }
        else if (race == "angel")
         {
          pTexturePath = pTexturePath.Replace(race, "angel");
         }
        else if (race == "demonic")
         {
          pTexturePath = pTexturePath.Replace(race, "demonic");
         }
         else if (race == "japaneses")
         {
          pTexturePath = pTexturePath.Replace(race, "japaneses");
         }
         else if (race == "ancientchina")
         {
          pTexturePath = pTexturePath.Replace(race, "ancientchina");
         }
        else
         {
          pTexturePath = pTexturePath.Replace(race, "human");
         }
        }
        return true;
        }

        [HarmonyPostfix]
        [HarmonyPatch(typeof(ActorAnimationLoader), "generateFrameData")]
        
        public static void generateFrameData_post(ActorAnimationLoader __instance,string pFrameString, AnimationContainerUnit pAnimContainer, Dictionary<string, Sprite> pFrames, string pFramesIDs)
        {

        }

        public static Sprite[] loadAllSprite(string path, bool withFolders = false)
        {
            string p = $"{Main.mainPath}/EmbededResources/{path}";
            DirectoryInfo folder = new DirectoryInfo(p);
            List<Sprite> res = new List<Sprite>();
            foreach (FileInfo file in folder.GetFiles("*.png"))
            {
                Sprite sprite = Sprites.LoadSprite($"{file.FullName}");
                sprite.name = file.Name.Replace(".png", "");
                res.Add(sprite);
            }
            foreach (DirectoryInfo cFolder in folder.GetDirectories())
            {
                foreach (FileInfo file in cFolder.GetFiles("*.png"))
                {
                    Sprite sprite = Sprites.LoadSprite($"{file.FullName}");
                    sprite.name = file.Name.Replace(".png", "");
                    res.Add(sprite);
                }
            }
            return res.ToArray();
        }
    }
}