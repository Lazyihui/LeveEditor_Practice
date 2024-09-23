using System;
using UnityEngine;


public static class PlayerDomain {
    public static PlayerEntity Spawn(GameContext ctx, int typeID,PlayerSpawnTM spawnTM) {
        PlayerEntity entity = GameFactory.Player_Create(ctx, typeID, spawnTM);

        ctx.playerRespository.Add(entity);
        return entity;
    }
}