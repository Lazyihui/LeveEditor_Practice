using System;
using UnityEngine;

namespace LevelPractice
{
    // EM , Editor Model
    // TM , Template Model
    // Entity (Model)
    [ExecuteInEditMode]
    public class GearSpawnEM : MonoBehaviour
    {

        public GearSpawnerTM spawnerTM;

        [ContextMenu("Save")]

        void Update()
        {
            var so = spawnerTM.so;
            if (so == null)
            {
                return;
            }

            var tm = so.tm;
            var prefab = tm.modPrefab;
            if (prefab == null)
            {
                return;
            }

            if (transform.childCount == 0)
            {
                var mod = GameObject.Instantiate(prefab, transform);
            }

            string n = "Gear_" + tm.typeName;
            if (gameObject.name != n)
            {
                gameObject.name = n;
            }
        }

        public void Save()
        {
            spawnerTM.position = transform.position;
            spawnerTM.rotation = transform.rotation.eulerAngles;

        }

    }
}