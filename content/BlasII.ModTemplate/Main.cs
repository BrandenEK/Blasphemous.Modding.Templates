using MelonLoader;

namespace BlasII.ModTemplate;

internal class Main : MelonMod
{
    public static ModTemplate ModTemplate { get; private set; }

    public override void OnLateInitializeMelon()
    {
        ModTemplate = new ModTemplate();
    }
}