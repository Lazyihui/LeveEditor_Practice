using System;
using UnityEngine;


namespace LevelPractice{
    [Serializable]


    public struct GearSpawnerTM{

        public GearSo so;

        public Vector3 position;

        public Vector3 rotation;

        public bool isHpMaxModifiable;

        public int hpMax;
    }

}