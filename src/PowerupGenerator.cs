using flanne;
using HarmonyLib;

namespace EndlessUnlimited
{
    class PowerupGeneratorPatch
    {
        [HarmonyPatch(typeof(PowerupGenerator), "InitPowerupPool")]
        [HarmonyPrefix]
        static void InitPowerupPoolPrefix(ref int numTimesRepeatable)
        {
            numTimesRepeatable = EndlessUnlimited.Plugin.RepeatPowerups.Value;
        }
    }
}