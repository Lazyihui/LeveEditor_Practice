using System;
using UnityEngine;



[Serializable]
public class PlayerTM {

    public string typeName;
    public int typeID;

    public int hp;

    public int hpMax;

    [Header("color")]

    public Color color;

    public GameObject modPrefab;


}