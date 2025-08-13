using HarmonyLib;
using RimWorld;
using Verse;

namespace MUR_PawnNameVariety;

[HarmonyPatch(typeof(PawnBioAndNameGenerator), nameof(PawnBioAndNameGenerator.TryGetRandomUnusedSolidName))]
public class PawnBioAndNameGenerator_TryGetRandomUnusedSolidName
{
    private static void Postfix(ref NameTriple __result)
    {
        if (__result != null && !Prefs.PreferredNames.Contains(__result.ToStringFull) &&
            Rand.Value >= PNVSettings.chance)
        {
            __result = null;
        }
    }
}