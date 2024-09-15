using System;
using System.Collections.Generic;
using UnityEngine;



namespace LevelPractice
{


    public class AssetsCore : MonoBehaviour
    {
        Dictionary<int, StageSo> stages;

        Dictionary<int, GearSo> gears;

        public void Ctor()
        {
            stages = new Dictionary<int, StageSo>();
            gears = new Dictionary<int, GearSo>();
        }

        public void Init()
        {
            StageSo[] stageSos = Resources.LoadAll<StageSo>("");
            for (int i = 0; i < stageSos.Length; i++)
            {
                StageSo so = stageSos[i];
                stages.Add(so.tm.typeID, so);
            }

            GearSo[] gearSos = Resources.LoadAll<GearSo>("");
            for (int i = 0; i < gearSos.Length; i++)
            {
                GearSo so = gearSos[i];
                gears.Add(so.tm.typeID, so);
            }

        }

        // 获取某一关的数据
        public bool Stage_TryGet(int stageID, out StageTM tm)
        {
            StageSo so;
            if (stages.TryGetValue(stageID, out so))
            {
                tm = so.tm;
                return true;
            }
            else
            {
                tm = default;
                return false;
            }

        }
    }

}