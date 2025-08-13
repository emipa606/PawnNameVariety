using Mlie;
using UnityEngine;
using Verse;

namespace MUR_PawnNameVariety;

public class PNVMod : Mod
{
    public static PNVSettings settings;
    private static string currentVersion;

    public PNVMod(ModContentPack content)
        : base(content)
    {
        settings = GetSettings<PNVSettings>();
        currentVersion = VersionFromManifest.GetVersionFromModMetaData(content.ModMetaData);
    }

    public override string SettingsCategory()
    {
        return "Pawn Name Variety";
    }

    public override void DoSettingsWindowContents(Rect inRect)
    {
        var listing_Standard = new Listing_Standard();
        listing_Standard.Begin(new Rect(inRect.x, inRect.y + 24f, inRect.width, inRect.height - 24f));
        listing_Standard.verticalSpacing = 10f;
        listing_Standard.Gap(5f);
        listing_Standard.ColumnWidth = inRect.width;
        listing_Standard.Label(string.Format("PNW.predefined".Translate(Storage.sliderValue.ToString("F0"))));
        Storage.sliderValue = listing_Standard.Slider(Storage.sliderValue, 0f, 100f);
        if (currentVersion != null)
        {
            listing_Standard.Gap();
            GUI.contentColor = Color.gray;
            listing_Standard.Label("PNW.modVersion".Translate(currentVersion));
            GUI.contentColor = Color.white;
        }

        listing_Standard.End();
    }

    public override void WriteSettings()
    {
        PNVSettings.chance = Mathf.Round(Storage.sliderValue) / 100f;
        base.WriteSettings();
    }
}