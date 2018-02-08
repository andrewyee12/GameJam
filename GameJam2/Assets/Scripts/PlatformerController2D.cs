using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script for 2D controls

public class PlatformerController2D : MonoBehaviour
{
  [HideInInspector] public Vector2 input;

  [Tooltip ("Can this object move.")]git
  public bool canMove = true;

  [Header ("Controls")]
	[Tooltip ("Base maximum horizontal + vertical movement speed.")]
	[SerializeField] float speed = 5;

  bool AtWall = false;
  Rigidbody2D rb2d = null;
  SpriteRenderer sr = null;
  Animator anim = null;

  void Start ()
	{
		canMove = true;
		rb2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		sr = GetComponent<SpriteRenderer> ();
	}

/// Controls the basic update of the controller.

  void FixedUpdate ()
  {


  }

  void UpdateNextToWall ()
  {


  }



}
