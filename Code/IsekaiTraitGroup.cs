using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReflectionUtility;

namespace Isekai
{
    class IsekaiTraitGroup
    {
 
        public static string isekai = "isekai";
 
        public static void init()
        {
 
            ActorTraitGroupAsset isekai = new ActorTraitGroupAsset();
            isekai.id = "isekai";
            isekai.name = "trait_group_isekai";
            isekai.color = Toolbox.makeColor("#008000", -1f);
            AssetManager.trait_groups.add(isekai);
            addTraitGroupToLocalizedLibrary(isekai.id, "Isekai World");

        }
        private static void addTraitGroupToLocalizedLibrary(string id, string name)
        {
            string language = Reflection.GetField(LocalizedTextManager.instance.GetType(), LocalizedTextManager.instance, "language") as string;
            Dictionary<string, string> localizedText = Reflection.GetField(LocalizedTextManager.instance.GetType(), LocalizedTextManager.instance, "localizedText") as Dictionary<string, string>;
            localizedText.Add("trait_group_" + id, name);
        }
    }
}
