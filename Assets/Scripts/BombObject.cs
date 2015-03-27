using System;
using UnityEngine;

public class BombObject: MonoBehaviour
{
	public BombObject ()
	{

	}

	void OnCollisionEnter (Collision col)
	{
		Debug.Log(col.transform.name);
//		if(col.gameObject.name == "prop_powerCube")
//		{
//			Destroy(col.gameObject);
//		}
	}
	
}