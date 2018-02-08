using UnityEngine;
using System.Collections;

//Player script. Manages players interaction with environment/enemies

public class Player : MonoBehaviour
{

  public enum PlayerStatus
	{
		Hurt,
		Active,
		InActive,
		Dead
	}

  PlatformerController2D controller;
  SpriteRenderer[] sr;
  PlayerStatus status;
  Coroutine hurtRoutine;


  void Awake ()
	{
		controller = GetComponent<PlatformerController2D> ();
		sr = GetComponentsInChildren<SpriteRenderer> ();
		status = PlayerStatus.Active;
	}







}
