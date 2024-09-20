using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerRB;

    public GameObject Player;

    float inputHorizontal;
    float inputVertical;
    float inputJump;
    public float moveSpeed = 10f;
    public float jumpHeight = 1.0f;



    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");
        inputJump = Input.GetAxisRaw("Jump");

        if(inputHorizontal != 0)
        {
            playerRB.AddForce(new Vector2(inputHorizontal * moveSpeed, 0f));
        }
        

        if (inputJump != 0 && playerRB.velocity.y == 0)
        {
            playerRB.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
        }

    }
}
