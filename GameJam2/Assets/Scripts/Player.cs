using UnityEngine;
using UnityEngine.SceneManagement;
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
    public static bool hasGun = false;
    public GameObject bullet;

    PlatformerController2D controller;
    SpriteRenderer[] sr;
    PlayerStatus status;
    Coroutine hurtRoutine;
    Rigidbody2D player = null;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    //  void Update()
    //{
    // move the ship left and right, depending on the horizontal input

    //transform.position += Vector3.right * direction.x * speed * Time.deltaTime;
    //transform.position += Vector3.up * direction.y * speed * Time.deltaTime;

    //}
    void FixedUpdate()
    {
        Vector3 direction = new Vector3(0, 0, 0);
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
        direction = direction.normalized;

        Vector2 vel = direction * speed;
        player.velocity = vel;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            if (hasGun)
            {
                Instantiate(bullet, transform.position, Quaternion.identity);
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<SpriteRenderer>().flipX = true;
            bullet.GetComponent<Projectile>().direction = new Vector2(-1, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<SpriteRenderer>().flipX = false;
            bullet.GetComponent<Projectile>().direction = new Vector2(1, 0);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COLLISION");
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGER");
    }

    void Awake ()
	{
		controller = GetComponent<PlatformerController2D> ();
		sr = GetComponentsInChildren<SpriteRenderer> ();
		status = PlayerStatus.Active;
		hasGun = false;
	}

	// For collision with gun parts
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "GunPart") {
			Destroy(other.gameObject);

			if (!hasGun) {
				hasGun = true;
			}

		} else if (other.gameObject.tag == "Wall") {
			// TODO - handle wall collision
		} else if (other.gameObject.tag == "Monster" || other.gameObject.tag == "StaticMonster" || other.gameObject.tag == "Lava") {
            
            gameObject.GetComponent<Renderer>().enabled = false;
            int scene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(0, LoadSceneMode.Single);

        }
	}

}
