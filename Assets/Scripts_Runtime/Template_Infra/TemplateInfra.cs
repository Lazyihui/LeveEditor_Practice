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
            labelReference.labelString = "TM_Player";
            var ptr = Addressables.LoadAssetsAsync<PlayerTM>(labelReference, null);
            var list = ptr.WaitForCompletion();
            foreach (var go in list) {
                ctx.player.Add(go.typeID, go);
            }
            ctx.playerPtr = ptr;

        }
    }


    public static void Unload(TemplateContext ctx) {
        if (ctx.playerPtr.IsValid()) {
            Addressables.Release(ctx.playerPtr);
        }
    }

}