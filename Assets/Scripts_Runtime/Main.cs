using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace LevelPractice
{

    public class Mian : MonoBehaviour
    {

        [SerializeField] int stage;

        [SerializeField] AssetsCore assetsCore;

        void Awake()
        {

            assetsCore = new AssetsCore();
            assetsCore.Ctor();
            assetsCore.Init();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                EnterGame(stage);
            }
        }


        void EnterGame(int stage)
        {

            Debug.Log("Main EnterGame" + stage);
            bool has = assetsCore.Stage_TryGet(stage, out StageTM tm);
            if (!has)
            {
                Debug.LogError("没有这个关卡");
                return;
            }

            Debug.Log("创建关卡ID" + tm.typeID);
            GearSpawnerTM[] gearSpawners = tm.gearSpawners;
            for (int i = 0; i < gearSpawners.Length; i++)
            {
                GearSpawnerTM gearSpawner = gearSpawners[i];
                GearEntity entity = Factory.CreateGear(gearSpawner.so.tm.typeID, gearSpawner.position, gearSpawner.rotation);
            }
        }
    }
}
