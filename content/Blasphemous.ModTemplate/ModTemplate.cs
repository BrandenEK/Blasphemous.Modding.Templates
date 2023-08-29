using ModdingAPI;

namespace Blasphemous.ModTemplate
{
    public class ModTemplate : Mod
    {
        public ModTemplate() : base(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION) { }

        protected override void Initialize()
        {
            Log($"{PluginInfo.PLUGIN_NAME} has been initialized");
        }
    }
}
