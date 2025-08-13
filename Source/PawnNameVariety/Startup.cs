using System.Collections.Generic;
using System.Reflection;
using RimWorld;
using Verse;

namespace MUR_PawnNameVariety;

[StaticConstructorOnStartup]
public class Startup
{
    static Startup()
    {
        var value = typeof(NameBank).GetField("names", BindingFlags.Instance | BindingFlags.NonPublic)
            ?.GetValue(PawnNameDatabaseShuffled.BankOf(PawnNameCategory.HumanStandard));
        var array = value as List<string>[,];
        var list = new List<string>();
        var list2 = new List<string>();
        var list3 = new List<string>();
        var list4 = new List<string>();
        var list5 = new List<string>();
        var list6 = new List<string>();
        var list7 = new List<string>();
        foreach (var allBio in SolidBioDatabase.allBios)
        {
            switch (allBio.gender)
            {
                case GenderPossibility.Either:
                {
                    if (allBio.name.First != null &&
                        array != null &&
                        !array[0, 0].Contains(allBio.name.First) &&
                        !list5.Contains(allBio.name.First))
                    {
                        list5.Add(allBio.name.First);
                    }

                    if (allBio.name.Nick != null &&
                        array != null &&
                        !array[0, 2].Contains(allBio.name.Nick) &&
                        !list5.Contains(allBio.name.Nick))
                    {
                        list6.Add(allBio.name.Nick);
                    }

                    break;
                }
                case GenderPossibility.Male:
                {
                    if (allBio.name.First != null &&
                        array != null &&
                        !array[1, 0].Contains(allBio.name.First) &&
                        !list.Contains(allBio.name.First))
                    {
                        list.Add(allBio.name.First);
                    }

                    if (allBio.name.Nick != null &&
                        array != null &&
                        !array[1, 2].Contains(allBio.name.Nick) &&
                        !list2.Contains(allBio.name.Nick))
                    {
                        list2.Add(allBio.name.Nick);
                    }

                    break;
                }
                case GenderPossibility.Female:
                {
                    if (allBio.name.First != null &&
                        array != null &&
                        !array[2, 0].Contains(allBio.name.First) &&
                        !list3.Contains(allBio.name.First))
                    {
                        list3.Add(allBio.name.First);
                    }

                    if (allBio.name.Nick != null &&
                        array != null &&
                        !array[2, 2].Contains(allBio.name.Nick) &&
                        !list4.Contains(allBio.name.Nick))
                    {
                        list4.Add(allBio.name.Nick);
                    }

                    break;
                }
            }

            if (allBio.name.Last != null &&
                array != null &&
                !array[0, 1].Contains(allBio.name.Last) &&
                !list7.Contains(allBio.name.Last))
            {
                list7.Add(allBio.name.Last);
            }
        }

        foreach (var item in PawnNameDatabaseSolid.GetListForGender(GenderPossibility.Either))
        {
            if (item.First != null && array != null && !array[0, 0].Contains(item.First) && !list5.Contains(item.First))
            {
                list5.Add(item.First);
            }

            if (item.Last != null && array != null && !array[0, 1].Contains(item.Last) && !list7.Contains(item.Last))
            {
                list7.Add(item.Last);
            }

            if (item.Nick != null && array != null && !array[0, 2].Contains(item.Nick) && !list6.Contains(item.Nick))
            {
                list6.Add(item.Nick);
            }
        }

        foreach (var item2 in PawnNameDatabaseSolid.GetListForGender(GenderPossibility.Male))
        {
            if (item2.First != null && array != null && !array[1, 0].Contains(item2.First) &&
                !list.Contains(item2.First))
            {
                list.Add(item2.First);
            }

            if (item2.Last != null && array != null && !array[0, 1].Contains(item2.Last) && !list7.Contains(item2.Last))
            {
                list7.Add(item2.Last);
            }

            if (item2.Nick != null && array != null && !array[1, 2].Contains(item2.Nick) && !list2.Contains(item2.Nick))
            {
                list2.Add(item2.Nick);
            }
        }

        foreach (var item3 in PawnNameDatabaseSolid.GetListForGender(GenderPossibility.Female))
        {
            if (item3.First != null && array != null && !array[2, 0].Contains(item3.First) &&
                !list3.Contains(item3.First))
            {
                list3.Add(item3.First);
            }

            if (item3.Last != null && array != null && !array[0, 1].Contains(item3.Last) && !list7.Contains(item3.Last))
            {
                list7.Add(item3.Last);
            }

            if (item3.Nick != null && array != null && !array[2, 2].Contains(item3.Nick) && !list4.Contains(item3.Nick))
            {
                list4.Add(item3.Nick);
            }
        }

        PawnNameDatabaseShuffled.BankOf(PawnNameCategory.HumanStandard).AddNames(PawnNameSlot.First, Gender.Male, list);
        PawnNameDatabaseShuffled.BankOf(PawnNameCategory.HumanStandard)
            .AddNames(PawnNameSlot.First, Gender.Female, list3);
        PawnNameDatabaseShuffled.BankOf(PawnNameCategory.HumanStandard)
            .AddNames(PawnNameSlot.First, Gender.None, list5);
        PawnNameDatabaseShuffled.BankOf(PawnNameCategory.HumanStandard).AddNames(PawnNameSlot.Nick, Gender.Male, list2);
        PawnNameDatabaseShuffled.BankOf(PawnNameCategory.HumanStandard)
            .AddNames(PawnNameSlot.Nick, Gender.Female, list4);
        PawnNameDatabaseShuffled.BankOf(PawnNameCategory.HumanStandard).AddNames(PawnNameSlot.Nick, Gender.None, list6);
        PawnNameDatabaseShuffled.BankOf(PawnNameCategory.HumanStandard).AddNames(PawnNameSlot.Last, Gender.None, list7);

        Storage.sliderValue = PNVSettings.chance * 100f;
    }
}