using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    MainContext ctx;

    bool isTearDown = false;

    void Awake() {
        ctx = new MainContext();

        ctx.Inject();

        ModuleAssets.Load(ctx.assetsContext);




        Game_Business.Enter(ctx.gameContext);

    }

    void Update() {

    }

    void OnApplicationQuit() {
        TearDown();
    }

    void OnDestroy() {
        TearDown();
    }

    // 非官方生命周期
    void TearDown() {

        if (isTearDown) {
            return;
        }
        isTearDown = true;

        ModuleAssets.Unload(ctx.assetsContext);

    }
}
