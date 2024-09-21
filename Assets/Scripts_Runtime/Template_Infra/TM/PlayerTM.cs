using System;
using UnityEngine;


[CreateAssetMenu(fileName = "PlayerTM_", menuName = "Template/PlayerTM")]
public class PlayerTM : ScriptableObject {
    public int typeID;

    public int hp;

    public int hpMax;

    [Header("color")]

    public Color color;


}