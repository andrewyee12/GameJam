using UnityEngine;
using System.Collections;

//Player script. Manages players interaction with environment/enemies

public class Player : MonoBehaviour
{
  [Tooltip("How fast is the spaceship moving left to right")]
    public float speed;

  public enum PlayerStatus
	{
		Hurt,
		Active,
		InActive,
		Dead
	}

	// Player item collection variables
	public float gunParts = 0;
	public bool hasGun = false;

  PlatformerController2D controller;
  SpriteRenderer[] sr;
  PlayerStatus status;
  Coroutine hurtRoutine;

  void Update()
  {
    // move the ship left and right, depending on the horizontal input
    transform.position += Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
    transform.position += Vector3.up * Input.GetAxis("Vertical") * speed * Time.deltaTime;

  }

  void Awake ()
	{
		controller = GetComponent<PlatformerController2D> ();
		sr = GetComponentsInChildren<SpriteRenderer> ();
		status = PlayerStatus.Active;
		gunParts = 0;
		hasGun = false;
	}

	// For collision with gun parts
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "GunPart") {
			Destroy(other.gameObject);
			gunParts += 1;

			if (gunParts >= 4) {
				hasGun = true;
			}

		} else if (other.gameObject.tag == "Wall") {
			// TODO - handle wall collision
		}
	}



}
