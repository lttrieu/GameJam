using UnityEngine;
using System.Collections;

public class Bazooka : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		if(Input.GetButtonDown("Fire1"))
		{
//			Debug.Log(Camera.main.transform.name);

			var mousePos = Input.mousePosition;
			mousePos.z = 10.0f; //The distance from the camera to the player object
			Vector3 lookPos  = Camera.main.ScreenToWorldPoint(mousePos);
			lookPos = lookPos - transform.position;
			float angle = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

//			Vector3 relativePos = pos - transform.position;
//			Quaternion rotation = Quaternion.LookRotation(relativePos);
//			transform.rotation = rotation;

		}
	}
}
