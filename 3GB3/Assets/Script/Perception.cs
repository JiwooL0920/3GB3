using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perception : MonoBehaviour
{
    public static int perceptionInt = 0;

    void update(){
        if (Input.GetKeyDown(KeyCode.T)){
            Debug.Log(perceptionInt);
        }
}
}

