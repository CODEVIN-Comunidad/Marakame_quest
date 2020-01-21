using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveGround : MonoBehaviour
{
    [Range(-30.0f, 0.0f)]
    public float moveSpeed =-5f;
    public Grid tilemap;
   
    private float finalSpeed;
    private bool move;
    // Start is called before the first frame update
    void Start()
    {
        move = false;
    }

    // Update is called once per frame
   void Update()
    {
        if (Input.anyKeyDown)
        {
            move = true;
        }

        if (move == true)
        {
            ParallaxMoveGround();
        }
    }

    private void ParallaxMoveGround()
    {
        finalSpeed = moveSpeed + finalSpeed;
        tilemap.transform.position = new Vector3(finalSpeed, tilemap.transform.position.y);
    }
}
