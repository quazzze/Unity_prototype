using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UIElements;

public class Player_movement : MonoBehaviour
{
    public float hor_speed = 3;
    public float vert_speed = 3;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector3((Input.GetAxis("Horizontal")) * hor_speed, 0, ((Input.GetAxis("Vertical"))) * vert_speed));
        
        if (rb.velocity.x > 0)
        {
            transform.rotation = new Quaternion(0, 180, 0 ,0);
        } else if (rb.velocity.x < 0)
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }
}