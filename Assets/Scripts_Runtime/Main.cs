using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mian : MonoBehaviour
{

    [SerializeField] int stage;



    void Awake()
    {
        Debug.Log("Main Awake");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            EnterGame(stage);
        }
    }


    void EnterGame(int stage)
    {

        Debug.Log("Main EnterGame" + stage);
        if (stage == 1)
        {

        }
        else if (stage == 2)
        {

        }

    }
}
