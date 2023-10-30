using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravity : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -3f;

    Vector3 velocity;

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");

        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed);

        velocity.y += gravity;    

        controller.Move(velocity);
    }
}
