using System;
using System.Collections;
using UnityEngine;



public class MainContext {

    public AssetsContext assetsContext;

    public GameContext gameContext;


    public MainContext() {
        assetsContext = new AssetsContext();
        gameContext = new GameContext();
    }

    public void Inject() {
        gameContext.Inject(assetsContext);
    }


}