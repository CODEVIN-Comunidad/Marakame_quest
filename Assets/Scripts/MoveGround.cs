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
    private int state;
    // Start is called before the first frame update
    void Start()
    {
        state = 0;
    }

    // Update is called once per frame
   void Update()
    {
        if (Input.anyKeyDown)
        {
            state = 1;
        }

        if (state == 1)
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
