using System;
using UnityEngine;


namespace LevelPractice
{
    public static class Factory
    {

        public static GearEntity CreateGear()
        {
            GameObject go = new GameObject("GearEntity");
            GearEntity gear = go.AddComponent<GearEntity>();
            return gear;
        }

    }
}