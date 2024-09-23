using System;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class PlayerSpawnEM : MonoBehaviour {

    public PlayerSpawnTM spawnerTM;


    void Update() {
        var so = spawnerTM.so;
        if (so == null) {
            return;
        }
        var tm = so.tm;
        var prefab = tm.modPrefab;
        if (prefab == null) {
            return;
        }

        if (transform.childCount == 0) {
            var mod = GameObject.Instantiate(prefab, transform);
            Debug.Log(mod.name);
        }

        string n = "Player_" + tm.typeID;
        if (gameObject.name != n) {
            gameObject.name = n;
        }

    }


    [ContextMenu("Save")]

    public void Save() {
        Debug.Log("Save");

        spawnerTM.position = transform.position;
        spawnerTM.rotation = transform.rotation.eulerAngles;
    }
}