using System;
using UnityEngine;

namespace LevelPractice
{

    [Serializable]

    public struct GearTM
    {


        public int typeID;

        public string typeName;
        public float moveSpeed;

        public int hpMax;

        public GameObject modPrefab;

    }
}