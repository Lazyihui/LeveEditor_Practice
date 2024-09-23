using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;


public class TemplateContext {

    public Dictionary<int, PlayerTM> player;

    public AsyncOperationHandle playerPtr;

    public Dictionary<int, GroundTM> ground;

    public AsyncOperationHandle groundPtr;

    public Dictionary<int, StageTM> stage;

    public AsyncOperationHandle stagePtr;

    public TemplateContext() {
        player = new Dictionary<int, PlayerTM>();
        ground = new Dictionary<int, GroundTM>();
        stage = new Dictionary<int, StageTM>();
    }
    public bool Stage_TryGet(int typeID, out StageSo so) {

        StageTM tm;
        if (stage.TryGetValue(typeID, out tm)) {
            so = new StageSo();
            so.tm = tm;
            return true;
        } else {
            so = default;
            return false;
        }

    }

}