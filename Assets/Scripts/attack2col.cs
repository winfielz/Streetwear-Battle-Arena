﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack2col : MonoBehaviour{

	private Player1Health player1Health;

    public int dmg = 1;

	void Start ()
	{
		GameObject player1Object = GameObject.FindGameObjectWithTag ("Player1");
		if (player1Object != null)
		{
			player1Health = player1Object.GetComponent <Player1Health>();
		}
		if (player1Health == null)
		{
			Debug.Log ("Cannot find 'Player2Health' script");
		}
	}

    void OnTriggerEnter2D(Collider2D other)
    {
		if (other.CompareTag("Player1"))
		{
			player1Health.TakeDamage (dmg);

			Collider2D collider = gameObject.GetComponentInParent(typeof(Collider2D)) as Collider2D;
			if (collider != null)
				collider.enabled = false;
		}
    }

}
