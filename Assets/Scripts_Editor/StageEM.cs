using System;
using UnityEngine;
using UnityEditor;


public class StageEM : MonoBehaviour {

    public int tyoeID;

    // public StageSo so;

    public StageTM tm;

    // 第一件事： 将数据保存到TM里，
    [ContextMenu("Save")]

    public void Save() {
    
        // so.tm.typeID = tyoeID;

        Debug.Log("Save");

    }

     

}