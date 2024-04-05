using System;
using BepInEx;
using BepInEx.Logging;
using GameNetcodeStuff;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UIElements;
namespace betterFasterStrongerSlimes;

[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{

  Harmony harmony = new Harmony(PluginInfo.PLUGIN_GUID);
  private void Awake()
  {
    // Plugin load logic goes here!
    // This script acts like a unity object.
    Logger.LogInfo($"Better Faster Stronger Slimes Active!");
    harmony.PatchAll();
  }

  [HarmonyPatch(typeof(BlobAI), "Update")] //InitializeRPCS_BlobAI

  class updateBlob
  {
      ManualLogSource mls = BepInEx.Logging.Logger.CreateLogSource(PluginInfo.PLUGIN_GUID);
      //for(int i = 0; i < __instance.maxDistanceForSlimeRays.Length; i++)
      //mls.LogInfo(__instance.enemyHP);
      //for(int i = 0; i < __instance.)
      //{
        //__instance.maxDistanceForSlimeRays[i] = 9f;
        //__instance.SlimeBonePositions[i] = __instance.SlimeBones[i].tranform.position;
        //mls.LogInfo($"In the loop");
      this.agent.speed = 1f;
      //}
  }

}
