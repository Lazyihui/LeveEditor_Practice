using System;
using UnityEngine;



public static class Game_Business {
    public static void Enter(GameContext ctx) {

        PlayerDomain.Spawn(ctx, new Vector3(0, 1, 0));
    }


    public static void Tick(GameContext ctx, float dt) { }
}