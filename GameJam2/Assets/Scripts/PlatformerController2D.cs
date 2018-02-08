using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script for 2D controls

public class PlatformerController2D : MonoBehaviour
{
  [HideInInspector] public Vector2 input;

  [Tooltip ("Can this object move.")]
  public bool canMove = true;

  [Header ("Controls")]
	[Tooltip ("Base maximum horizontal movement speed.")]
	[SerializeField] float speed = 5;
	[Tooltip ("Start velocity when jumping.")]
	[SerializeField] float jumpVelocity = 15;
	[Tooltip ("Downwards acceleration.")]
	[SerializeField] float gravity = 40;
	[Tooltip ("Time delay a jump is still performed, when grounding is gained after the jump button was pressed in the air.")]
	[SerializeField] float jumpingToleranceTimer = .1f;
	[Tooltip ("Time delay that a jump is still allowed when grounding is lost.")]
	[SerializeField] float groundingToleranceTimer = .1f;


}
