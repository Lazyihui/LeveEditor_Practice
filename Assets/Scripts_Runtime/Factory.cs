using System;
using UnityEngine;


namespace LevelPractice
{
    public static class Factory
    {

        public static GearEntity CreateGear(int typeID, Vector3 position, Vector3 rotation)
        {
            GameObject go = new GameObject("GearEntity");
            GearEntity gear = go.AddComponent<GearEntity>();
            return gear;
        }

    }
}