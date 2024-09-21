using System;
using UnityEngine;



public static class Game_Business {
    public static void Enter(GameContext ctx) {

        PlayerDomain.Spawn(ctx, new Vector3(0, 1, 0), 1);
    }


    public static void Tick(GameContext ctx, float dt) {
        int lenplayer = ctx.playerRespository.TakeAll(out PlayerEntity[] players);
        for (int i = 0; i < lenplayer; i++) {
            PlayerEntity player = players[i];


        }

    }
}