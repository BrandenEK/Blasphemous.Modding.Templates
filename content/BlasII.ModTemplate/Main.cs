using MelonLoader;

namespace BlasII.ModTemplate;

public class Main : MelonMod
{
    public static ModTemplate ModTemplate { get; private set; }

    public override void OnLateInitializeMelon()
    {
        ModTemplate = new ModTemplate();
    }
}