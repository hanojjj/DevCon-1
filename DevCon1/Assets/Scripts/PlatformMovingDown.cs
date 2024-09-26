using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovingDown : MonoBehaviour
{

    public float min = 2f;
    public float max = 3f;


    // Start is called before the first frame update
    void Start()
    {
       min = transform.position.y; 
       max = transform.position.y +10;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, Mathf.PingPong(Time.time *2 - 10f, max - min) + min);
    }
}
