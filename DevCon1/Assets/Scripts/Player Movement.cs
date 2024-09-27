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

    //collision check to disable objects
    public PlatformMovingUp platformOne;
    public PlatformMovingUp platformTwo;
    public PlatformMovingUp platformThree;
    public PlatformMovingUp platformSeven;
    public PlatformMovingUp platformEight;
    public PlatformMovingUp platformNine;
    public PlatformMovingDown platformFour;
    public PlatformMovingDown platformFive;
    public PlatformMovingDown platformSix;


    // Start is called before the first frame update
    void Start()
    {
        //allows us to control the players ridgidbody outside of the script
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //takes the input for moving right, left and jumping
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");
        inputJump = Input.GetAxisRaw("Jump");

        //makes the player move if the correct button is pressed
        if(inputHorizontal != 0)
        {
            playerRB.AddForce(new Vector2(inputHorizontal * moveSpeed, 0f));
        }
        
        //makes the player jump if the correct button is pressed
        if (inputJump != 0 && playerRB.velocity.y == 0)
        {
            playerRB.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform Up"))
        {

            platformOne.enabled = false;
            platformTwo.enabled = false;
            platformThree.enabled = false;
        }        

        if (collision.gameObject.CompareTag("Platform Up 2"))
        {
            platformSeven.enabled = false;
            platformEight.enabled = false;
            platformNine.enabled = false;
        }
        if (collision.gameObject.CompareTag("Platform Down"))
        {

            platformFour.enabled = false;
            platformFive.enabled = false;
            platformSix.enabled = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        platformOne.enabled = true;
        platformTwo.enabled = true;
        platformThree.enabled = true;
        platformFour.enabled = true;
        platformFive.enabled = true;
        platformSix.enabled = true;
        platformSeven.enabled =true;
        platformEight.enabled = true;
        platformNine.enabled = true; 

    }
}
