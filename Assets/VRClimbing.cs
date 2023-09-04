using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class VRClimbing : MonoBehaviour
{
    public Transform leftHand;
    public Transform rightHand;
    public float climbingSpeed = 1f;
    public bool isClimbing = false;

    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Check if at least one hand is above the player's head and touching a climbable object to initiate climbing.
        if ((leftHand.position.y > transform.position.y && leftHand.GetComponent<Collider>().CompareTag("Climbable")) ||
            (rightHand.position.y > transform.position.y && rightHand.GetComponent<Collider>().CompareTag("Climbable")))
        {
            isClimbing = true;
        }
        else
        {
            isClimbing = false;
        }

        // If climbing is active and at least one hand is touching a climbable object, move the player based on hand velocity.
        if (isClimbing)
        {
            //Vector3 climbDirection = -(leftHand.velocity + rightHand.velocity) * climbingSpeed;
            //characterController.Move(climbDirection * Time.deltaTime);
        }
    }
}
