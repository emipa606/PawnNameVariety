using Verse;

namespace MUR_PawnNameVariety;

public class PNVSettings : ModSettings
{
    public static float chance;

    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look(ref chance, "chance", 0f, true);
    }
}