using System;
using UnityEngine;


namespace LevelPractice
{

    [Serializable] //这是啥意思不懂
    public struct StageTM
    {

        public int typeID;

        // 这样写是错的 要改
        public GearTM[] gears;
    }

}