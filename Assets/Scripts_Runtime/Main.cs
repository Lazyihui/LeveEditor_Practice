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
        TemplateInfra.Load(ctx.templateContext);




        Game_Business.Enter(ctx.gameContext);

    }

    void Update() {

        float dt = Time.deltaTime;

        Game_Business.Tick(ctx.gameContext, dt);

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
        TemplateInfra.Unload(ctx.templateContext);
    }
}
