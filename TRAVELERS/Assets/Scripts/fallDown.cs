using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallDown : MonoBehaviour
{

	Rigidbody2D rb;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name.Equals("Player"))
		{
			Invoke("DropPlatform", 0.4f);
			Destroy(gameObject, 2f);
			Invoke("DesactiveCollider", 0.5f);
		}
	}

	void DropPlatform()
	{
		rb.isKinematic = false;
	}

	void DesactiveCollider()
    {
		gameObject.GetComponent<BoxCollider2D>().enabled = false;
	}

}
