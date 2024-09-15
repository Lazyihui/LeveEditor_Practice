using System;
using UnityEngine;

namespace LevelPractice
{
    // EM , Editor Model
    // TM , Template Model
    // Entity (Model)

    public class GearEM : MonoBehaviour
    {

        public GearTM tm;

        [ContextMenu("Save")]

        public void Save()
        {
        }

    }
}