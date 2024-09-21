using System;
using System.Collections;
using UnityEngine;



public class MainContext {

    public AssetsContext assetsContext;

    public GameContext gameContext;

    public TemplateContext templateContext;


    public MainContext() {
        assetsContext = new AssetsContext();
        gameContext = new GameContext();
        templateContext = new TemplateContext();
    }

    public void Inject() {
        gameContext.Inject(assetsContext,templateContext);
    }


}