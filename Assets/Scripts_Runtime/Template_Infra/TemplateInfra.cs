using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;



public static class TemplateInfra {


    public static void Load(TemplateContext ctx) {
        {
            AssetLabelReference labelReference = new AssetLabelReference();
            labelReference.labelString = "So_Player";
            var ptr = Addressables.LoadAssetsAsync<PlayerSo>(labelReference, null);
            var list = ptr.WaitForCompletion();
            foreach (var so in list) {
                var tm = so.tm;
                ctx.player.Add(tm.typeID, tm);
            }
            ctx.playerPtr = ptr;

        }

        {
            AssetLabelReference labelReference = new AssetLabelReference();
            labelReference.labelString = "So_Ground";
            var ptr = Addressables.LoadAssetsAsync<GroundSo>(labelReference, null);
            var list = ptr.WaitForCompletion();
            foreach (var so in list) {
                var tm = so.tm;
                ctx.ground.Add(tm.typeID, tm);
            }
            ctx.groundPtr = ptr;
        }
    }


    public static void Unload(TemplateContext ctx) {
        if (ctx.playerPtr.IsValid()) {
            Addressables.Release(ctx.playerPtr);
        }
    }

}