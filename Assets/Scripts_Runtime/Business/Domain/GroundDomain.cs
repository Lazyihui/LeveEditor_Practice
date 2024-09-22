using System;
using UnityEngine;


public static class GroundDomain {


    public static GroundEntity Spawn(GameContext ctx, int typeID){

        GroundEntity groundEntity = GameFactory.Ground_Create(ctx, typeID);

        ctx.groundRespository.Add(groundEntity);
        return groundEntity;


    }
}