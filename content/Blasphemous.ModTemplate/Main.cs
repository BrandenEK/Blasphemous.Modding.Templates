using BepInEx;

namespace Blasphemous.ModTemplate;

[BepInPlugin(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_VERSION)]
[BepInDependency("Blasphemous.ModdingAPI", "0.1.0")]
public class Main : BaseUnityPlugin
{
    public static ModTemplate ModTemplate { get; private set; }

    private void Start()
    {
        ModTemplate = new ModTemplate();
    }
}
