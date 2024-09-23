using System;
using UnityEngine;
using UnityEditor;


public class StageEM : MonoBehaviour {

    public int typeID;

    public StageSo so;

    // public StageTM tm;

    // 第一件事： 将数据保存到TM里，
    [ContextMenu("Save")]

    public void Save() {

        string n = "Stage_" + typeID;
        if (gameObject.name != n) {
            gameObject.name = n;
        }
        so.tm.typeID = typeID;



        Debug.Log("Save");

    }

    public void SavePlayer() {
        PlayerSpawnEM[] gearEMs = GetComponentsInChildren<PlayerSpawnEM>();
    }

}