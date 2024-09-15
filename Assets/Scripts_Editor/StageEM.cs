using System;
using UnityEngine;
using UnityEditor;


namespace LevelPractice
{

    // 用于编辑TM
    public class StageEM : MonoBehaviour
    {

        public int stageID;
        public StageSo so;

        [ContextMenu("Save")]
        public void Save()
        {

            so.tm.typeID = stageID;
            Debug.Log(so.tm.typeID);
            SaveGears();
        }

        void SaveGears()
        {
            // 查找所有的GearEM (EM)然后保存，

            GearEM[] gearEMs = GetComponentsInChildren<GearEM>();
            // 保存到TM里面
            GearTM[] gearTMs = new GearTM[gearEMs.Length];

            for (int i = 0; i < gearTMs.Length; i++)
            {
                GearEM em = gearEMs[i];
                em.Save();

                gearTMs[i] = em.tm;
            }

            so.tm.gears = gearTMs;
            EditorUtility.SetDirty(so);
        }


    }
}