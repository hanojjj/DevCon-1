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
        //sets the camera position to the players position
        camerPos = new Vector3(Player.position.x, Player.position.y, -10f);
        //adds a damp effect to make the camera movement more smooth
        transform.position = Vector3.SmoothDamp(gameObject.transform.position, camerPos, ref velocity, dampTime);
    }
}
