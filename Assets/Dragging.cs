using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragging : MonoBehaviour
{
	public GameObject finger;

	void Start()
	{
		finger = GameObject.FindGameObjectWithTag("finger");
	}

	void Update()
	{

	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "finger")
		{
			Vector3 speed = Vector3.zero;
			transform.position = Vector3.SmoothDamp(transform.position, finger.transform.position, ref speed, 0.01f);
		}
	}

	private void OnCollisionStay(Collision collision)
	{
		if (collision.gameObject.tag == "finger")
		{
			Vector3 speed = Vector3.zero;
			transform.position = Vector3.SmoothDamp(transform.position, finger.transform.position, ref speed, 0.01f);
		}
	}

}
