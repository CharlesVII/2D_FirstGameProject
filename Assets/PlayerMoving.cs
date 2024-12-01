using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    public string PlayerName;
    // Start is called before the first frame update
    void Start()
    {
        PlayerName = "Hoai";
        Debug.Log(PlayerName);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    public void PlayerMove() 
    {
        Vector3 movingDistance = new Vector3( 0.01f, 0, 0);
       
        transform.position += movingDistance;
    }
}