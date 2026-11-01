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

namespace Isekai{
    [ModEntry]
    class Main : MonoBehaviour{
        #region
        public static Main instance;
        public IsekaiRaceLibrary IsekaiRaceLibrary = new IsekaiRaceLibrary();
        #endregion
        internal const string id = "agriche.mods.worldbox.isekai";
        internal static Harmony harmony;
        internal static Dictionary<string, UnityEngine.Object> modsResources;
        public List<string> addRaces = new List<string>(){"android", "darkelve", "beastmen", "gnome", "angel", "demonic", "japaneses", "ancientchina"};
        public IsekaiBuilds isekaiBuilds = new IsekaiBuilds();
        public BuildingLibrary buildingLibrary = new BuildingLibrary();
        public const string mainPath = "Mods/Isekai";

        void Awake(){
            modsResources = Reflection.GetField(typeof(ResourcesPatch), null, "modsResources") as Dictionary<string, UnityEngine.Object>;
            harmony = new Harmony(id);
            IsekaiNames.init();
            IsekaiKingdoms.init();
            IsekaiEffects.init();
            IsekaiTraitGroup.init();
            IsekaiTraits.init();
            IsekaiGuns.init();
            isekaiBuilds.init();
            buildingLibrary.init();
            IsekaiRaces.init();
            IsekaiRaceLibrary.init();
            IsekaiUnitys.init();
            //IsekaiGodzilla.init();
            IsekaiInvasions.init();
            IsekaiTab.init();
            IsekaiButtons.init();
            var dictItems = Reflection.GetField(typeof(ActorAnimationLoader), null, "dictItems") as Dictionary<string, Sprite>;
            ActorAnimationLoader.loadAnimationBoat($"boat_fishing");
            var fairy = AssetManager.actor_library.get("fairy");
            fairy.traits.Remove("energized");
            var bandit = AssetManager.actor_library.get("bandit");
            bandit.traits.Remove("energized");
            Reflection.CallStaticMethod(typeof(BannerGenerator), "loadTexturesFromResources", "android");
            Reflection.CallStaticMethod(typeof(BannerGenerator), "loadTexturesFromResources", "darkelve");
            Reflection.CallStaticMethod(typeof(BannerGenerator), "loadTexturesFromResources", "beastmen");
            Reflection.CallStaticMethod(typeof(BannerGenerator), "loadTexturesFromResources", "gnome");
            Reflection.CallStaticMethod(typeof(BannerGenerator), "loadTexturesFromResources", "angel");
            Reflection.CallStaticMethod(typeof(BannerGenerator), "loadTexturesFromResources", "demonic");
            instance = this;
        }
        void Start()
        {
        Harmony.CreateAndPatchAll(typeof(IsekaiRaceLibrary));
        }
    }
}