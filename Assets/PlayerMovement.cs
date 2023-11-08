using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpPower = 5f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //movement
    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Virtical");

        transform.Translate((new Vector3(h, 0, v) * speed) * Time.deltaTime);
    }
        
    //jump
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }
    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }
}
