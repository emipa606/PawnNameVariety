using HarmonyLib;
using RimWorld;
using Verse;

namespace MUR_PawnNameVariety;

[HarmonyPatch(typeof(PawnBioAndNameGenerator), "TryGetRandomUnusedSolidBioFor")]
public class PawnBioAndNameGenerator_TryGetRandomUnusedSolidBioFor
{
    private static void Postfix(ref PawnBio result, ref bool __result)
    {
        if (!__result || result == null || Prefs.PreferredNames.Contains(result.name.ToStringFull) ||
            !(Rand.Value >= PNVSettings.chance))
        {
            return;
        }

        result = null;
        __result = false;
    }
}