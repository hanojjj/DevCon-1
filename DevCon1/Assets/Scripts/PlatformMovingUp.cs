using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovingUp : MonoBehaviour
{

    public float min = 2f;
    public float max = 3f;


    // Start is called before the first frame update
    void Start()
    {
        //the min and max position the platforms can bounce between
        min = transform.position.y;
        max = transform.position.y + 10;
    }

    // Update is called once per frame
    void Update()
    {
        //makes the platform bounce up and down starting with up
        transform.position = new Vector2(transform.position.x, Mathf.PingPong(Time.time * 2, max - min) + min);
    }
}
