using System;
using UnityEngine;


namespace LevelPractice
{
    public class GearEntity : MonoBehaviour
    {

        public int id;

        public int hp;

        public int hpMax;

        public void TF_SetPos(Vector3 pos)
        {
            transform.position = pos;
        }


        public void TF_SetRot(Quaternion rot)
        {
            transform.rotation = rot;
        }

    }
}