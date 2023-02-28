// Tutorial - https://www.youtube.com/watch?v=FXqwunFQuao&ab_channel=AnupPrasad

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript  : MonoBehaviour
{
    public float cameraSpeed = 2f;
    public float offset_y =1f;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x,target.position.y + offset_y +100,-10f);
        transform.position = Vector3.Slerp(transform.position,newPos,cameraSpeed*Time.deltaTime);
    }
}