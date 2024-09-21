using System;
using UnityEngine;



public class GameContext {
    // inject 
    public AssetsContext assetsContext;
    // repository
    public PlayerRespository playerRespository;

    public GameContext() {
        playerRespository = new PlayerRespository();
    }

    public void Inject(AssetsContext assetsContext) {
        this.assetsContext = assetsContext;
    }


}