using System;
using UnityEngine;


public static class PlayerDomain {
    public static PlayerEntity Spawn(GameContext ctx, Vector3 pos) {
        PlayerEntity entity = GameFactory.Player_Create(ctx, pos);
     
        ctx.playerRespository.Add(entity);
        return entity;
    }
}