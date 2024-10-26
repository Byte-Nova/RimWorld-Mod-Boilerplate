using System.Globalization;
using System.Reflection;
using HarmonyLib;
using Verse;

public static class Main
{
    [StaticConstructorOnStartup]
    private static class YourModNameHere
    {
        static YourModNameHere()
        {
            ApplyHarmonyPathches();
            PrepareCulture();

            DisplayLoadMessage();
        }
    }

    private static void ApplyHarmonyPathches()
    {
        Harmony harmony = new Harmony(Master.modName);
        harmony.PatchAll(Assembly.GetExecutingAssembly());
    }

    private static void PrepareCulture()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
        CultureInfo.CurrentUICulture = new CultureInfo("en-US", false);
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US", false);
        CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US", false);
    }

    private static void DisplayLoadMessage() { Logger.Message("Mod loaded correctly"); }
}