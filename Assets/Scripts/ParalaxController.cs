using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParalaxController : MonoBehaviour
{
    [Range(0f, 0.20f)]
    public float parallaxSpeed = 0.02f;
    public RawImage background1;
    public RawImage background2;
    public RawImage background3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float finalSpeed = parallaxSpeed * Time.deltaTime;
        background1.uvRect = new Rect(background1.uvRect.x + finalSpeed, 0f, 1f, 1f);
        background2.uvRect = new Rect(background2.uvRect.x + finalSpeed * 2, 0f, 1f, 1f);
        background3.uvRect = new Rect(background3.uvRect.x + finalSpeed * 4, 0f, 1f, 1f);
    }
}
