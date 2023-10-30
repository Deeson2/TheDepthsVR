using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ClimbGravity : MonoBehaviour
{

  public CharacterController character;

  Vector3 velocity;
  public void FixedUpdate()
  {
    velocity.y = -3f;
  }

}
