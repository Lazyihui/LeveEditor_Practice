using System;
using UnityEngine;


public static class GameFactory {
    public static PlayerEntity Player_Create(GameContext ctx, Vector3 pos, int typeID) {

        ctx.assetsContext.TryGetEntity("PlayerEntity", out GameObject prefab);

        bool has = ctx.templateContext.player.TryGetValue(typeID, out PlayerTM tm);
        if(!has) {
            Debug.LogError("PlayerTM not found");
            return null;
        }

        GameObject go = GameObject.Instantiate(prefab);
        PlayerEntity entity = go.GetComponent<PlayerEntity>();

        entity.Ctor();
        entity.typeID = typeID;
        entity.id = ctx.gameEntity.playerRecordID++;
        entity.hp = tm.hp;
        entity.hpMax = tm.hpMax;

        entity.SetColor(tm.color);

        return entity;

    }

    public static GroundEntity Ground_Create(GameContext ctx,  int typeID) {

        ctx.assetsContext.TryGetEntity("GroundEntity", out GameObject prefab);

        bool has = ctx.templateContext.ground.TryGetValue(typeID, out GroundTM tm);
        if(!has) {
            Debug.LogError("GroundTM not found");
            return null;
        }

        GameObject go = GameObject.Instantiate(prefab);
        GroundEntity entity = go.GetComponent<GroundEntity>();

        entity.Ctor();
        entity.typeID = typeID;
        entity.id = ctx.gameEntity.groundRecordID++;

        entity.SetColor(tm.color);

        return entity;

    }

}