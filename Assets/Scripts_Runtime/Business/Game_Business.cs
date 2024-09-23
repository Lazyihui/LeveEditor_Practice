using System;
using UnityEngine;



public static class Game_Business {
    public static void Enter(GameContext ctx) {

        // GroundDomain.Spawn(ctx, 1);

        // PlayerDomain.Spawn(ctx, new Vector3(0, 1, 0), 1);


        bool has = ctx.templateContext.Stage_TryGet(1, out StageTM tm);
        if (!has) {
            Debug.LogError("StageTM not found");
        }
        Debug.Log("创建关卡");

        PlayerSpawnTM[] players = tm.players;
        for (int i = 0; i < players.Length; i++) {
            PlayerSpawnTM player = players[i];

            PlayerEntity playerEntity = PlayerDomain.Spawn(ctx, player.so.tm.typeID, player);

        }


    }


    public static void Tick(GameContext ctx, float dt) {
        // int lenplayer = ctx.playerRespository.TakeAll(out PlayerEntity[] players);
        // for (int i = 0; i < lenplayer; i++) {
        //     PlayerEntity player = players[i];


        // }

    }
}