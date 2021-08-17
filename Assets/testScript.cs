using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{

    public float speed = 1f; 
    public float clamppos;

    Vector3 StartPosition;
    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float NewPosition = Mathf.Repeat(Time.time * speed, clamppos);
        transform.position = StartPosition +  Vector3.down * NewPosition;
        // if (transform.position.y < -508f){
        //     transform.position = StartPosition;
        // }
    }
}