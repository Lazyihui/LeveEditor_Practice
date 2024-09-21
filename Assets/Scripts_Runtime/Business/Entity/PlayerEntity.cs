using System;
using UnityEngine;


public class PlayerEntity : MonoBehaviour {

    [SerializeField] MeshRenderer meshRenderer;

    public int typeID;
    public int id;

    public int hp;

    public int hpMax;


    public void Ctor() { }

    public void SetColor(Color color) {
        meshRenderer.material.color = color;
    }

}