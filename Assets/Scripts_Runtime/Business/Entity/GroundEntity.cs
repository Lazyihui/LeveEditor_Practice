using System;
using UnityEngine;


public class GroundEntity : MonoBehaviour {

    [SerializeField] MeshRenderer meshRenderer;
    public int typeID;

    public int id;


    public void Ctor(){}

    public void SetColor(Color color){
        meshRenderer.material.color = color;
    }

}