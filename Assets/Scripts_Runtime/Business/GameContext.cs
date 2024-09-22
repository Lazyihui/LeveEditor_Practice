using System;
using UnityEngine;



public class GameContext {
    public GameEntity gameEntity;
    // inject 
    public AssetsContext assetsContext;

    public TemplateContext templateContext;
    // repository
    public PlayerRespository playerRespository;

    public GroundRespository groundRespository;
    public GameContext() {
        gameEntity = new GameEntity();

        playerRespository = new PlayerRespository();
        groundRespository = new GroundRespository();

    }

    public void Inject(AssetsContext assetsContext, TemplateContext templateContext) {
        this.assetsContext = assetsContext;
        this.templateContext = templateContext;
    }


}