using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Module for player controller input when using a PlatformController2D.

public class PlayerInputModule2D : MonoBehaviour

{

  PlatformController2D controller;

  void Start ()
  {
    controller = GetComponent<PlatformController2D> ();
  }

  void FixedUpdate ()
  {
    Vector2 input = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));
    if (input.magnitude > 1) {
      input.Normalize ();
    }
    controller.input = input; 
  }



}
