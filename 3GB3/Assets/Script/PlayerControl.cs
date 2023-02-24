using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    private Vector3 startPos = Vector3.zero;
    
    public float speed;
    public float sensitivity;
    private Vector2 movePos;

    public int maxX = 2;
    public int maxY = 2;
    public int minX = -2;
    public int minY = -2;

    void Start() {
        SetPos();
    }

    public void SetPos() {
        transform.position = startPos;
        movePos = startPos;
    }

    void FixedUpdate() {
        float horizontal = Input.GetAxis("Horizontal") * sensitivity;
        float vertical = Input.GetAxis("Vertical") * sensitivity;

        movePos.x += horizontal;
        movePos.y += vertical;

        movePos.x = Mathf.Clamp(movePos.x, minX, maxX);
        movePos.y = Mathf.Clamp(movePos.y, minY, maxY);
    
        transform.position = Vector2.Lerp(transform.position, movePos, speed * Time.deltaTime);
    }
}