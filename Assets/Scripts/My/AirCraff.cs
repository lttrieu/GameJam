using System;
using UnityEngine;

public class AirCraff: MonoBehaviour
{
	private Transform m_transform;
	private Rigidbody2D m_rigidbody;
	public float m_speed = 10f;
	public int m_hp = 1;
	private bool m_isDead = false;
	private bool m_facingRight = false;

	void Awake()
	{
		m_transform = transform;
	}

	void Start()
	{
		m_rigidbody = GetComponent<Rigidbody2D>();
		m_rigidbody.velocity = new Vector2(-m_speed, 0f);
	}

	void OnBecameInvisible()
	{
		Flip();
		if(m_transform.position.x > 0)
		{
//			Vector3 localRotate = 
			m_rigidbody.velocity = new Vector2(-m_speed, 0f);
		} 
		else
		{
			m_rigidbody.velocity = new Vector2(m_speed, 0f);
		}
	}

	void Flip ()
	{
		// Switch the way the player is labelled as facing.
		m_facingRight = !m_facingRight;
		
		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	public void Hurt()
	{
		m_hp--;
	}

	void Update()
	{
		if(!m_isDead && m_hp <= 0) 
		{
			Dead();
		}
	}

	void Dead()
	{
		Spawner.Remove(gameObject);
	}
}

