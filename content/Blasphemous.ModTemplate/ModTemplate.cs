using Blasphemous.ModdingAPI;

namespace Blasphemous.ModTemplate;

public class ModTemplate : BlasMod
{
    public ModTemplate() : base(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_AUTHOR, ModInfo.MOD_VERSION) { }

    protected override void OnInitialize()
    {
        LogError($"{ModInfo.MOD_NAME} has been initialized");
    }
}
