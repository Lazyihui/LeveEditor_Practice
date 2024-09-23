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

        SavePlayer();

    }

    public void SavePlayer() {
        PlayerSpawnEM[] playersEM = GetComponentsInChildren<PlayerSpawnEM>();
        PlayerSpawnTM[] playersTM = new PlayerSpawnTM[playersEM.Length];
        for (int i = 0; i < playersTM.Length; i++) {
            PlayerSpawnEM em = playersEM[i];

            em.Save();
            playersTM[i] = em.spawnerTM;
        }
        so.tm.players = playersTM;
        EditorUtility.SetDirty(so);
    }

}