using System;
using UnityEngine;


namespace LevelPractice
{

    [Serializable] //这是啥意思不懂
    public struct StageTM
    {

        public int typeID;
        public GearSpawnerTM[] gearSpawners;
    }

}