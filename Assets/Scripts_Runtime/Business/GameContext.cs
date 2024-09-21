using System;
using UnityEngine;



public class GameContext {
    public GameEntity gameEntity;
    // inject 
    public AssetsContext assetsContext;

    public TemplateContext templateContext;
    // repository
    public PlayerRespository playerRespository;

    public GameContext() {
        playerRespository = new PlayerRespository();
        gameEntity = new GameEntity();
    }

    public void Inject(AssetsContext assetsContext, TemplateContext templateContext) {
        this.assetsContext = assetsContext;
        this.templateContext = templateContext;
    }


}