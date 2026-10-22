using System.Reflection;
using HarmonyLib;
using Verse;

namespace MUR_PawnNameVariety;

[StaticConstructorOnStartup]
public static class HarmonyPatcher
{
    static HarmonyPatcher()
    {
        new Harmony("rimworld.murmur.pnv").PatchAll(Assembly.GetExecutingAssembly());
    }
}