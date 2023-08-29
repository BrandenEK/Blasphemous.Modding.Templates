using BepInEx;

namespace Blasphemous.ModTemplate
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    [BepInDependency("com.damocles.blasphemous.modding-api", "1.4.0")]
    public class Main : BaseUnityPlugin
    {
        public static ModTemplate ModTemplate { get; private set; }

        private void Start()
        {
            ModTemplate = new ModTemplate();
        }
    }
}
