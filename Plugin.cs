using System;
using BepInEx;
using BepInEx.Logging;
using GameNetcodeStuff;
using HarmonyLib;
using UnityEngine;
namespace betterFasterStrongerSlimes;

[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
  private void Awake()
  {
    // Plugin load logic goes here!
    // This script acts like a unity object.
    Logger.LogInfo($"Better Faster Stronger Slimes Active!");
  }

  [HarmonyPatch(typeof(BlobAI), "Start")]

  class myClass
  {
    private static void Postfix(ref BlobAI __instance)
    {
      ManualLogSource mls = BepInEx.Logging.Logger.CreateLogSource(PluginInfo.PLUGIN_GUID);
      for(int i = 0; i < __instance.maxDistanceForSlimeRays.Length; i++)
      {
        //__instance.maxDistanceForSlimeRays[i] = 9f;
        //__instance.SlimeBonePositions[i] = __instance.SlimeBones[i].tranform.position;
        mls.LogInfo($"In the loop");
      }
    }
  }

}
