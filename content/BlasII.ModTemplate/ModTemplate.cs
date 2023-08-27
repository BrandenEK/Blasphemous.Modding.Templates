using BlasII.ModdingAPI;

namespace BlasII.ModTemplate
{
    public class ModTemplate : BlasIIMod
    {
        public ModTemplate() : base(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_AUTHOR, ModInfo.MOD_VERSION) { }

        protected override void OnInitialize()
        {
            LogError($"{ModInfo.MOD_NAME} is initialized");
        }
    }
}
