using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Player;
    public float dampTime = 0.4f;
    private Vector3 camerPos;
    private Vector3 velocity = Vector3.zero;
    
    void Update()
    {
        camerPos = new Vector3(Player.position.x, gameObject.transform.position.y, -10f);
        transform.position = Vector3.SmoothDamp(gameObject.transform.position, camerPos, ref velocity, dampTime);
    }
}
