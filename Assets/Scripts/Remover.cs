using UnityEngine;
using System.Collections;

public class Remover : MonoBehaviour
{
	public GameObject splash;


	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log(col.transform.name + " " + col.gameObject.tag);
		// If the player hits the trigger...
		if(col.gameObject.tag != "Player")
		{
			// ... instantiate the splash where the enemy falls in.
			Instantiate(splash, col.transform.position, transform.rotation);
			
			// Destroy the enemy.
			Destroy (col.gameObject);	
		}
	}


	void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.tag != "Player")
		{
			// ... instantiate the splash where the enemy falls in.
			Instantiate(splash, col.transform.position, transform.rotation);
			
			// Destroy the enemy.
			Destroy (col.gameObject);	
		}
		
	}
}
