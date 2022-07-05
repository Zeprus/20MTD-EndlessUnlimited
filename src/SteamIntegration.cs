using flanne;
using HarmonyLib;

namespace EndlessUnlimited
{
    class SteamIntegrationPatch
    {
        [HarmonyPatch(typeof(SteamIntegration), "SubmitScore")]
        [HarmonyPatch(typeof(SteamIntegration), "ReplaceScore")]
        [HarmonyPrefix]
        static bool ScorePrefix()
        {
            return false;
        }
    }
}