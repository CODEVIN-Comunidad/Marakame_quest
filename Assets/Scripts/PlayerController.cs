using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;

    private Animator playerAnimation;
    private int state;
    private string playerState;

    // Start is called before the first frame update
    void Start()
    {
        playerAnimation = GetComponent<Animator>();
        state = 0;
    }

    // Update is called once per frame
    void Update()
    {
        player.transform.position = new Vector3(-72, player.transform.position.y);
        if (Input.anyKey)
        {
            state = 1;
            playerState = "Run";
        }

        if (state == 1 && Input.GetKey("up"))
        {
            playerState = "Jump";
        }
        /*else if(state == 1 && Input.GetKeyDown("dowm"))
        {
            playerState = "Sweep";
        }*/

        if (state == 1)
        {
            if(playerState == "Run")
            {
                Run();
            }
            else if(playerState == "Jump")
            {
                playerAnimation.Play("Jump");
            }
            /*else if(playerState == "Sweep")
            {
                playerAnimation.Play("Sweep");
            }*/
        }
    }

    private void Run()
    {
        playerAnimation.Play("Run");   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            playerState = "Run";
        }
    }
}
