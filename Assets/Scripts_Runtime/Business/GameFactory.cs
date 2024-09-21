using System;
using UnityEngine;


public static class GameFactory {
    public static PlayerEntity Player_Create(GameContext ctx, Vector3 pos) {
        bool has = ctx.assetsContext.TryGetEntity("PlayerEntity", out GameObject prefab);
        if(!has) {
            Debug.LogError("PlayerEntity not found");
            return null;
        }

        GameObject go = GameObject.Instantiate(prefab);
        PlayerEntity entity = go.GetComponent<PlayerEntity>();

        entity.Ctor();

        return entity;


    }
}