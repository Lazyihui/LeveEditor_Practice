using System;
using UnityEngine;


public class PlayerEntity : MonoBehaviour {


    [SerializeField] public Transform body;

    public int typeID;
    public int id;

    public int hp;

    public int hpMax;

    public GameObject mod;

    public void Ctor() { }

    // public void SetColor(Color color) {
    //     meshRenderer.material.color = color;
    // }

    public void TF_SetPosition(Vector3 position) {
        transform.position = position;
    }

    public void TF_SetRotation(Vector3 eulerAngles) {
        transform.rotation = Quaternion.Euler(eulerAngles);
    }

    public void Mod_Init(GameObject mod) {
        this.mod = mod;
    }

}