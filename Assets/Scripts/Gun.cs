using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
	public Rigidbody2D rocket;				// Prefab of the rocket.
	public float speed = 20f;				// The speed the rocket will fire at.


	private PlayerControl playerCtrl;		// Reference to the PlayerControl script.
	private Animator anim;					// Reference to the Animator component.
	public Bazooka bazooka;

	void Awake()
	{
		// Setting up the references.
		anim = transform.root.gameObject.GetComponent<Animator>();
		playerCtrl = transform.root.GetComponent<PlayerControl>();

	}


	void Update ()
	{
		// If the fire button is pressed...
		if(Input.GetButtonDown("Fire1"))
		{
			// ... set the animator Shoot trigger parameter and play the audioclip.
//			anim.SetTrigger("Shoot");
			audio.Play();


			Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector3 relativePos = pos - bazooka.transform.position;
			relativePos.Normalize();

			// If the player is facing right...
			Rigidbody2D bulletInstance = Instantiate(rocket, transform.position, bazooka.transform.rotation) as Rigidbody2D;
			bulletInstance.velocity = new Vector2(relativePos.x * speed, relativePos.y * speed);

			// Rotate filte
		}
	}
}
