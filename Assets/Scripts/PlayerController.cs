using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;

    private Animator playerAnimation;
    private int state;
    public static string playerState;
    private int doubleJump;

    // Start is called before the first frame update
    void Start()
    {
        playerAnimation = GetComponent<Animator>();
        state = 0;
        doubleJump = 0;
        Jump.checkGround = false;
    }

    // Update is called once per frame
    void Update()
    {   
        player.transform.position = new Vector3(-72, player.transform.position.y);
        if (Input.anyKey && state == 0)
        {
            state = 1;
            playerState = "Run";
        }

        if(state == 1 && Input.GetKey("up"))
        {
            playerState = "Jump";
            doubleJump++;
        }

        if (state == 1)
        {
            if(playerState == "Run")
            {
                Run();
                Physics2D.gravity = new Vector2(0, -9.81f);
                doubleJump = 0;
                Jump.checkGround = false;
                if (Input.GetKeyDown("down"))
                {
                    playerState = "Sweep";
                }
                
            }
            else if(playerState == "Jump")
            {
                playerAnimation.Play("Jump");
                if (Input.GetKey("down"))
                {
                    Physics2D.gravity = new Vector2(0 , -40f);
                }

                if(doubleJump == 2)
                {
                    Jump.checkGround = true;
                }
            }
            else if(playerState == "Sweep")
            {
                playerAnimation.Play("Sweep");
            }


        }
    }

    private void Run()
    {
        playerAnimation.Play("Run");   
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if(collision.gameObject.tag == "Ground")
        {
            playerState = "Run";
        }
        
    }*/
}
