using System;
using NCMS;
using UnityEngine;
using ReflectionUtility;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;
using Beebyte.Obfuscator;
using NCMS.Utils;

namespace Isekai
{
    class IsekaiGuns
    {
        public static void init()
        {

          //Androids Guns
          ItemAsset An01 = AssetManager.items.clone("An01", "_melee");
          An01.id = "An01";
          An01.path_slash_animation = "effects/slashes/slash_sword";
          An01.materials = List.Of<string>(new string[]{"wood",});
          An01.base_stats[S.damage] = 1;
          An01.base_stats[S.attack_speed] = 40;
          An01.name_templates = Toolbox.splitStringIntoList(new string[]
          {
          "sword_name#30",
      		"sword_name_king#3",
      		"weapon_name_city",
      		"weapon_name_kingdom",
      		"weapon_name_culture",
      		"weapon_name_enemy_king",
      		"weapon_name_enemy_kingdom"
          });
          An01.equipmentType = EquipmentType.Weapon;
          An01.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(An01);
          Localization.addLocalization("item_An01", "An01");
          addGunsSprite(An01.id, An01.materials[0]);

          ItemAsset An02 = AssetManager.items.clone("An02", "_melee");
          An02.id = "An02";
          An02.path_slash_animation = "effects/slashes/slash_sword";
          An02.materials = List.Of<string>(new string[]{"copper"});
          An02.base_stats[S.damage] = 1;
          An02.base_stats[S.attack_speed] = 40;
          An02.name_templates = Toolbox.splitStringIntoList(new string[]
          {
          "sword_name#30",
      	  "sword_name_king#3",
      	  "weapon_name_city",
      	  "weapon_name_kingdom",
      	  "weapon_name_culture",
      	  "weapon_name_enemy_king",
      	  "weapon_name_enemy_kingdom"
          });
          An02.equipmentType = EquipmentType.Weapon;
          An02.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(An02);
          Localization.addLocalization("item_An02", "An02");
          addGunsSprite(An02.id, An02.materials[0]);      

          ItemAsset An03 = AssetManager.items.clone("An03", "_melee");
          An03.id = "An03";
          An03.path_slash_animation = "effects/slashes/slash_sword";
          An03.materials = List.Of<string>(new string[]{"bronze"});
          An03.base_stats[S.damage] = 1;
          An03.base_stats[S.attack_speed] = 40;
          An03.name_templates = Toolbox.splitStringIntoList(new string[]
          {
          "sword_name#30",
      	  "sword_name_king#3",
      	  "weapon_name_city",
      	  "weapon_name_kingdom",
      	  "weapon_name_culture",
      	  "weapon_name_enemy_king",
      	  "weapon_name_enemy_kingdom"
          });
          An03.equipmentType = EquipmentType.Weapon;
          An03.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(An03);
          Localization.addLocalization("item_An03", "An03");
          addGunsSprite(An03.id, An03.materials[0]);

          ItemAsset An04 = AssetManager.items.clone("An04", "_melee");
          An04.id = "An04";
          An04.path_slash_animation = "effects/slashes/slash_sword";
          An04.materials = List.Of<string>(new string[]{"silver"});
          An04.base_stats[S.damage] = 1;
          An04.base_stats[S.attack_speed] = 40;
          An04.name_templates = Toolbox.splitStringIntoList(new string[]
          {
          "sword_name#30",
      	  "sword_name_king#3",
      	  "weapon_name_city",
      	  "weapon_name_kingdom",
      	  "weapon_name_culture",
      	  "weapon_name_enemy_king",
      	  "weapon_name_enemy_kingdom"
          });
          An04.equipmentType = EquipmentType.Weapon;
          An04.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(An04);
          Localization.addLocalization("item_An04", "An04");
          addGunsSprite(An04.id, An04.materials[0]);

          ItemAsset An05 = AssetManager.items.clone("An05", "_melee");
          An05.id = "An05";
          An05.path_slash_animation = "effects/slashes/slash_sword";
          An05.materials = List.Of<string>(new string[]{"iron"});
          An05.base_stats[S.damage] = 1;
          An05.base_stats[S.attack_speed] = 40;
          An05.name_templates = Toolbox.splitStringIntoList(new string[]
          {
          "sword_name#30",
      	  "sword_name_king#3",
      	  "weapon_name_city",
      	  "weapon_name_kingdom",
      	  "weapon_name_culture",
      	  "weapon_name_enemy_king",
      	  "weapon_name_enemy_kingdom"
          });
          An05.equipmentType = EquipmentType.Weapon;
          An05.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(An05);
          Localization.addLocalization("item_An05", "An05");
          addGunsSprite(An05.id, An05.materials[0]);

          ItemAsset An06 = AssetManager.items.clone("An06", "_melee");
          An06.id = "An06";
          An06.path_slash_animation = "effects/slashes/slash_sword";
          An06.materials = List.Of<string>(new string[]{"steel"});
          An06.base_stats[S.damage] = 1;
          An06.base_stats[S.attack_speed] = 40;
          An06.name_templates = Toolbox.splitStringIntoList(new string[]
          {
          "sword_name#30",
      	  "sword_name_king#3",
      	  "weapon_name_city",
      	  "weapon_name_kingdom",
      	  "weapon_name_culture",
      	  "weapon_name_enemy_king",
      	  "weapon_name_enemy_kingdom"
          });
          An06.equipmentType = EquipmentType.Weapon;
          An06.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(An06);
          Localization.addLocalization("item_An06", "An06");
          addGunsSprite(An06.id, An06.materials[0]);

          ItemAsset An07 = AssetManager.items.clone("An07", "_melee");
          An07.id = "An07";
          An07.path_slash_animation = "effects/slashes/slash_sword";
          An07.materials = List.Of<string>(new string[]{"mythril"});
          An07.base_stats[S.damage] = 1;
          An07.base_stats[S.attack_speed] = 40;
          An07.name_templates = Toolbox.splitStringIntoList(new string[]
          {
          "sword_name#30",
      	  "sword_name_king#3",
      	  "weapon_name_city",
      	  "weapon_name_kingdom",
      	  "weapon_name_culture",
      	  "weapon_name_enemy_king",
      	  "weapon_name_enemy_kingdom"
          });
          An07.equipmentType = EquipmentType.Weapon;
          An07.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(An07);
          Localization.addLocalization("item_An07", "An07");
          addGunsSprite(An07.id, An07.materials[0]);

          ItemAsset An08 = AssetManager.items.clone("An08", "_melee");
          An08.id = "An08";
          An08.path_slash_animation = "effects/slashes/slash_sword";
          An08.materials = List.Of<string>(new string[]{"adamantine"});
          An08.base_stats[S.damage] = 1;
          An08.base_stats[S.attack_speed] = 40;
          An08.name_templates = Toolbox.splitStringIntoList(new string[]
          {
          "sword_name#30",
      	  "sword_name_king#3",
      	  "weapon_name_city",
      	  "weapon_name_kingdom",
      	  "weapon_name_culture",
      	  "weapon_name_enemy_king",
      	  "weapon_name_enemy_kingdom"
          });
          An08.equipmentType = EquipmentType.Weapon;
          An08.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(An08);
          Localization.addLocalization("item_An08", "An08");
          addGunsSprite(An08.id, An08.materials[0]);

          ItemAsset An09 = AssetManager.items.clone("An09", "_range");
          An09.id = "An09";
          An09.tech_needed = "weapon_bow";
          An09.projectile = "AnProjetil";
          An09.path_slash_animation = "effects/slashes/slash_punch";
          An09.materials = List.Of<string>(new string[]{"wood"});
          An09.base_stats[S.range] = 22f;
          An09.base_stats[S.critical_chance] = 0.5f;
          An09.name_templates = Toolbox.splitStringIntoList(new string[]
          {
            "bow_name#30",
		        "weapon_name_city",
		        "weapon_name_kingdom",
		        "weapon_name_culture",
		        "weapon_name_enemy_king",
		        "weapon_name_enemy_kingdom"
          });
          An09.equipmentType = EquipmentType.Weapon;
          An09.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(An09);
          Localization.addLocalization("item_An09", "An09");
          addGunsSprite(An09.id, An09.materials[0]);

          ItemAsset An10 = AssetManager.items.clone("An10", "_range");
          An10.id = "An10";
          An10.tech_needed = "weapon_bow";
          An10.projectile = "AnProjetil";
          An10.path_slash_animation = "effects/slashes/slash_punch";
          An10.materials = List.Of<string>(new string[]{"copper"});
          An10.base_stats[S.range] = 22f;
          An10.base_stats[S.critical_chance] = 0.5f;
          An10.name_templates = Toolbox.splitStringIntoList(new string[]
          {
            "bow_name#30",
		        "weapon_name_city",
		        "weapon_name_kingdom",
		        "weapon_name_culture",
		        "weapon_name_enemy_king",
		        "weapon_name_enemy_kingdom"
          });
          An10.equipmentType = EquipmentType.Weapon;
          An10.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(An10);
          Localization.addLocalization("item_An10", "An10");
          addGunsSprite(An10.id, An10.materials[0]);

          ItemAsset An11 = AssetManager.items.clone("An11", "_range");
          An11.id = "An11";
          An11.tech_needed = "weapon_bow";
          An11.projectile = "AnProjetil";
          An11.path_slash_animation = "effects/slashes/slash_punch";
          An11.materials = List.Of<string>(new string[]{"bronze"});
          An11.base_stats[S.range] = 22f;
          An11.base_stats[S.critical_chance] = 0.5f;
          An11.name_templates = Toolbox.splitStringIntoList(new string[]
          {
            "bow_name#30",
		        "weapon_name_city",
		        "weapon_name_kingdom",
		        "weapon_name_culture",
		        "weapon_name_enemy_king",
		        "weapon_name_enemy_kingdom"
          });
          An11.equipmentType = EquipmentType.Weapon;
          An11.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(An11);
          Localization.addLocalization("item_An11", "An11");
          addGunsSprite(An11.id, An11.materials[0]);

          ItemAsset An12 = AssetManager.items.clone("An12", "_range");
          An12.id = "An12";
          An12.tech_needed = "weapon_bow";
          An12.projectile = "AnProjetil";
          An12.path_slash_animation = "effects/slashes/slash_punch";
          An12.materials = List.Of<string>(new string[]{"silver"});
          An12.base_stats[S.range] = 22f;
          An12.base_stats[S.critical_chance] = 0.5f;
          An12.name_templates = Toolbox.splitStringIntoList(new string[]
          {
            "bow_name#30",
		        "weapon_name_city",
		        "weapon_name_kingdom",
		        "weapon_name_culture",
		        "weapon_name_enemy_king",
		        "weapon_name_enemy_kingdom"
          });
          An12.equipmentType = EquipmentType.Weapon;
          An12.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(An12);
          Localization.addLocalization("item_An12", "An12");
          addGunsSprite(An12.id, An12.materials[0]);

          ItemAsset An13 = AssetManager.items.clone("An13", "_range");
          An13.id = "An13";
          An13.tech_needed = "weapon_bow";
          An13.projectile = "AnProjetil";
          An13.path_slash_animation = "effects/slashes/slash_punch";
          An13.materials = List.Of<string>(new string[]{"iron"});
          An13.base_stats[S.range] = 22f;
          An13.base_stats[S.critical_chance] = 0.5f;
          An13.name_templates = Toolbox.splitStringIntoList(new string[]
          {
            "bow_name#30",
		        "weapon_name_city",
		        "weapon_name_kingdom",
		        "weapon_name_culture",
		        "weapon_name_enemy_king",
		        "weapon_name_enemy_kingdom"
          });
          An13.equipmentType = EquipmentType.Weapon;
          An13.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(An13);
          Localization.addLocalization("item_An13", "An13");
          addGunsSprite(An13.id, An13.materials[0]);

          ItemAsset An14 = AssetManager.items.clone("An14", "_range");
          An14.id = "An14";
          An14.tech_needed = "weapon_bow";
          An14.projectile = "AnProjetil";
          An14.path_slash_animation = "effects/slashes/slash_punch";
          An14.materials = List.Of<string>(new string[]{"steel"});
          An14.base_stats[S.range] = 22f;
          An14.base_stats[S.critical_chance] = 0.5f;
          An14.name_templates = Toolbox.splitStringIntoList(new string[]
          {
            "bow_name#30",
		        "weapon_name_city",
		        "weapon_name_kingdom",
		        "weapon_name_culture",
		        "weapon_name_enemy_king",
		        "weapon_name_enemy_kingdom"
          });
          An14.equipmentType = EquipmentType.Weapon;
          An14.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(An14);
          Localization.addLocalization("item_An14", "An14");
          addGunsSprite(An14.id, An14.materials[0]);

          ItemAsset An15 = AssetManager.items.clone("An15", "_range");
          An15.id = "An15";
          An15.tech_needed = "weapon_bow";
          An15.projectile = "AnProjetil";
          An15.path_slash_animation = "effects/slashes/slash_punch";
          An15.materials = List.Of<string>(new string[]{"mythril"});
          An15.base_stats[S.range] = 22f;
          An15.base_stats[S.critical_chance] = 0.5f;
          An15.name_templates = Toolbox.splitStringIntoList(new string[]
          {
            "bow_name#30",
		        "weapon_name_city",
		        "weapon_name_kingdom",
		        "weapon_name_culture",
		        "weapon_name_enemy_king",
		        "weapon_name_enemy_kingdom"
          });
          An15.equipmentType = EquipmentType.Weapon;
          An15.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(An15);
          Localization.addLocalization("item_An15", "An15");
          addGunsSprite(An15.id, An15.materials[0]);

          ItemAsset An16 = AssetManager.items.clone("An16", "_range");
          An16.id = "An16";
          An16.tech_needed = "weapon_bow";
          An16.projectile = "AnProjetil";
          An16.path_slash_animation = "effects/slashes/slash_punch";
          An16.materials = List.Of<string>(new string[]{"adamantine"});
          An16.base_stats[S.range] = 22f;
          An16.base_stats[S.critical_chance] = 0.5f;
          An16.name_templates = Toolbox.splitStringIntoList(new string[]
          {
            "bow_name#30",
		        "weapon_name_city",
		        "weapon_name_kingdom",
		        "weapon_name_culture",
		        "weapon_name_enemy_king",
		        "weapon_name_enemy_kingdom"
          });
          An16.equipmentType = EquipmentType.Weapon;
          An16.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(An16);
          Localization.addLocalization("item_An16", "An16");
          addGunsSprite(An16.id, An16.materials[0]);

          //Modern Guns

          ItemAsset M4 = AssetManager.items.clone("M4", "_range");
          M4.id = "M4";
          M4.projectile = "shotgun_bullet";
          M4.path_slash_animation = "effects/slashes/slash_punch";
          M4.materials = List.Of<string>(new string[]{"steel"});
          M4.base_stats[S.attack_speed] = 15f;
          M4.base_stats[S.targets] = 1;
          M4.base_stats[S.range] = 18f;
          M4.base_stats[S.projectiles] = 1;
          M4.equipment_value = 1000;
          M4.name_templates = Toolbox.splitStringIntoList(new string[]
          {
            "bow_name#30",
		        "weapon_name_city",
		        "weapon_name_kingdom",
		        "weapon_name_culture",
		        "weapon_name_enemy_king",
		        "weapon_name_enemy_kingdom"
          });
          M4.equipmentType = EquipmentType.Weapon;
          M4.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(M4);
          Localization.addLocalization("item_M4", "M4");
          addGunsSprite(M4.id, M4.materials[0]);

          ItemAsset Bazooka = AssetManager.items.clone("Bazooka", "_range");
          Bazooka.id = "Bazooka";
          Bazooka.projectile = "JpProjetil";
          Bazooka.path_slash_animation = "effects/slashes/slash_punch";
          Bazooka.name_class = "item_class_weapon";
          Bazooka.base_stats[S.damage] = 50;
          Bazooka.base_stats[S.targets] = 1;
          Bazooka.base_stats[S.range] = 18f;
          Bazooka.base_stats[S.projectiles] = 1;
          Bazooka.base_stats[S.knockback] = 0.6f;
          Bazooka.base_stats[S.critical_chance] = 0.5f;
          Bazooka.equipment_value = 1000;
          Bazooka.materials = List.Of<string>(new string[]{"steel"});
          Bazooka.equipmentType = EquipmentType.Weapon;          
          AssetManager.items.list.AddItem(Bazooka);
          Localization.addLocalization("item_Bazooka", "Bazooka");
          addGunsSprite(Bazooka.id, Bazooka.materials[0]);

          //Japan Guns

          ItemAsset HowaType89 = AssetManager.items.clone("HowaType89", "_range");
          HowaType89.id = "HowaType89";
          HowaType89.projectile = "shotgun_bullet";
          HowaType89.path_slash_animation = "effects/slashes/slash_punch";
          HowaType89.materials = List.Of<string>(new string[]{"wood"});
          HowaType89.base_stats[S.attack_speed] = 15f;
          HowaType89.base_stats[S.targets] = 1;
          HowaType89.base_stats[S.range] = 18f;
          HowaType89.base_stats[S.projectiles] = 1;
          HowaType89.equipment_value = 1100;
          HowaType89.name_templates = Toolbox.splitStringIntoList(new string[]
          {
            "bow_name#30",
		        "weapon_name_city",
		        "weapon_name_kingdom",
		        "weapon_name_culture",
		        "weapon_name_enemy_king",
		        "weapon_name_enemy_kingdom"
          });
          HowaType89.equipmentType = EquipmentType.Weapon;
          HowaType89.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(HowaType89);
          Localization.addLocalization("item_HowaType89", "HowaType89");
          addGunsSprite(HowaType89.id, HowaType89.materials[0]);

          ItemAsset HowaType64 = AssetManager.items.clone("HowaType64", "_range");
          HowaType64.id = "HowaType64";
          HowaType64.projectile = "shotgun_bullet";
          HowaType64.path_slash_animation = "effects/slashes/slash_punch";
          HowaType64.materials = List.Of<string>(new string[]{"wood"});
          HowaType64.base_stats[S.attack_speed] = 15f;
          HowaType64.base_stats[S.targets] = 1;
          HowaType64.base_stats[S.range] = 18f;
          HowaType64.base_stats[S.projectiles] = 1;
          HowaType64.equipment_value = 1100;
          HowaType64.name_templates = Toolbox.splitStringIntoList(new string[]
          {
            "bow_name#30",
		        "weapon_name_city",
		        "weapon_name_kingdom",
		        "weapon_name_culture",
		        "weapon_name_enemy_king",
		        "weapon_name_enemy_kingdom"
          });
          HowaType64.equipmentType = EquipmentType.Weapon;
          HowaType64.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(HowaType64);
          Localization.addLocalization("item_HowaType64", "HowaType64");
          addGunsSprite(HowaType64.id, HowaType64.materials[0]);

          ItemAsset HowaType20 = AssetManager.items.clone("HowaType20", "_range");
          HowaType20.id = "HowaType20";
          HowaType20.projectile = "shotgun_bullet";
          HowaType20.path_slash_animation = "effects/slashes/slash_punch";
          HowaType20.materials = List.Of<string>(new string[]{"wood"});
          HowaType20.base_stats[S.attack_speed] = 15f;
          HowaType20.base_stats[S.targets] = 1;
          HowaType20.base_stats[S.range] = 18f;
          HowaType20.base_stats[S.projectiles] = 1;
          HowaType20.equipment_value = 1100;
          HowaType20.name_templates = Toolbox.splitStringIntoList(new string[]
          {
            "bow_name#30",
		        "weapon_name_city",
		        "weapon_name_kingdom",
		        "weapon_name_culture",
		        "weapon_name_enemy_king",
		        "weapon_name_enemy_kingdom"
          });
          HowaType20.equipmentType = EquipmentType.Weapon;
          HowaType20.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(HowaType20);
          Localization.addLocalization("item_HowaType20", "HowaType20");
          addGunsSprite(HowaType20.id, HowaType20.materials[0]);

          ItemAsset HowaType62 = AssetManager.items.clone("HowaType62", "_range");
          HowaType62.id = "HowaType62";
          HowaType62.projectile = "shotgun_bullet";
          HowaType62.path_slash_animation = "effects/slashes/slash_punch";
          HowaType62.materials = List.Of<string>(new string[]{"wood"});
          HowaType62.base_stats[S.attack_speed] = 15f;
          HowaType62.base_stats[S.targets] = 1;
          HowaType62.base_stats[S.range] = 18f;
          HowaType62.base_stats[S.projectiles] = 1;
          HowaType62.equipment_value = 1000;
          HowaType62.name_templates = Toolbox.splitStringIntoList(new string[]
          {
            "bow_name#30",
		        "weapon_name_city",
		        "weapon_name_kingdom",
		        "weapon_name_culture",
		        "weapon_name_enemy_king",
		        "weapon_name_enemy_kingdom"
          });
          HowaType62.equipmentType = EquipmentType.Weapon;
          HowaType62.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(HowaType62);
          Localization.addLocalization("item_HowaType62", "HowaType62");
          addGunsSprite(HowaType62.id, HowaType62.materials[0]);

          ItemAsset HowaType64SniperRifle = AssetManager.items.clone("HowaType64SniperRifle", "_range");
          HowaType64SniperRifle.id = "HowaType64SniperRifle";
          HowaType64SniperRifle.projectile = "shotgun_bullet";
          HowaType64SniperRifle.path_slash_animation = "effects/slashes/slash_punch";
          HowaType64SniperRifle.materials = List.Of<string>(new string[]{"wood"});
          HowaType64SniperRifle.base_stats[S.attack_speed] = 5f;
          HowaType64SniperRifle.base_stats[S.targets] = 1;
          HowaType64SniperRifle.base_stats[S.range] = 20f;
          HowaType64SniperRifle.base_stats[S.projectiles] = 1;
          HowaType64SniperRifle.equipment_value = 1100;
          HowaType64SniperRifle.name_templates = Toolbox.splitStringIntoList(new string[]
          {
            "bow_name#30",
		        "weapon_name_city",
		        "weapon_name_kingdom",
		        "weapon_name_culture",
		        "weapon_name_enemy_king",
		        "weapon_name_enemy_kingdom"
          });
          HowaType64SniperRifle.equipmentType = EquipmentType.Weapon;
          HowaType64SniperRifle.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(HowaType64SniperRifle);
          Localization.addLocalization("item_HowaType64SniperRifle", "HowaType64SniperRifle");
          addGunsSprite(HowaType64SniperRifle.id, HowaType64SniperRifle.materials[0]);

          ItemAsset JapaneseTank = AssetManager.items.clone("JapaneseTank", "_range");
          JapaneseTank.id = "JapaneseTank";
          JapaneseTank.projectile = "JpProjetil";
          JapaneseTank.path_slash_animation = "effects/slashes/slash_punch";
          JapaneseTank.name_class = "item_class_weapon";
          JapaneseTank.base_stats[S.targets] = 1;
          JapaneseTank.base_stats[S.range] = 18f;
          JapaneseTank.base_stats[S.projectiles] = 1;
          JapaneseTank.base_stats[S.knockback] = 0.6f;
          JapaneseTank.base_stats[S.critical_chance] = 0.5f;
          JapaneseTank.base_stats[S.attack_speed] = 10f;
          JapaneseTank.base_stats[S.accuracy] = 100f;
          JapaneseTank.base_stats[S.health] = 3000;
          JapaneseTank.base_stats[S.speed] = 60f;
          JapaneseTank.base_stats[S.damage] = 200;
          JapaneseTank.base_stats[S.knockback_reduction] = 1000f;
          JapaneseTank.equipment_value = 1100;
          JapaneseTank.materials = List.Of<string>(new string[]{"steel"});
          JapaneseTank.equipmentType = EquipmentType.Weapon;          
          AssetManager.items.list.AddItem(JapaneseTank);
          Localization.addLocalization("item_JapaneseTank", "JapaneseTank");
          addGunsSprite(JapaneseTank.id, JapaneseTank.materials[0]);

          ItemAsset JapaneseHelicopter = AssetManager.items.clone("JapaneseHelicopter", "_range");
          JapaneseHelicopter.id = "JapaneseHelicopter";
          JapaneseHelicopter.projectile = "shotgun_bullet";
          JapaneseHelicopter.path_slash_animation = "effects/slashes/slash_punch";
          JapaneseHelicopter.name_class = "item_class_weapon";
          JapaneseHelicopter.base_stats[S.targets] = 1;
          JapaneseHelicopter.base_stats[S.range] = 18f;
          JapaneseHelicopter.base_stats[S.projectiles] = 3;
          JapaneseHelicopter.base_stats[S.critical_chance] = 0.5f;
          JapaneseHelicopter.base_stats[S.attack_speed] = 30f;
          JapaneseHelicopter.base_stats[S.accuracy] = 100f;
          JapaneseHelicopter.base_stats[S.health] = 1000;
          JapaneseHelicopter.base_stats[S.speed] = 100f;
          JapaneseHelicopter.base_stats[S.damage] = 93;
          JapaneseHelicopter.base_stats[S.knockback_reduction] = 1000f;
          JapaneseHelicopter.equipment_value = 1100;
          JapaneseHelicopter.materials = List.Of<string>(new string[]{"steel"});
          JapaneseHelicopter.equipmentType = EquipmentType.Weapon;          
          AssetManager.items.list.AddItem(JapaneseHelicopter);
          Localization.addLocalization("item_JapaneseHelicopter", "JapaneseHelicopter");
          addGunsSprite(JapaneseHelicopter.id, JapaneseHelicopter.materials[0]);

          //Angel Guns

          ItemAsset DivineStaff = AssetManager.items.clone("DivineStaff", "_range");
          DivineStaff.id = "DivineStaff";
          DivineStaff.projectile = "AngelProjetil";
          DivineStaff.path_slash_animation = "effects/slashes/slash_punch";
          DivineStaff.tech_needed = "weapon_bow";
          DivineStaff.base_stats[S.targets] = 1;
          DivineStaff.base_stats[S.range] = 22f;
          DivineStaff.base_stats[S.critical_chance] = 0.5f;
          DivineStaff.base_stats[S.projectiles] = 1;
          DivineStaff.materials = List.Of<string>(new string[]{"adamantine"});
          DivineStaff.name_templates = Toolbox.splitStringIntoList(new string[]
          {
            "bow_name#30",
		        "weapon_name_city",
		        "weapon_name_kingdom",
		        "weapon_name_culture",
		        "weapon_name_enemy_king",
		        "weapon_name_enemy_kingdom"
          });
          DivineStaff.equipmentType = EquipmentType.Weapon;
          DivineStaff.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(DivineStaff);
          Localization.addLocalization("item_DivineStaff", "DivineStaff");
          addGunsSprite(DivineStaff.id, DivineStaff.materials[0]);

          ItemAsset DivineSword = AssetManager.items.clone("DivineSword", "_melee");
          DivineSword.id = "DivineSword";
          DivineSword.path_slash_animation = "effects/slashes/slash_sword";
          DivineSword.materials = List.Of<string>(new string[]{"adamantine",});
          DivineSword.base_stats[S.damage] = 1;
          DivineSword.base_stats[S.attack_speed] = 40;
          DivineSword.name_templates = Toolbox.splitStringIntoList(new string[]
          {
          "sword_name#30",
      		"sword_name_king#3",
      		"weapon_name_city",
      		"weapon_name_kingdom",
      		"weapon_name_culture",
      		"weapon_name_enemy_king",
      		"weapon_name_enemy_kingdom"
          });
          DivineSword.equipmentType = EquipmentType.Weapon;
          DivineSword.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(DivineSword);
          Localization.addLocalization("item_DivineSword", "DivineSword");
          addGunsSprite(DivineSword.id, DivineSword.materials[0]);

          //Gnome Guns

          ItemAsset Pistol = AssetManager.items.clone("Pistol", "_range");
          Pistol.id = "Pistol";
          Pistol.projectile = "shotgun_bullet";
          Pistol.path_slash_animation = "effects/slashes/slash_punch";
          Pistol.tech_needed = "weapon_bow";
          Pistol.base_stats[S.targets] = 1;
          Pistol.base_stats[S.range] = 22f;
          Pistol.base_stats[S.critical_chance] = 0.5f;
          Pistol.base_stats[S.projectiles] = 1;
          Pistol.materials = List.Of<string>(new string[]{"adamantine"});
          Pistol.name_templates = Toolbox.splitStringIntoList(new string[]
          {
            "bow_name#30",
		        "weapon_name_city",
		        "weapon_name_kingdom",
		        "weapon_name_culture",
		        "weapon_name_enemy_king",
		        "weapon_name_enemy_kingdom"
          });
          Pistol.equipmentType = EquipmentType.Weapon;
          Pistol.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(Pistol);
          Localization.addLocalization("item_Pistol", "Pistol");
          addGunsSprite(Pistol.id, Pistol.materials[0]);

          //Beastmen

          ItemAsset Club = AssetManager.items.clone("Club", "_melee");
          Club.id = "Club";
          Club.path_slash_animation = "effects/slashes/slash_sword";
          Club.materials = List.Of<string>(new string[]{"wood",});
          Club.base_stats[S.damage] = 1;
          Club.base_stats[S.attack_speed] = 40;
          Club.name_templates = Toolbox.splitStringIntoList(new string[]
          {
          "sword_name#30",
      		"sword_name_king#3",
      		"weapon_name_city",
      		"weapon_name_kingdom",
      		"weapon_name_culture",
      		"weapon_name_enemy_king",
      		"weapon_name_enemy_kingdom"
          });
          Club.equipmentType = EquipmentType.Weapon;
          Club.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(Club);
          Localization.addLocalization("item_Club", "Club");
          addGunsSprite(Club.id, Club.materials[0]);

          ItemAsset XBeast = AssetManager.items.clone("XBeast", "_range");
          XBeast.id = "XBeast";
          XBeast.projectile = "arrow";
          XBeast.path_slash_animation = "effects/slashes/slash_punch";
          XBeast.tech_needed = "weapon_bow";
          XBeast.base_stats[S.targets] = 1;
          XBeast.base_stats[S.range] = 22f;
          XBeast.base_stats[S.critical_chance] = 0.5f;
          XBeast.base_stats[S.projectiles] = 1;
          XBeast.materials = List.Of<string>(new string[]{"wood"});
          XBeast.name_templates = Toolbox.splitStringIntoList(new string[]
          {
            "bow_name#30",
		        "weapon_name_city",
		        "weapon_name_kingdom",
		        "weapon_name_culture",
		        "weapon_name_enemy_king",
		        "weapon_name_enemy_kingdom"
          });
          XBeast.equipmentType = EquipmentType.Weapon;
          XBeast.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(XBeast);
          Localization.addLocalization("item_XBeast", "XBeast");
          addGunsSprite(XBeast.id, XBeast.materials[0]);

          //Demonic

          ItemAsset InfernalTrident = AssetManager.items.clone("InfernalTrident", "_melee");
          InfernalTrident.id = "InfernalTrident";
          InfernalTrident.path_slash_animation = "effects/slashes/slash_sword";
          InfernalTrident.materials = List.Of<string>(new string[]{"adamantine",});
          InfernalTrident.base_stats[S.damage] = 1;
          InfernalTrident.base_stats[S.attack_speed] = 40;
          InfernalTrident.name_templates = Toolbox.splitStringIntoList(new string[]
          {
          "sword_name#30",
      		"sword_name_king#3",
      		"weapon_name_city",
      		"weapon_name_kingdom",
      		"weapon_name_culture",
      		"weapon_name_enemy_king",
      		"weapon_name_enemy_kingdom"
          });
          InfernalTrident.equipmentType = EquipmentType.Weapon;
          InfernalTrident.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(InfernalTrident);
          Localization.addLocalization("item_InfernalTrident", "InfernalTrident");
          addGunsSprite(InfernalTrident.id, InfernalTrident.materials[0]);

          //Extra

          ItemAsset Katana = AssetManager.items.clone("Katana", "_melee");
          Katana.id = "Katana";
          Katana.path_slash_animation = "effects/slashes/slash_sword";
          Katana.materials = List.Of<string>(new string[]{"steel",});
          Katana.base_stats[S.damage] = 1;
          Katana.base_stats[S.attack_speed] = 40;
          Katana.name_templates = Toolbox.splitStringIntoList(new string[]
          {
          "sword_name#30",
      		"sword_name_king#3",
      		"weapon_name_city",
      		"weapon_name_kingdom",
      		"weapon_name_culture",
      		"weapon_name_enemy_king",
      		"weapon_name_enemy_kingdom"
          });
          Katana.equipmentType = EquipmentType.Weapon;
          Katana.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(Katana);
          Localization.addLocalization("item_Katana", "Katana");
          addGunsSprite(Katana.id, Katana.materials[0]);

          ItemAsset GreatSword = AssetManager.items.clone("GreatSword", "_melee");
          GreatSword.id = "GreatSword";
          GreatSword.path_slash_animation = "effects/slashes/slash_sword";
          GreatSword.materials = List.Of<string>(new string[]{"steel",});
          GreatSword.base_stats[S.damage] = 1;
          GreatSword.base_stats[S.attack_speed] = 40;
          GreatSword.name_templates = Toolbox.splitStringIntoList(new string[]
          {
          "sword_name#30",
      		"sword_name_king#3",
      		"weapon_name_city",
      		"weapon_name_kingdom",
      		"weapon_name_culture",
      		"weapon_name_enemy_king",
      		"weapon_name_enemy_kingdom"
          });
          GreatSword.equipmentType = EquipmentType.Weapon;
          GreatSword.name_class = "item_class_weapon";
          AssetManager.items.list.AddItem(GreatSword);
          Localization.addLocalization("item_GreatSword", "GreatSword");
          addGunsSprite(GreatSword.id, GreatSword.materials[0]);

          //DragonSlayer

          ItemAsset DragonSlayerSpear = AssetManager.items.clone("DragonSlayerSpear", "bow");
          DragonSlayerSpear.id = "DragonSlayerSpear";
          DragonSlayerSpear.name_templates = Toolbox.splitStringIntoList(new string[]
          {
          "spear_name#30",
          "sword_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"
          });
          DragonSlayerSpear.materials = List.Of<string>(new string[]{"adamantine"});
          DragonSlayerSpear.base_stats[S.fertility] = 0.0f;
          DragonSlayerSpear.base_stats[S.max_children] = 0f;
          DragonSlayerSpear.base_stats[S.max_age] = 0f;
          DragonSlayerSpear.base_stats[S.attack_speed] = 10;
          DragonSlayerSpear.base_stats[S.damage] = 40;
          DragonSlayerSpear.base_stats[S.speed] = 30f;
          DragonSlayerSpear.base_stats[S.health] = 0;
          DragonSlayerSpear.base_stats[S.accuracy] = 0f;
          DragonSlayerSpear.base_stats[S.range] = 10;
          DragonSlayerSpear.base_stats[S.armor] = 10;
          DragonSlayerSpear.base_stats[S.scale] = 0.0f;
          DragonSlayerSpear.base_stats[S.dodge] = 0f;
          DragonSlayerSpear.base_stats[S.targets] = 0f;
          DragonSlayerSpear.base_stats[S.critical_chance] = 0.0f;
          DragonSlayerSpear.base_stats[S.knockback] = 0f;
          DragonSlayerSpear.base_stats[S.knockback_reduction] = 0f;
          DragonSlayerSpear.base_stats[S.intelligence] = 0;
          DragonSlayerSpear.base_stats[S.warfare] = 0;
          DragonSlayerSpear.base_stats[S.diplomacy] = 0;
          DragonSlayerSpear.base_stats[S.stewardship] = 0;
          DragonSlayerSpear.base_stats[S.opinion] = 0f;
          DragonSlayerSpear.base_stats[S.loyalty_traits] = 0f;
          DragonSlayerSpear.base_stats[S.cities] = 0;
          DragonSlayerSpear.base_stats[S.zone_range] = 0;
          DragonSlayerSpear.equipment_value = 10000;
          DragonSlayerSpear.path_slash_animation = "effects/slashes/slash_spear";
          DragonSlayerSpear.tech_needed = "weapon_spear";
          DragonSlayerSpear.equipmentType = EquipmentType.Weapon;
          DragonSlayerSpear.name_class = "item_class_weapon";
          DragonSlayerSpear.action_special_effect = new WorldAction(cureeffect);
          DragonSlayerSpear.action_attack_target = new AttackAction(speareffect);
          AssetManager.items.list.AddItem(DragonSlayerSpear);
          Localization.addLocalization("item_DragonSlayerSpear", "Dragon Slayer Spear");
          addGunsSprite(DragonSlayerSpear.id, DragonSlayerSpear.materials[0]);
 
  
          ItemAsset DragonSlayerSword = AssetManager.items.clone("DragonSlayerSword", "bow");
          DragonSlayerSword.id = "DragonSlayerSword";
          DragonSlayerSword.name_templates = Toolbox.splitStringIntoList(new string[]
          {
          "sword_name#30",
          "sword_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"
          });
          DragonSlayerSword.materials = List.Of<string>(new string[]{"adamantine"});
          DragonSlayerSword.base_stats[S.fertility] = 0.0f;
          DragonSlayerSword.base_stats[S.max_children] = 0f;
          DragonSlayerSword.base_stats[S.max_age] = 0f;
          DragonSlayerSword.base_stats[S.attack_speed] = 20;
          DragonSlayerSword.base_stats[S.damage] = 30;
          DragonSlayerSword.base_stats[S.speed] = 30f;
          DragonSlayerSword.base_stats[S.health] = 0;
          DragonSlayerSword.base_stats[S.accuracy] = 0f;
          DragonSlayerSword.base_stats[S.range] = 10;
          DragonSlayerSword.base_stats[S.armor] = 10;
          DragonSlayerSword.base_stats[S.scale] = 0.0f;
          DragonSlayerSword.base_stats[S.dodge] = 0f;
          DragonSlayerSword.base_stats[S.targets] = 0f;
          DragonSlayerSword.base_stats[S.critical_chance] = 0.0f;
          DragonSlayerSword.base_stats[S.knockback] = 0f;
          DragonSlayerSword.base_stats[S.knockback_reduction] = 0f;
          DragonSlayerSword.base_stats[S.intelligence] = 0;
          DragonSlayerSword.base_stats[S.warfare] = 0;
          DragonSlayerSword.base_stats[S.diplomacy] = 0;
          DragonSlayerSword.base_stats[S.stewardship] = 0;
          DragonSlayerSword.base_stats[S.opinion] = 0f;
          DragonSlayerSword.base_stats[S.loyalty_traits] = 0f;
          DragonSlayerSword.base_stats[S.cities] = 0;
          DragonSlayerSword.base_stats[S.zone_range] = 0;
          DragonSlayerSword.equipment_value = 10000;
          DragonSlayerSword.path_slash_animation = "effects/slashes/slash_sword";
          DragonSlayerSword.tech_needed = "weapon_sword";
          DragonSlayerSword.equipmentType = EquipmentType.Weapon;
          DragonSlayerSword.name_class = "item_class_weapon";
          DragonSlayerSword.action_special_effect = new WorldAction(cureeffect);
          DragonSlayerSword.action_attack_target = new AttackAction(swordeffect);
          AssetManager.items.list.AddItem(DragonSlayerSword);
          Localization.addLocalization("item_DragonSlayerSword", "Dragon Slayer Sword");
          addGunsSprite(DragonSlayerSword.id, DragonSlayerSword.materials[0]);
 
  
          ItemAsset DragonSlayerBow = AssetManager.items.clone("DragonSlayerBow", "bow");
          DragonSlayerBow.id = "DragonSlayerBow";
          DragonSlayerBow.name_templates = Toolbox.splitStringIntoList(new string[]
          {
          "bow_name#30",
          "sword_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"
          });
          DragonSlayerBow.materials = List.Of<string>(new string[]{"adamantine"});
          DragonSlayerBow.projectile = "DragonSlayerArrow";
          DragonSlayerBow.base_stats[S.fertility] = 0.0f;
          DragonSlayerBow.base_stats[S.max_children] = 0f;
          DragonSlayerBow.base_stats[S.max_age] = 0f;
          DragonSlayerBow.base_stats[S.attack_speed] = 10;
          DragonSlayerBow.base_stats[S.damage] = 30;
          DragonSlayerBow.base_stats[S.speed] = 30f;
          DragonSlayerBow.base_stats[S.health] = 0;
          DragonSlayerBow.base_stats[S.accuracy] = 100f;
          DragonSlayerBow.base_stats[S.range] = 40;
          DragonSlayerBow.base_stats[S.armor] = 10;
          DragonSlayerBow.base_stats[S.scale] = 0.0f;
          DragonSlayerBow.base_stats[S.dodge] = 0f;
          DragonSlayerBow.base_stats[S.targets] = 5f;
          DragonSlayerBow.base_stats[S.critical_chance] = 0.0f;
          DragonSlayerBow.base_stats[S.knockback] = 0f;
          DragonSlayerBow.base_stats[S.knockback_reduction] = 0f;
          DragonSlayerBow.base_stats[S.intelligence] = 0;
          DragonSlayerBow.base_stats[S.warfare] = 0;
          DragonSlayerBow.base_stats[S.diplomacy] = 0;
          DragonSlayerBow.base_stats[S.stewardship] = 0;
          DragonSlayerBow.base_stats[S.opinion] = 0f;
          DragonSlayerBow.base_stats[S.loyalty_traits] = 0f;
          DragonSlayerBow.base_stats[S.cities] = 0;
          DragonSlayerBow.base_stats[S.zone_range] = 0;
          DragonSlayerBow.equipment_value = 10000;
          DragonSlayerBow.path_slash_animation = "effects/slashes/slash_bow";
          DragonSlayerBow.tech_needed = "weapon_bow";
          DragonSlayerBow.equipmentType = EquipmentType.Weapon;
          DragonSlayerBow.name_class = "item_class_weapon";
          DragonSlayerBow.action_special_effect = new WorldAction(cureeffect);
          DragonSlayerBow.action_attack_target = new AttackAction(boweffect);
          AssetManager.items.list.AddItem(DragonSlayerBow);
          Localization.addLocalization("item_DragonSlayerBow", "DragonSlayerBow");
          addGunsSprite(DragonSlayerBow.id, DragonSlayerBow.materials[0]);

          ProjectileAsset DragonSlayerArrow = new ProjectileAsset();
          DragonSlayerArrow.id = "DragonSlayerArrow";
		      DragonSlayerArrow.texture = "DragonSlayerArrow";
          DragonSlayerArrow.texture_shadow = "shadow_arrow";
          DragonSlayerArrow.sound_launch = "event:/SFX/WEAPONS/WeaponStartArrow";
		      DragonSlayerArrow.sound_impact = "event:/SFX/HIT/HitGeneric";
          DragonSlayerArrow.parabolic = true;
          DragonSlayerArrow.speed = 18f;
          AssetManager.projectiles.add(DragonSlayerArrow);

          ProjectileAsset DragonSlayerEffect = new ProjectileAsset();
          DragonSlayerEffect.id = "DragonSlayerEffect";
		      DragonSlayerEffect.texture = "DragonSlayerEffect";
          DragonSlayerArrow.parabolic = true;
          DragonSlayerEffect.speed = 18f;
          AssetManager.projectiles.add(DragonSlayerEffect);

        }
        public static bool boweffect(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
        if(pTarget != null){
        Actor a = Reflection.GetField(pTarget.GetType(), pTarget, "a") as Actor;
        if(Toolbox.randomChance(0.1f)){
        ActionLibrary.castFire(null, pTarget, null);
        }}
        return false;
  
        }
        public static bool cureeffect(BaseSimObject pTarget, WorldTile pTile = null)
        {
        Actor a = Reflection.GetField(pTarget.GetType(), pTarget, "a") as Actor;
        if(Toolbox.randomChance(0.0025f)){
        
        World.world.dropManager.spawn(pTile, "cure", 15f, -1f);

        World.world.dropManager.spawn(pTile, "cure", 15f, -1f);

        World.world.dropManager.spawn(pTile, "cure", 15f, -1f);

        World.world.dropManager.spawn(pTile, "cure", 15f, -1f);

        World.world.dropManager.spawn(pTile, "cure", 15f, -1f);

        World.world.dropManager.spawn(pTile, "cure", 15f, -1f);

        }
        return false;
  
        }
        public static bool swordeffect(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
        if(pTarget != null){
        Actor a = Reflection.GetField(pTarget.GetType(), pTarget, "a") as Actor;
        if(Toolbox.randomChance(0.1f)){
        ActionLibrary.addBurningEffectOnTarget(null, pTarget, null);
        }}
        return false;
  
        }
        public static bool speareffect(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
        if(pTarget != null){
        Actor a = Reflection.GetField(pTarget.GetType(), pTarget, "a") as Actor;
        if(Toolbox.randomChance(0.1f)){
        EffectsLibrary.spawnExplosionWave(pTile.posV3, 3f, 0.5f);

        World.world.applyForce(pTile, 3, 0.3f, true, true, 0, null, pTarget, null);

        ActionLibrary.addBurningEffectOnTarget(null, pTarget, null);
        }}
        return false;

          //End

            }
            static void addGunsSprite(string id, string material)
            {
              var dictItems = Reflection.GetField(typeof(ActorAnimationLoader), null, "dictItems") as Dictionary<string, Sprite>;
              var sprite = Resources.Load<Sprite>("guns/w_" + id + "_" + material);
              dictItems.Add(sprite.name, sprite);
            }
      }
}